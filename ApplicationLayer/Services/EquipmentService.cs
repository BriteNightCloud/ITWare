using ApplicationLayer.DTO.Equipment;
using Domain.Entities.EquipmentAggregate;
using Domain.Interfaces.Repositories.Equipment;

namespace ApplicationLayer.Services
{
	public class EquipmentService
	{
		private readonly IEquipmentRepository _equipmentRepository;
		private readonly EquipmentCategoryService _equipmentCategoriesService;

		public EquipmentService(IEquipmentRepository equipmentRepository, EquipmentCategoryService equipmentCategoriesService)
		{
			_equipmentRepository = equipmentRepository;
			_equipmentCategoriesService = equipmentCategoriesService;
		}

		public IEnumerable<EquipmentDto> GetAll()
		{
			var equipment = _equipmentRepository.GetAllAsync().ToBlockingEnumerable();
			return equipment.Select(ToDto);
		}

		internal EquipmentDto ToDto(EquipmentDb equipmentDb)
		{
			var result = new EquipmentDto()
			{
				Id = equipmentDb.Id,
				BarCode = equipmentDb.BarCode,
				Count = equipmentDb.Count,
				Description = equipmentDb.Description,
				Name = equipmentDb.Name,
				NetworkName = equipmentDb.NetworkName,
				SerialNumber = equipmentDb.SerialNumber,
				SNL = equipmentDb.SNL,
				Category = _equipmentCategoriesService.GetByEquipmentId(equipmentDb.Id),

			};

			return result;
		}

		internal EquipmentDb ToDb(EquipmentDto equipmentDto)
		{
			var result = new EquipmentDb()
			{
				Id = equipmentDto.Id,
				BarCode = equipmentDto.BarCode,
				Count = equipmentDto.Count,
				Description = equipmentDto.Description,
				Name = equipmentDto.Name,
				NetworkName = equipmentDto.NetworkName,
				SerialNumber = equipmentDto.SerialNumber,
				SNL = equipmentDto.SNL,
				Category = _equipmentCategoriesService.ToDb(equipmentDto.Category),

			};

			return result;
		}
	}
}
