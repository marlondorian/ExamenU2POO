using System.Security.Cryptography.X509Certificates;
using ExamenU2POO.Constants;
using ExamenU2POO.Database;
using ExamenU2POO.Dtos.Common;
using ExamenU2POO.Dtos.Empleados;
using ExamenU2POO.Entities;
using Microsoft.EntityFrameworkCore;


namespace ExamenU2POO.Services.Empleados
{
    public class EmpleadosService : IEmpleadosService
    {
        private readonly PagosDbContext _context;

        public EmpleadosService(PagosDbContext context, IConfiguration configuration)
        {
            _context = context;
        }
        // public async Task<ResponseDto<List<EmpleadoDto>>> GetAllAsync()
        // {
        //     List<EmpleadoDto> dtos = [];
        //     var empleadoEntities = _context.Empleados;

        //     foreach (var empleadoEntity in empleadoEntities)
        //     {
        //         dtos.Add(new EmpleadoDto
        //         {
        //             Id = empleadoEntity.Id,
        //             Nombre = empleadoEntity.Nombre,
        //             Apellido = empleadoEntity.Apellido,
        //             Documento = empleadoEntity.Documento,
        //             FechaContratacion = empleadoEntity.FechaContratacion,
        //             Departamento = empleadoEntity.Departamento,
        //             PuestoTrabajo = empleadoEntity.PuestoTrabajo,
        //             SalarioBase = empleadoEntity.SalarioBase,
        //             Activo = empleadoEntity.Activo
        //         });
        //     return new ResponseDto<EmpleadoDto>
        //     {
        //         StatusCode = HttpStatusCode.OK,
        //         Message = HttpMessageResponse.REGISTER_FOUND,
        //         Status = true,
        //         Data = new ItemsDto<List<EmpleadoDto>>
        //         {Items = dtos},
        //         };
        // }
        // }
        public async Task<ResponseDto<EmpleadoDto>> GetOneByIdAsync(int id)
        {
            var empleadoEntity = await _context.Empleados
                .FirstOrDefaultAsync(p => p.Id == id);

            if(empleadoEntity is null)
            {
                return new ResponseDto<EmpleadoDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Message = HttpMessageResponse.REGISTER_NOT_FOUND,
                    Status = false,                    
                };
            }

            return new ResponseDto<EmpleadoDto>
            {
                StatusCode = HttpStatusCode.OK,
                Message = HttpMessageResponse.REGISTER_FOUND,
                Status = true,
                Data = new EmpleadoDto
                {
                    Id = empleadoEntity.Id,
                    Nombre = empleadoEntity.Nombre,
                    Apellido = empleadoEntity.Apellido,
                    Documento = empleadoEntity.Documento,
                    FechaContratacion = empleadoEntity.FechaContratacion,
                    Departamento = empleadoEntity.Departamento,
                    PuestoTrabajo = empleadoEntity.PuestoTrabajo,
                    SalarioBase = empleadoEntity.SalarioBase,
                    Activo = empleadoEntity.Activo
                }
            };
        }
        public async Task<ResponseDto<ActionResponseDto>> CreateAsync(EmpleadosCreateDto empleadoEntity)
        {
            Empleado empleado = new Empleado {
                    Id = empleadoEntity.Id,
                    Nombre = empleadoEntity.Nombre,
                    Apellido = empleadoEntity.Apellido,
                    Documento = empleadoEntity.Documento,
                    FechaContratacion = empleadoEntity.FechaContratacion,
                    Departamento = empleadoEntity.Departamento,
                    PuestoTrabajo = empleadoEntity.PuestoTrabajo,
                    SalarioBase = empleadoEntity.SalarioBase,
                    Activo = empleadoEntity.Activo
                };
            _context.Empleados.Add(empleado);

            await _context.SaveChangesAsync();

            return new ResponseDto<ActionResponseDto>
            {
                StatusCode = HttpStatusCode.OK,
                Message = HttpMessageResponse.REGISTER_CREATED,
                Status = true,
                Data = new ActionResponseDto
                {
                    Id = empleado.Id
                }
            };
        }
    }
}