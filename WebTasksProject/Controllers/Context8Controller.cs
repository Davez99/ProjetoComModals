using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebTasksProject.Data;
using WebTasksProject.Models;

namespace WebTasksProject.Controllers
{
    [Authorize]
    public class Context8Controller : Controller
    {
        private readonly WebTasksProjectContext _context;

        public Context8Controller(WebTasksProjectContext context)
        {
            _context = context;
        }

        // GET: Context8
        public async Task<IActionResult> Index()
        {
            //Comunicação com a Modal
            ViewBag.mssgC = TempData["mssgC"] as string;
            ViewBag.mssgE = TempData["mssgE"] as string;
            ViewBag.mssgD = TempData["mssgD"] as string;

            return View(await _context.Exec8.ToListAsync());
        }

        // GET: Context8/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exec8 = await _context.Exec8
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exec8 == null)
            {
                return NotFound();
            }

            return View(exec8);
        }

        // GET: Context8/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Context8/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ReceberNome,ReceberEmail,ReceberRG,ResponderAoUser,MostrarAoUser")] Exec8 exec8)
        {
            ModelState.Clear();
            //Criado variáveis para receber os dados do user
            string x, y, z;

            x = exec8.ReceberNome;
            y = exec8.ReceberEmail;
            z = exec8.ReceberRG;

            //Feito uma instancia para criar um arquivo .txt, usando o System.IO
            StreamWriter maquinaDeEscrever = new StreamWriter("Exercicio8.txt");

            //Atribuindo os valores a instancia criada
            maquinaDeEscrever.WriteLine(x);
            maquinaDeEscrever.WriteLine(y);
            maquinaDeEscrever.WriteLine(z);

            //Fechando a instancia, pois se não o fizer, não recebe os dados do user
            maquinaDeEscrever.Close();

            // Retornando um aviso para o user, informando que já foi criado o .txt
            exec8.ResponderAoUser = "Foi criado o arquivo .txt";

            string Leitura = System.IO.File.ReadAllText("..\\WebTasksProject\\Exercicio8.txt");

            exec8.MostrarAoUser = Leitura;

            if (ModelState.IsValid)
            {
                _context.Add(exec8);
                await _context.SaveChangesAsync();

                //Comunicação com a Modal
                TempData["mssgC"] = "Sucesso!";

                return RedirectToAction(nameof(Index));
            }
            return View(exec8);
        }

        // GET: Context8/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exec8 = await _context.Exec8.FindAsync(id);
            if (exec8 == null)
            {
                return NotFound();
            }
            return View(exec8);
        }

        // POST: Context8/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ReceberNome,ReceberEmail,ReceberRG,ResponderAoUser,MostrarAoUser")] Exec8 exec8)
        {
            if (id != exec8.Id)
            {
                return NotFound();
            }

            ModelState.Clear();
            //Criado variáveis para receber os dados do user
            string x, y, z;

            x = exec8.ReceberNome;
            y = exec8.ReceberEmail;
            z = exec8.ReceberRG;

            //Feito uma instancia para criar um arquivo .txt, usando o System.IO
            StreamWriter maquinaDeEscrever = new StreamWriter("Exercicio8.txt");

            //Atribuindo os valores a instancia criada
            maquinaDeEscrever.WriteLine(x);
            maquinaDeEscrever.WriteLine(y);
            maquinaDeEscrever.WriteLine(z);

            //Fechando a instancia, pois se não o fizer, não recebe os dados do user
            maquinaDeEscrever.Close();

            // Retornando um aviso para o user, informando que já foi criado o .txt
            exec8.ResponderAoUser = "Foi criado o arquivo .txt";

            string Leitura = System.IO.File.ReadAllText("..\\WebTasksProject\\Exercicio8.txt");

            exec8.MostrarAoUser = Leitura;


            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exec8);

                    //Comunicação com a Modal
                    TempData["mssgE"] = "Editado!";

                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Exec8Exists(exec8.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(exec8);
        }

        // GET: Context8/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exec8 = await _context.Exec8
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exec8 == null)
            {
                return NotFound();
            }

            return View(exec8);
        }

        // POST: Context8/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exec8 = await _context.Exec8.FindAsync(id);
            _context.Exec8.Remove(exec8);

            //Comunicação com a Modal
            TempData["mssgD"] = "Excluído!";

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Exec8Exists(int id)
        {
            return _context.Exec8.Any(e => e.Id == id);
        }
    }
}
