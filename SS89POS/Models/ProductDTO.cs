using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SS89POS.Models
{
	public class ProductDTO
	{
        [Key]
        public Guid ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }
        public double Price { get; set; }
        public IFormFile Image { get; set; }
        public int Qty { get; set; }
        [Required]
        [MaxLength(20)]
        public string Barcode { get; set; }

        public Category Category { get; set; }
    }
}

