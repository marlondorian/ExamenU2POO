using ExamenU2POO.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenU2POO.Database
{
    public class PagosDbContext : DbContext
    {
       
    
        public PagosDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }

    }
}