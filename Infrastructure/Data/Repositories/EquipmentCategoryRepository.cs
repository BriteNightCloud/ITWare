using Domain.Entities.EquipmentAggregate;
using Domain.Interfaces.Repositories.Equipment;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repositories
{
	public class EquipmentCategoryRepository : RepositoryBase<EquipmentCategoryDb>, IEquipmentCategoryRepository
	{
		private readonly ITWareDbContext _db;
        public EquipmentCategoryRepository(ITWareDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public EquipmentCategoryDb GetByEquipmentId(Guid id)
		{
			var result = _db.Equipment.Include(x => x.Category).Where(x => x.Id.ToString().Equals(id.ToString())).Select(x => x.Category);
			return result.First();
		}
	}
}
