using ExamenU2POO.Dtos.Common;
using ExamenU2POO.Dtos.Empleados;
using ExamenU2POO.Entities;

namespace ExamenU2POO.Services.Empleados
{
    public interface IEmpleadosService
    {
        // Task<ResponseDto<List<EmpleadoDto>>> GetAllAsync();
        Task<ResponseDto<EmpleadoDto>> GetOneByIdAsync(int id);
        Task<ResponseDto<ActionResponseDto>> CreateAsync(EmpleadosCreateDto dto);
    }
}