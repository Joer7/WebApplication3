using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> users { get; set; }
        public DbSet<Libro> libros { get; set; }
        public DbSet<Pago> pagos { get; set; }
        public DbSet<Pedido> pedidos { get; set; }
        public DbSet<Producto> productos { get; set; }

    }
}
