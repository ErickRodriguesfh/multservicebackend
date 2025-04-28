
namespace MultService.Domain.Entities
{
    public class Specialty
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Provider> Providers { get; set; } = [];
    }
}
