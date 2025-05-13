using MultService.Application.UseCases.Specialty;
using MultService.Application.UseCasesImplementation;

namespace MultService.API.Configuration
{
    public class ApplicationServiceInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ISpecialtyUseCase, SpecialtiesUseCase>();
        }
    }
}
