
namespace MultService.Domain.Entities
{
    public class Provider
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public List<Specialty> Specialties { get; set; } = [];
    }
}
