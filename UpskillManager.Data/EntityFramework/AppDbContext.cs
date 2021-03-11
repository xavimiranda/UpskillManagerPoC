using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpskillManager.Data.Models;

namespace UpskillManager.Data
{
    public class AppDbContext : IdentityDbContext
    {

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        

        public AppDbContext(DbContextOptions options) : base(options) { }
    }
}
