using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Parcial.Models;

namespace Parcial.Data
{
    public class ParcialContext : DbContext
    {
        public ParcialContext (DbContextOptions<ParcialContext> options)
            : base(options)
        {
        }

        public DbSet<Parcial.Models.Alumno> Alumno { get; set; }
    }
}
