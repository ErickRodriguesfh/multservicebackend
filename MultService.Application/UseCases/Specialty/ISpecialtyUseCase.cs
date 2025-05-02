
using MultService.Application.Communication.Response.SpecialtyDTOs;

namespace MultService.Application.UseCases.Specialty
{
    public interface ISpecialtyUseCase
    {
        Task<List<SpecialtyResponseDTO>> getSpecialtiesAsync();
    }
}
