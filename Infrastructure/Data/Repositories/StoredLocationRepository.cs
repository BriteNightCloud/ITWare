using Domain.Entities.LocationAggregate;
using Domain.Interfaces.Repositories.Location;

namespace Infrastructure.Data.Repositories
{
    public class StoredLocationRepository(ITWareDbContext dbContext) : RepositoryBase<StoredLocationDb>(dbContext), IStoredLocationRepository
    {
    }
}
