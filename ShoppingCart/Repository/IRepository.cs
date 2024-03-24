using Microsoft.AspNetCore.Mvc;

namespace ShoppingCart.Repository
{
    public interface IRepository<T> where T : class, IEntity
    {
        public Task<ActionResult<IEnumerable<T>>> Get();
        public Task<ActionResult<T>> Create(T entity);
        public Task<IActionResult> Update(int id, T entity);
        public Task<IActionResult> Delete(int id);
    }
}
