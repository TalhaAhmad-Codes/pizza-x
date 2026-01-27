using PizzaX.Application.DTOs.ProductDTOs;
using PizzaX.Domain.Common;
using PizzaX.Domain.Entities;

namespace PizzaX.Application.Mappers
{
    public static class ProductMapper
    {
        public static ProductDto ToDto(Product product)
            => new() 
            {
                Id = product.Id,
                CategoryId = product.CategoryId,
                Name = Function.ToCapitalize(product.Name),
                Image = product.Image,
                UnitPrice = product.Price.UnitPrice,
                Description = product.Description,
                StockStatus = product.StockStatus,
                CreatedAt = product.CreatedAt,
                UpdatedAt = product.UpdatedAt
            };
    }
}
