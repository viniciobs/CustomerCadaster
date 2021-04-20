using Microsoft.EntityFrameworkCore;

namespace Domain.Context
{
	public class CustomerContext : DbContext
	{
		#region Properties

		public virtual DbSet<Customer> Customer { get; set; }

		#endregion Properties

		#region Constructor

		public CustomerContext(DbContextOptions<CustomerContext> options)
			: base(options)
		{
		}

		#endregion Constructor

		#region Methods

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(CustomerContext).Assembly);
		}

		#endregion Methods
	}
}