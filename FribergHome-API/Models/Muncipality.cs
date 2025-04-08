namespace FribergHome_API.Models
{
    // Christoffer was here
    public class Muncipality
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation
        public virtual ICollection<Property> PropertiesIn { get; set; }
    }
}
