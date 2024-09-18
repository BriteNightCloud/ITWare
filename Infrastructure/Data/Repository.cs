using ApplicationCore.Entities;
using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;

namespace Infrastructure.Data
{
	public class Repository<T>(ITWareDbContext dbContext)
		: RepositoryBase<T>(dbContext), IRepositoryBase<T>, IReadRepositoryBase<T> where T : BaseEntity
	{
	}
}
