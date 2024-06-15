using Microsoft.EntityFrameworkCore;
using Practica3.Models;

namespace Practica3.Context
{
    public partial class Editor: DbContext
    {
        public Editor() { }
        public Editor(DbContextOptions<Editor>options)
            : base(options){ }
        public DbSet<Editorial>Editorial { get; set; }  
        public DbSet<Inventario>Inventario { get; set; }

        public DbSet<Libro>Libro { get; set; }
        public DbSet<Sucursal>Sucursal { get; set; } 

    }
}
