using FribergHome_API.Models;

namespace FribergHome_API.Data.Repositories
{
    // Author: Christoffer
    public interface IPropertyRepository : IRepository<Property>
    {
        Task<ICollection<Property>?> FindPropertyInMuncipality(Muncipality muncipality);
    }
}
