using Actividad_Unidad_1.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Actividad_Unidad_1.Utilidades
{
    public class ApplicationDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-53D34O7\\SQLEXPRESS;Database=ActU1Db;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}
