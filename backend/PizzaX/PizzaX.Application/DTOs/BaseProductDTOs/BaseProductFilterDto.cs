using PizzaX.Application.DTOs.Common;
using PizzaX.Domain.Enums.BaseProduct;

namespace PizzaX.Application.DTOs.BaseProductDTOs
{
    public abstract class BaseProductFilterDto : BaseFilterDto
    {
        // Data fields
        public decimal? MinPrice { get; init; }
        public decimal? MaxPrice { get; init; }
        public int? MinQuantity { get; init; }
        public int? MaxQuantity { get; init; }
        public ProductStockStatus? StockStatus { get; init; }
    }
}
