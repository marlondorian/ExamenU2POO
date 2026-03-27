using System.ComponentModel.DataAnnotations;


namespace ExamenU2POO.Entities
{
    public class Planilla
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Periodo { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPago { get; set; }
        public string Estado { get; set; }
    }
}