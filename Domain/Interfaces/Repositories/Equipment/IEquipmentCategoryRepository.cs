using Domain.Entities.EquipmentAggregate;

namespace Domain.Interfaces.Repositories.Equipment
{
    public interface IEquipmentCategoryRepository : IRepositoryBase<EquipmentCategoryDb>
    {
		EquipmentCategoryDb GetByEquipmentId(Guid id);

	}
}
