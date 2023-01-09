using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SS89POS.Models
{
	public class SaleDetail
	{
		[Key]
		public Guid SaleDetailId { get; set; }
		[ForeignKey("Sale")]
		public Guid SaleId { get; set; }
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
		public int Qty { get; set; }
		public decimal Price { get; set; }
		public decimal Amount { get; set; }

		public Sale Sale { get; set; }
		public Product Product { get; set; }
	}
}

