using System.ComponentModel.DataAnnotations;

namespace CrudAlumnos.Models
{
    public class Alumno
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Carrera { get; set; } = string.Empty;

        public int Edad { get; set; }
    }
}