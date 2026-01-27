using PizzaX.Application.DTOs.Common;

namespace PizzaX.Application.DTOs.BaseCategoryDTOs
{
    public sealed class BaseCategoryDto : BaseAuditableDto
    {
        public string Name { get; init; }
    }
}
