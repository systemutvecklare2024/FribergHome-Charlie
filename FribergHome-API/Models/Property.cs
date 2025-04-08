namespace FribergHome_API.Models
{
    // Christoffer was here
    public class Property
    {
        public int Id { get; set; }
        public decimal ListingPrice { get; set; }
        public decimal LivingSpace { get; set; }
        public decimal SecondaryArea { get; set; }
        public decimal LotSize { get; set; }
        public string Description { get; set; }
        public int NumberOfRooms { get; set; } 
        public decimal MonthlyFee { get; set; }
        public decimal OperationalCostPerYear { get; set; }
        public int YearBuilt { get; set; }
        public PropertyType PropertyType { get; set; }

        // Navigation
        public virtual Address Address { get; set; }
        public virtual Muncipality Muncipality { get; set; }
        public virtual RealEstateAgent RealEstateAgent { get; set; }

        public int AddressId { get; set; }
        public int MuncipalityId { get; set; }
        public int RealEstateAgentId { get; set; }
    }
}
