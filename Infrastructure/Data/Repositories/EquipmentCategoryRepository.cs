using Domain.Entities.EquipmentAggregate;
using Domain.Interfaces.Repositories.Equipment;

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
			var result = _db.Equipment.???.Where(x => x.Category.Id == id).Select(x => x.Category).First();
			return result;
		}
	}
}
