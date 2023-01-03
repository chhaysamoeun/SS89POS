using System;
using Microsoft.EntityFrameworkCore;
using SS89POS.Models;

namespace SS89POS.Data
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			:base(options)
		{
		}
		public DbSet<Category> Category { get; set; }
		public DbSet<Customer> Customer { get; set; }
		public DbSet<Product> Product { get; set; }
	}
}

