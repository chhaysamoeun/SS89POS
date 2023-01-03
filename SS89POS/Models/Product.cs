using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SS89POS.Models
{
	public class Product
	{
		[Key]
		public Guid ProductId { get; set; }
		[Required]
		[MaxLength(50)]
		[Display(Name ="Product Name")]
		public string ProductName { get; set; }
		[ForeignKey("Category")]
		public Guid CategoryId { get; set; }
		public double Price { get; set; }
		public string Image { get; set; }
		public int Qty { get; set; }

		public Category Category { get; set; }
	}
}

