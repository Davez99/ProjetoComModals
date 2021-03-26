using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebTasksProject.Areas.Identity.Data;

namespace WebTasksProject.Data
{
    public class WebTasksProjectContext : IdentityDbContext<WebTasksProjectUser>
    {
        public WebTasksProjectContext(DbContextOptions<WebTasksProjectContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<WebTasksProject.Models.Exec1> Exec1 { get; set; }
        public DbSet<WebTasksProject.Models.Exec2> Exec2 { get; set; }
        public DbSet<WebTasksProject.Models.Exec3> Exec3 { get; set; }
        public DbSet<WebTasksProject.Models.Exec4> Exec4 { get; set; }
        public DbSet<WebTasksProject.Models.Exec5> Exec5 { get; set; }
        public DbSet<WebTasksProject.Models.Exec6> Exec6 { get; set; }
        public DbSet<WebTasksProject.Models.Exec7> Exec7 { get; set; }
        public DbSet<WebTasksProject.Models.Exec8> Exec8 { get; set; }
        public DbSet<WebTasksProject.Models.Exec9> Exec9 { get; set; }
    }
}
