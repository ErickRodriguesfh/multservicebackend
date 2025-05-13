

using AutoMapper;
using MultService.Application.Communication.Response.SpecialtyDTOs;
using MultService.Application.UseCases.Specialty;
using MultService.Domain.RepositoryInterface;

namespace MultService.Application.UseCasesImplementation
{
    public class SpecialtiesUseCase : ISpecialtyUseCase
    {
        private readonly ISpecialtyRepository _specialityRepository;
        private readonly IMapper _mapper;

        public SpecialtiesUseCase(ISpecialtyRepository specialityRepository, IMapper mapper)
        {
            this._specialityRepository = specialityRepository;
            this._mapper = mapper;
        }

        public async Task<IEnumerable<SpecialtyResponseDTO>> getSpecialtiesAsync()
        {
            var specialties = await _specialityRepository.GetSpecialtiesAsync();
            return _mapper.Map<List<SpecialtyResponseDTO>>(specialties);
        }
    }
}
