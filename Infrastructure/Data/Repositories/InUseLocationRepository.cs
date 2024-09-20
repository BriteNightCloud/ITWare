using Domain.Entities.LocationAggregate;
using Domain.Interfaces.Repositories.Location;

namespace Infrastructure.Data.Repositories
{
    public class InUseLocationRepository(ITWareDbContext dbContext) : RepositoryBase<InUseLocationDb>(dbContext), IInUseLocationRepository
    {

    }
}
