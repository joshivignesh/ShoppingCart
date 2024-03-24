using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required, StringLength(15), Display(Name = "Name")]
        public string Name { get; set; }

        [Required, StringLength(1000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal UnitPrice { get; set; } = 0;

        [Column(TypeName = "decimal(18, 2)")]
        public decimal PriceTotal { get; set;} = 0;
        public int CategoryId { get; set; }
        public string Image { get; set; }
        public ICollection<ProductCategory> PostCategories { get; set; } = new HashSet<ProductCategory>();
        public ApplicationUser User { get; set; }
    }
}
