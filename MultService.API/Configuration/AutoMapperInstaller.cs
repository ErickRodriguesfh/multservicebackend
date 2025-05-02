using MultService.Application.Configuration;

namespace MultService.API.Configuration
{
    public interface AutoMapperInstaller : IServiceInstaller
    {
        public void Install(IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped(option => new AutoMapper.MapperConfiguration(options =>
            {
                options.AddProfile(new AutoMapping());
            }).CreateMapper());
        }
    }
}
