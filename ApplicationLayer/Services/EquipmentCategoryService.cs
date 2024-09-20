using ApplicationLayer.DTO.Equipment;
using Domain.Entities.EquipmentAggregate;
using Domain.Interfaces.Repositories.Equipment;

namespace ApplicationLayer.Services
{
	public class EquipmentCategoryService
	{
		private readonly IEquipmentCategoryRepository _equipmentCategoryRepository;

		public EquipmentCategoryService(IEquipmentCategoryRepository equipmentCategoryRepository)
		{
			_equipmentCategoryRepository = equipmentCategoryRepository;
		}

		public IEnumerable<EquipmentCategoryDto> GetAll()
		{
			var equipmentCategory = _equipmentCategoryRepository.GetAllAsync().ToBlockingEnumerable();
			return equipmentCategory.Select(ToDto);
		}

		public EquipmentCategoryDto GetByEquipmentId(Guid id)
		{				
			var result = ToDto(_equipmentCategoryRepository.GetByEquipmentId(id));
			return result;
		}

		internal EquipmentCategoryDto ToDto(EquipmentCategoryDb equipmentCategoryDb)
		{
			var result = new EquipmentCategoryDto()
			{
				Id = equipmentCategoryDb.Id,
				Description = equipmentCategoryDb.Description,
				Name = equipmentCategoryDb.Name
			};
			return result;
		}

		internal EquipmentCategoryDb ToDb(EquipmentCategoryDto equipmentCategoryDto)
		{
			var result = new EquipmentCategoryDb()
			{
				Id = equipmentCategoryDto.Id,
				Description = equipmentCategoryDto.Description,
				Name = equipmentCategoryDto.Name
			};
			return result;
		}
	}
}
