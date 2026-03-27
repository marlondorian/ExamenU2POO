using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenU2POO.Dtos.Empleados
{
    public class EmpleadosCreateDto
    {
        public int Id { get; set; }
        [Display(Name = "Nombres")]
        [Required(ErrorMessage = "Los {0} son requeridos.")]
        [StringLength(40, ErrorMessage = "Los {0} deben tener un mínimo de {2} y máximo de {1} caracteres.", MinimumLength = 3)]
        public string Nombre { get; set; }
        [Display(Name = "Apellidos")]
        [Required(ErrorMessage = "Los {0} son requeridos.")]
        [StringLength(40, ErrorMessage = "Los {0} deben tener un mínimo de {2} y máximo de {1} caracteres.", MinimumLength = 3)]
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public string Departamento { get; set; }
        public string PuestoTrabajo { get; set; }
        public float SalarioBase { get; set; }
        public bool Activo { get; set; }
        
    }
}