
using Microsoft.AspNetCore.Mvc;
using MultService.Application.Communication.Response.SpecialtyDTOs;
using MultService.Application.UseCases.Specialty;

namespace MultService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtiesController : ControllerBase
    {

        private readonly ISpecialtyUseCase _specialtyUseCase;

        public SpecialtiesController(ISpecialtyUseCase specialtyUseCase)
        {
            _specialtyUseCase = specialtyUseCase;
        }

        [HttpGet]
        [ProducesResponseType(typeof(SpecialtyResponseDTO), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSpecialties()
        {
            var specialties = await _specialtyUseCase.getSpecialtiesAsync();
            return Ok(specialties);
        }
    }
}
