namespace PizzaX.Application.DTOs.Common
{
    public abstract class PagedResultDto<T>
    {
        // Data fields
        public IReadOnlyList<T> Items { get; init; } = [];
        public int TotalCount { get; init; }
    }
}
