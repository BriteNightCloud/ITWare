using Domain.Entities.LocationAggregate;
using Domain.Interfaces.Repositories.Location;
using Infrastructure.Data;

namespace Infrastructure.Data.Repositories
{
    public class InUseLocationRepository(ITWareDbContext dbContext) : RepositoryBase<InUseLocationDb>(dbContext), IInUseLocationRepository
    {

    }
}
