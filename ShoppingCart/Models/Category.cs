using ShoppingCart.Repository;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class Category : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Product Description")]
        public string Description { get; set; }

    }
}
