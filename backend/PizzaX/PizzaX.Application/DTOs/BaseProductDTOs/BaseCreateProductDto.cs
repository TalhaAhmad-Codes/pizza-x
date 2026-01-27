using PizzaX.Domain.Enums.BaseProduct;

namespace PizzaX.Application.DTOs.BaseProductDTOs
{
    public abstract class BaseCreateProductDto
    {
        public byte[]? Image { get; init; }
        public decimal UnitPrice { get; init; }
        public ProductStockStatus StockStatus { get; init; } = ProductStockStatus.InStock;
        public string? Description { get; init; }
    }
}
