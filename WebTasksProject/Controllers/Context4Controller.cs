using System;
using System.Collections.Generic;
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
    public class Context4Controller : Controller
    {
        private readonly WebTasksProjectContext _context;

        public Context4Controller(WebTasksProjectContext context)
        {
            _context = context;
        }

        // GET: Context
        public async Task<IActionResult> Index()
        {
            return View(await _context.Exec4.ToListAsync());
        }

        // GET: Context/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exec4 = await _context.Exec4
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exec4 == null)
            {
                return NotFound();
            }

            return View(exec4);
        }

        // GET: Context/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Context/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,IdadeEntrada,IdadeSaida")] Exec4 exec4)
        {
            ModelState.Clear();

            var x = exec4.IdadeEntrada;


            if (x >= 18)
            {
                ViewBag._concedido = "Concedido";
                exec4.IdadeSaida = "Permissão concedida!";
            }
            else
            {
                ViewBag._concedido = "Denegrido";
                exec4.IdadeSaida = "Permissão negada!";
            }

            if (ModelState.IsValid)
            {
                _context.Add(exec4);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(exec4);
        }

        // GET: Context/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exec4 = await _context.Exec4.FindAsync(id);
            if (exec4 == null)
            {
                return NotFound();
            }
            return View(exec4);
        }

        // POST: Context/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,IdadeEntrada,IdadeSaida")] Exec4 exec4)
        {
            if (id != exec4.Id)
            {
                return NotFound();
            }

            ModelState.Clear();

            var x = exec4.IdadeEntrada;


            if (x >= 18)
            {
                ViewBag._concedido = "Concedido";
                exec4.IdadeSaida = "Permissão concedida!";
            }
            else
            {
                ViewBag._concedido = "Denegrido";
                exec4.IdadeSaida = "Permissão negada!";
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exec4);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Exec4Exists(exec4.Id))
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
            return View(exec4);
        }

        // GET: Context/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exec4 = await _context.Exec4
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exec4 == null)
            {
                return NotFound();
            }

            return View(exec4);
        }

        // POST: Context/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var exec4 = await _context.Exec4.FindAsync(id);
            _context.Exec4.Remove(exec4);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Exec4Exists(int id)
        {
            return _context.Exec4.Any(e => e.Id == id);
        }
    }
}
