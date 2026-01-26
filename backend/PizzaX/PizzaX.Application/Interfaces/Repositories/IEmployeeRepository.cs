using PizzaX.Application.DTOs.Common;
using PizzaX.Application.DTOs.EmployeeDTOs;
using PizzaX.Domain.Entities;

namespace PizzaX.Application.Interfaces.Repositories
{
    public interface IEmployeeRepository : IGeneralRepository<Employee>
    {
        Task<bool> IsEligibleAsync(Guid userId);
        Task<PagedResultDto<Employee>> GetAllAsync(EmployeeFilterDto filterDto);
    }
}
