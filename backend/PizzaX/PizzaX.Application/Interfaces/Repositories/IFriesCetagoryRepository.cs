using PizzaX.Application.DTOs.Common;
using PizzaX.Application.DTOs.FriesCetagoryDTOs;
using PizzaX.Domain.Entities;

namespace PizzaX.Application.Interfaces.Repositories
{
    public interface IFriesCetagoryRepository : IGeneralRepository<FriesCategory>
    {
        Task<PagedResultDto<FriesCategory>> GetAllAsync(FriesCetagoryFilterDto filterDto);
    }
}
