using PizzaX.Application.DTOs.BaseCategoryDTOs;
using PizzaX.Application.DTOs.Common;

namespace PizzaX.Application.Interfaces.Repositories
{
    public interface IBaseCategoryRepository<Category> : IGeneralRepository<Category> where Category : class
    {
        Task<PagedResultDto<Category>> GetAllAsync(BaseCategoryFilterDto filterDto);
    }
}
