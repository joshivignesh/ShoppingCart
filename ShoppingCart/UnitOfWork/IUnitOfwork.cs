using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.UnitOfWork
{
    public interface IUnitOfwork
    {
        DbContext Context { get; }
        public Task SaveChangesAsync();
    }
}
