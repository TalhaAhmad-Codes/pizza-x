using PizzaX.Application.DTOs.Common;
using PizzaX.Domain.Enums.BaseProduct;

namespace PizzaX.Application.DTOs.BaseProductDTOs.BaseProductUpdateDtos
{
    // Update image
    public sealed class ProductUpdateImageDto : BaseDto
    {
        // Data field
        public byte[]? Image { get; init; }
    }

    // Update price
    public sealed class ProductUpdatePriceDto : BaseDto
    {
        // Data field
        public decimal Price { get; init; }
    }

    // Update quantity
    public sealed class ProductUpdateStockStatusDto : BaseDto
    {
        // Data field
        public ProductStockStatus StockStatus { get; init; }
    }

    // Update description
    public sealed class ProductUpdateDescriptionDto : BaseDto
    {
        // Data field
        public string? Description { get; init; }
    }
}
