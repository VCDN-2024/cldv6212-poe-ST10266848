using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ABC_Retail_POE_3.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime Date { get; set; }
        public DateTime ModifiedDate { get; set; }

        [Required(ErrorMessage = "Credit Card Name Is Required!")]
        [StringLength(30, ErrorMessage = "Credit Card Name Cannot Exceed 30 Characters In Length!")]
        [Display(Name = "Bank Name")]
        public string CreditCardName { get; set; } = null!;

        [Required(ErrorMessage = "Credit Card Number Is Required!")]
        [StringLength(19, ErrorMessage = "Credit Card Number Cannot Exceed 19 Digits In Length!")]
        [Display(Name = "Credit Card Number")]
        public string CreditCardNumber { get; set; } = null!;

        [Required(ErrorMessage = "Credit Card CCV Code Is Required!")]
        [StringLength(4, ErrorMessage = "Credit Card CCV Code Cannot Exceed 4 Digits In Length!")]
        [Display(Name = "Credit Card CCV Code")]
        public string CreditCardCCVcode { get; set; } = null!;

        [Required(ErrorMessage = "Shipping Address Is Required!")]
        [StringLength(150, ErrorMessage = "Shipping Address Cannot Exceed 150 Characters In Length!")]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; } = null!;

        // FK:
        public Product? Product { get; set; } = null!;
        public IdentityUser User { get; set; } = null!;
    }
}
