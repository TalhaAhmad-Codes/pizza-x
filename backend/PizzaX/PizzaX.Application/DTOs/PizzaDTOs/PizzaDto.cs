using PizzaX.Application.DTOs.BaseProductDTOs;
using PizzaX.Domain.Enums.Pizza;

namespace PizzaX.Application.DTOs.PizzaDTOs
{
    public sealed class PizzaDto : BaseProductDto
    {
        // Data fields
        public PizzaSize Size { get; init; }
        public Guid VarietyId { get; init; }
    }
}
