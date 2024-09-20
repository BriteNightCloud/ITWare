using Domain.Entities.EquipmentAggregate;
using Domain.Interfaces.Repositories.Equipment;
using Infrastructure.Data;

namespace Infrastructure.Data.Repositories
{
    public class EquipmentRepository(ITWareDbContext dbContext) : RepositoryBase<EquipmentDb>(dbContext), IEquipmentRepository
    {

    }
}
