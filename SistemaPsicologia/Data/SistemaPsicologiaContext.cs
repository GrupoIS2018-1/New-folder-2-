using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SistemaPsicologia.Models
{
    public class SistemaPsicologiaContext : DbContext
    {
        public SistemaPsicologiaContext (DbContextOptions<SistemaPsicologiaContext> options)
            : base(options)
        {
        }

        public DbSet<SistemaPsicologia.Models.RegistrarPsicologo> RegistrarPsicologo { get; set; }
    }
}
