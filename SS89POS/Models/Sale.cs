using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SS89POS.Models
{
	public class Sale
	{
		[Key]
		public Guid SaleId { get; set; }
		[ForeignKey("Customer")]
		[Display(Name ="Customer")]
		public Guid CustomerId { get; set; }
		[DataType(DataType.Date)]
        [Display(Name = "Issue Date")]
        public DateTime IssueDate { get; set; }
		[MaxLength(20)]
		public string InvoiceNumber { get; set; }
		public decimal Total { get; set; }
		public int Discount { get; set; }
        [Display(Name = "Grand Total")]
        public decimal GrandTotal { get; set; }

		public Customer Customer { get; set; }
		public List<SaleDetail> SaleDetails { get; set; }
	}
}

