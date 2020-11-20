using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITData.Prueba.WebApi.Models
{
    public partial class ApiContext : DbContext
    {


        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }

        public virtual DbSet<Empleado> Empleado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-RQ6KTQS\SQLEXPRESS;Database=BDPRUEBA;Integrated Security=True;");
            }
        }

    }
}
