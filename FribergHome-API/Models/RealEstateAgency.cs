namespace FribergHome_API.Models
{
    // Christoffer was here
    public class RealEstateAgency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Presentation { get; set; }
        public string LogoUrl { get; set; }

        // Navigation
        public virtual ICollection<RealEstateAgent> Agents { get; set; }
    }
}
