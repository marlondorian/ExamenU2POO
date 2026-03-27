using ExamenU2POO.Dtos.Common;
using ExamenU2POO.Entities;

namespace ExamenU2POO.Services.Planillas
{
    public interface IPlanillasService
    {
        Task<ResponseDto<List<PlanillaDto>>> GetAllAsync();
    }
}