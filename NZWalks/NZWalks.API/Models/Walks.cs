namespace NZWalks.API.Models
{
    public class Walks
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthLnKm { get; set; }
        public string? WalkImageUrl { get; set; }
        public Guid RegionId { get; set; }
        public Guid DifficultyId { get; set; }

        public Regions Region { get; set; }
        public Difficulty Difficulty { get; set; }
    }
}
