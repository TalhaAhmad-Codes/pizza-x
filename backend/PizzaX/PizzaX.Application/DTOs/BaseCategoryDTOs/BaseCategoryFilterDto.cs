using PizzaX.Application.DTOs.Common;

namespace PizzaX.Application.DTOs.BaseCategoryDTOs
{
    public sealed class BaseCategoryFilterDto : BaseFilterDto
    {
        public string? Name { get; init; }
    }
}
