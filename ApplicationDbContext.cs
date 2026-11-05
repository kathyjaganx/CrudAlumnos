using Microsoft.EntityFrameworkCore;
using CrudAlumnos.Models;

namespace CrudAlumnos.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Alumno> Alumnos { get; set; } = null!;
    }
}