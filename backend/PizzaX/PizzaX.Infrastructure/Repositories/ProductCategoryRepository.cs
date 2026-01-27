using PizzaX.Application.Interfaces.Repositories;
using PizzaX.Domain.Entities;
using PizzaX.Infrastructure.Data;

namespace PizzaX.Infrastructure.Repositories
{
    public sealed class ProductCategoryRepository : BaseCategoryRepository<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(PizzaXDbContext context) : base(context) { } 
    }
}
