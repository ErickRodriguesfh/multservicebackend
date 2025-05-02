
using AutoMapper;
using MultService.Application.Communication.Response.SpecialtyDTOs;
using MultService.Domain.Entities;

namespace MultService.Application.Configuration
{
    public class AutoMapping : Profile
    {

        public AutoMapping()
        {
            DomainToRequest();
        }

        private void DomainToRequest()
        {
            CreateMap<Specialty, SpecialtyResponseDTO>();
        }
    }
}
