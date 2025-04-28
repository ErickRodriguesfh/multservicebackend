using MultService.Application.Communication.Response.SpecialtyDTOs;

namespace MultService.Application.Communication.Response.ProviderDTOs
{
    public class ProviderResponseDTO
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public List<SpecialtyResponseDTO> Specialties { get; set; } = new();

    }
}
