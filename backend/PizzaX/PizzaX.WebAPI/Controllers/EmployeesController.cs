using Microsoft.AspNetCore.Mvc;
using PizzaX.Application.DTOs.EmployeeDTOs;
using PizzaX.Application.DTOs.EmployeeDTOs.EmployeeUpdateDtos;
using PizzaX.Application.Interfaces.Services;
using PizzaX.Domain.Common;

namespace PizzaX.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService service;

        public EmployeesController(IEmployeeService service)
            => this.service = service;

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery] EmployeeFilterDto dto)
        {
            var result = await service.GetAllAsync(dto);
            return Ok(result);
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var employee = await service.GetByIdAsync(id);
            return employee is null ? NotFound() : Ok(employee);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateEmployeeDto dto)
        {
            try
            {
                var employee = await service.AddAsync(dto);
                return Ok(employee);
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAsync(Guid id)
        {
            var result = await service.RemoveAsync(id);
            return result ? Ok("Employee has been removed successfully") : NotFound();
        }

        [HttpPatch("update/name")]
        public async Task<IActionResult> UpdateNameAsync(EmployeeUpdateNameDto dto)
        {
            try
            {
                var result = await service.UpdateNameAsync(dto);
                return result ? Ok("Name of the employee has been updated successfully.") : NotFound();
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("update/address")]
        public async Task<IActionResult> UpdateAddressAsync(EmployeeUpdateAddressDto dto)
        {
            try
            {
                var result = await service.UpdateAddressAsync(dto);
                return result ? Ok("Address of the employee has been updated successfully.") : NotFound();
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("update/cnic")]
        public async Task<IActionResult> UpdateCNICAsync(EmployeeUpdateCNICDto dto)
        {
            try
            {
                var result = await service.UpdateCNICAsync(dto);
                return result ? Ok("CNIC of the employee has been updated successfully.") : NotFound();
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("update/salary")]
        public async Task<IActionResult> UpdateSalaryAsync(EmployeeUpdateSalaryDto dto)
        {
            try
            {
                var result = await service.UpdateSalaryAsync(dto);
                return result ? Ok("Salary of the employee has been updated successfully.") : NotFound();
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("update/job-role")]
        public async Task<IActionResult> UpdateJobRoleAsync(EmployeeUpdateJobRoleDto dto)
        {
            try
            {
                var result = await service.UpdateJobRoleAsync(dto);
                return result ? Ok("Job role of the employee has been updated successfully.") : NotFound();
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("update/contact")]
        public async Task<IActionResult> UpdateContactAsync(EmployeeUpdateContactDto dto)
        {
            try
            {
                var result = await service.UpdateContactAsync(dto);
                return result ? Ok("Contact of the employee has been updated successfully.") : NotFound();
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPatch("update/mark-leaved")]
        public async Task<IActionResult> MarkLeavedAsync(EmployeeMarkLeftDateDto dto)
        {
            try
            {
                var result = await service.MarkLeftDateAsync(dto);
                return result ? Ok("Left date of the employee has been updated successfully.") : NotFound();
            }
            catch (DomainException e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
