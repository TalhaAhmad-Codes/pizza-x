using Microsoft.EntityFrameworkCore;
using PizzaX.Application.DTOs.BaseCategoryDTOs;
using PizzaX.Application.DTOs.Common;
using PizzaX.Application.Interfaces.Repositories;
using PizzaX.Domain.Common;
using PizzaX.Infrastructure.Data;

namespace PizzaX.Infrastructure.Repositories
{
    public abstract class BaseCategoryRepository<Category> : GeneralRepository<Category>, IBaseCategoryRepository<Category> where Category : class
    {
        public BaseCategoryRepository(PizzaXDbContext context) : base(context) { }

        public async Task<PagedResultDto<Category>> GetAllAsync(BaseCategoryFilterDto filterDto)
        {
            var query = dbSet.AsQueryable();

            // Applying filters
            if (filterDto.Name != null)
                query = query.Where(c => c.Equals(Function.Simplify(filterDto.Name, true)));

            var totalCount = await query.CountAsync();
            var items = await GetPagedResultItemsAsync(query, filterDto.PageNumber, filterDto.PageSize);

            return new PagedResultDto<Category>
            {
                Items = items,
                TotalCount = totalCount
            };
        }
    }
}
