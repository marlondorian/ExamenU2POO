using ExamenU2POO.Dtos.Empleados;
using ExamenU2POO.Services.Empleados;
using Microsoft.AspNetCore.Mvc;

namespace ExamenU2POO.Controllers
{
    [Route("/api/empleados")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly IEmpleadosService _empleadoService;

        public EmpleadosController(IEmpleadosService empleadosService)
        {
            _empleadoService = empleadosService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _empleadoService.GetAllAsync();
            return StatusCode(response.StatusCode, response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetOne(int id)
        {
            var result = await _empleadoService.GetOneByIdAsync(id);
            return StatusCode(result.StatusCode, result);
        }

        [HttpPost]
        public async Task<ActionResult> Create(EmpleadosCreateDto dto)
        {
            var result = await _empleadoService.CreateAsync(dto);
            return StatusCode(result.StatusCode, result);
        }

    }
}