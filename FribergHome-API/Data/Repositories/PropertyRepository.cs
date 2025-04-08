using FribergHome_API.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergHome_API.Data.Repositories
{
    // Author: Christoffer
    public class PropertyRepository : GenericRepository<Property, ApplicationDbContext>, IPropertyRepository
    {
        public PropertyRepository(ApplicationDbContext dbContext) : base(dbContext) {}

        public async Task<ICollection<Property>?> FindPropertyInMuncipality(Muncipality muncipality)
        {
            return await DbContext
                .Properties
                .Where(e => e.Muncipality == muncipality)
                .ToListAsync();
        }
    }
}
