using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class DbContexto : DbContext
    {
        public DbContexto() { }

        public DbContexto(DbContextOptions<DbContexto> options) : base(options)
        {
        }

        public virtual DbSet<Asistente> Asistente { get; set; }
    }

}
