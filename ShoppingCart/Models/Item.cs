using ShoppingCart.Repository;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Item : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
