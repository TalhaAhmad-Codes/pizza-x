using PizzaX.Application.DTOs.BaseProductDTOs;

namespace PizzaX.Application.DTOs.ProductDTOs
{
    public sealed class CreateProductDto : BaseCreateProductDto
    {
        public string Name { get; init; }
        public Guid CategoryId { get; init; }
    }
}
