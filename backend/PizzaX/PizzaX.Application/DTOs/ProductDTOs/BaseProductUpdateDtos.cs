namespace PizzaX.Application.DTOs.ProductDTOs.BaseProductUpdateDtos
{
    // Update image
    public abstract class BaseProductUpdateImageDto
    {
        // Data field
        public byte[]? Image { get; init; }
    }

    // Update price
    public abstract class BaseProductUpdatePriceDto
    {
        // Data field
        public decimal Price { get; init; }
    }

    // Update quantity
    public abstract class BaseProductUpdateQuantityDto
    {
        // Data field
        public int Quantity { get; init; }
    }

    // Update description
    public abstract class BaseProductUpdateDescriptionDto
    {
        // Data field
        public string? Description { get; init; }
    }
}
