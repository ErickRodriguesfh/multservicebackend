
using MultService.Application.Communication.Response.SpecialtyDTOs;

namespace MultService.Application.UseCases.Specialty
{
    public interface ISpecialtyUseCase
    {
        Task<IEnumerable<SpecialtyResponseDTO>> getSpecialtiesAsync();
    }
}
