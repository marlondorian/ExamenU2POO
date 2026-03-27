using System.ComponentModel.DataAnnotations;

namespace ExamenU2POO.Entities
{
    public class Empleado
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Documento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Departamento { get; set; }
        public string PuestoTrabajo { get; set; }
        public float SalarioBase { get; set; }
        public bool Activo { get; set; }

    }
}