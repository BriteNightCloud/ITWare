using ApplicationCore.DTO.Equipment;
using Domain.Entities.EquipmentAggregate;
using Domain.Interfaces.Repositories.Equipment;

namespace ApplicationCore.Services
{
    public class EquipmentService
    {
        private readonly IEquipmentRepository _equipmentRepository;

		public EquipmentService(IEquipmentRepository equipmentRepository)
		{
			_equipmentRepository = equipmentRepository;
		}

		public IEnumerable<EquipmentDto> GetAll()
        {
            var entities = _equipmentRepository.GetAllAsync().ToBlockingEnumerable();
			return entities.Select(ToDto);
        }

        internal static EquipmentDto ToDto(EquipmentDb equipmentDb)
        {
			var result = new EquipmentDto()
			{
				BarCode = equipmentDb.BarCode,
				Count = equipmentDb.Count,
				Description = equipmentDb.Description,
				Name = equipmentDb.Name,
				NetworkName = equipmentDb.NetworkName,
				SerialNumber = equipmentDb.SerialNumber,
				SNL = equipmentDb.SNL,

			};

			return result;
        }

        internal static EquipmentDb ToDb(EquipmentDto equipmentDto)
        {
			var result = new EquipmentDb()
			{
				BarCode = equipmentDto.BarCode,
				Count = equipmentDto.Count,
				Description = equipmentDto.Description,
				Name = equipmentDto.Name,
				NetworkName = equipmentDto.NetworkName,
				SerialNumber = equipmentDto.SerialNumber,
				SNL = equipmentDto.SNL,

			};

			return result;
		}
    }
}
