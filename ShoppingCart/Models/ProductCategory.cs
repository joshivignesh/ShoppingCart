using ShoppingCart.Repository;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class ProductCategory : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
