
namespace MultService.Domain.Entities
{
    public class Contractor
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ContactNumber { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public Address? Address { get; set; }

    }
}
