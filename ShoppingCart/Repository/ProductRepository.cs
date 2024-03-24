using ShoppingCart.Models;
using ShoppingCart.UnitOfWork;

namespace ShoppingCart.Repository
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IUnitOfwork unitOfwork) : base(unitOfwork)
        {
        }
    }
}
