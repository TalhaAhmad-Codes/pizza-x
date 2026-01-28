using PizzaX.Domain.Common;
using PizzaX.Domain.Enums.BaseProduct;

namespace PizzaX.Domain.Entities
{
    public sealed class Product : BaseProduct
    {
        // Attributes
        public string Name { get; private set; }
        public Guid CategoryId { get; private set; }

        // Navigation
        public ProductCategory Category { get; private set; }

        // Constructors
        private Product() : base() { }

        private Product(byte[]? image, decimal unitPrice, string? description, string name, Guid categoryId, ProductStockStatus stockStatus) : base(image, unitPrice, description, stockStatus)
        {
            Guard.AgainstNullOrWhitespace(name, nameof(Name));
            Guard.AgainstInvalidRegexPattern(RegexPattern.CategoryName, name, nameof(name));

            Name = Function.Simplify(name, true)!;
        }

        // Method - Create a new object
        public static Product Create(byte[]? image, decimal unitPrice, string? description, string name, Guid categoryId, ProductStockStatus stockStatus)
            => new(image, unitPrice, description, name, categoryId, stockStatus);

        /*******************************/
        /* Methods - Update properties */
        /*******************************/

        public void UpdateName(string name)
        {
            Guard.AgainstNullOrWhitespace(name, nameof(Name));

            Name = Function.Simplify(name, true)!;
            MarkUpdated();
        }
    }
}
