using Domain;
using Microsoft.EntityFrameworkCore;

namespace Cadaster.UI
{
	public class CustomerContext : DbContext
	{
		#region Properties

		public virtual DbSet<Customer> Customer { get; set; }

		#endregion Properties

		#region Constructors

		public CustomerContext(DbContextOptions<CustomerContext> options)
			: base(options)
		{ }

		public CustomerContext()
			: base(CustomerContextOptions.GetContextOptions())
		{
		}

		#endregion Constructors
	}
}