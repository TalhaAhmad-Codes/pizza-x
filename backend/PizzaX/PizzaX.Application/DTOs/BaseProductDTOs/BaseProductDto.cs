using PizzaX.Application.DTOs.Common;
using PizzaX.Domain.Enums.BaseProduct;

namespace PizzaX.Application.DTOs.BaseProductDTOs
{
    public abstract class BaseProductDto : BaseAuditableDto
    {
        // Data fields
        public byte[]? Image { get; init; }
        public decimal UnitPrice { get; init; }
        public ProductStockStatus StockStatus { get; init; }
        public string? Description { get; init; }
    }
}
