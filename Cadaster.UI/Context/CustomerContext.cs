using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Cadaster.UI
{
	public class CustomerContext : DbContext
	{
		#region Properties

		public virtual DbSet<Customer> Customer { get; set; }

		#endregion Properties

		#region Constructor

		public CustomerContext(DbContextOptions<CustomerContext> options)
			: base(options)
		{ }

		#endregion Constructor
	}
}