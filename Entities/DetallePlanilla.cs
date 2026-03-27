using System.ComponentModel.DataAnnotations;

namespace ExamenU2POO.Entities
{
    public class DetallePlanilla
    {
        [Key]
        public int Id { get; set; }
        public int PlanillaId { get; set; }
        public int EmpleadoId { get; set; }
        public float SalarioBase { get; set; }
        public float HorasExtra { get; set; }
        public float MontoHorasExtra { get; set; }
        public float Bonificaciones { get; set; }
        public float Deducciones { get; set; }
        public float SalarioNeto { get; set; }
        public string Comentarios { get; set; }
        
    }
}