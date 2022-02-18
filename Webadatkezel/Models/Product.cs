using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Webadatkezel.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public IdentityUser User { get; set; }

        [Required]
        [StringLength(64)]
        public string Name { get; set; }

        [Required]
        [Range(0, 1_000_000)]
        public int Price { get; set; }

        [StringLength(255)]
        public string Comment { get; set; }

        [Required]
        public DateTime DateOfPurchase { get; set; }

        [Required]
        [Range(1, 10_000)]
        public int Quantity { get; set; }
    }
}
