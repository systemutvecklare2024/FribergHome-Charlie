namespace FribergHome_API.Data.Seeding
{
    public class SeedData
    {
        // Author: Christoffer
        public static async Task SeedAsync(ApplicationDbContext ctx)
        {
            // Order matters!
            if(!ctx.Agencies.Any())
            {
                await SeedAgencies(ctx);
            }
        }

        // Author: Christoffer
        public static async Task SeedAgencies(ApplicationDbContext ctx)
        {
            ctx.Agencies.Add(new Models.RealEstateAgency
            {
                Name = "BengtRealtorzAB",
                Presentation = "Vi säljer osv",
                LogoUrl = "https://picsum.photos/seed/property1/800/600",
                Agents = new[] {
                    new Models.RealEstateAgent {
                        FirstName = "Bengt",
                        LastName = "Bengtzon",
                        Email = "Bengan@BengtRealtzorzAB.se",
                        PhoneNumber = "112",
                        ImageUrl = "https://randomuser.me/api/portraits/men/8.jpg"
                    },
                    new Models.RealEstateAgent {
                        FirstName = "Berit",
                        LastName = "Bengtzon",
                        Email = "Brittan@BengtRealtzorzAB.se",
                        PhoneNumber = "112",
                        ImageUrl = "https://randomuser.me/api/portraits/women/7.jpg"
                    },
                }
            });
            await ctx.SaveChangesAsync();
        }
    }
}