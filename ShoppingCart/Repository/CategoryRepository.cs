using ShoppingCart.Models;
using ShoppingCart.UnitOfWork;

namespace ShoppingCart.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(IUnitOfwork unitOfwork) : base(unitOfwork)
        {
        }
    }
}
