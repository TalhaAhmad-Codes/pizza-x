using PizzaX.Application.DTOs.BaseProductDTOs.BaseProductUpdateDtos;

namespace PizzaX.Application.Interfaces.Services
{
    public interface IBaseProductUpdateService
    {
        Task<bool> UpdateImageAsync(ProductUpdateImageDto dto);
        Task<bool> UpdatePriceAsync(ProductUpdatePriceDto dto);
        Task<bool> UpdateStockStatusAsync(ProductUpdateStockStatusDto dto);
        Task<bool> UpdateDescriptionAsync(ProductUpdateDescriptionDto dto);
    }
}
