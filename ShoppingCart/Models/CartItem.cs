using ShoppingCart.Repository;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class CartItem : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int ItemId { get; set; }

        public int CartId { get; set; }

        public int Quantity { get; set; }

        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
