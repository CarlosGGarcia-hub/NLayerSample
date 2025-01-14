using BLL.Models;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class AppDbContext : DbContext
    {


        //para opciones
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //para mapear  es una conexion o un vinculo para fluir datos

       public DbSet<Equipo> Equipo { get; set; }
       public DbSet<Persona> Persona { get; set; }
       public DbSet<Posicion> Posicion { get; set; }

    }
}
