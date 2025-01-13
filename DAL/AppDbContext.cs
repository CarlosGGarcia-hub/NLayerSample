using BLL.Models;
using Microsoft.EntityFrameworkCore;
namespace DAL
{
    public class AppDbContext : DbContext
    {


        //para opciones
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //para mapear  es una conexion o un vinculo para fluir datos

       public DbSet<Equipo> Equipos { get; set; }
       public DbSet<Persona> Personas { get; set; }
       public DbSet<Posicion> Posciciones { get; set; }

    }
}
