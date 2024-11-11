using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ABC_Retail_POE_3.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string UserId { get; set; } = null!;

        [Required(ErrorMessage = "Product Category Is Required!")]
        [StringLength(50, ErrorMessage = "Product Category Cannot Exceed 50 Characters In Length!")]
        [Display(Name = "Product Category")]
        public string ProductCategory { get; set; } = null!;

        [Required(ErrorMessage = "Product Name Is Required!")]
        [StringLength(75, ErrorMessage = "Product Name Cannot Exceed 75 Characters In Length!")]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; } = null!;

        [Required(ErrorMessage = "Product Description Is Required!")]
        [StringLength(150, ErrorMessage = "Product Description Cannot Exceed 150 Characters In Length!")]
        [Display(Name = "Product Description")]
        public string ProductDescription { get; set; } = null!;

        public double ProductPrice { get; set; }
        public string ImageUrl { get; set; } = null!;

        // FK:
        public IdentityUser User { get; set; } = null!;
    }
}
