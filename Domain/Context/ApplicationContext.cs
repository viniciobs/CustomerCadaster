using Microsoft.EntityFrameworkCore;

namespace Domain.Context
{
	public class ApplicationContext : DbContext
	{
		#region Properties

		public virtual DbSet<Customer> Customer { get; set; }

		#endregion Properties

		#region Constructor

		public ApplicationContext(DbContextOptions<ApplicationContext> options)
			: base(options)
		{
		}

		#endregion Constructor

		#region Methods

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
		}

		#endregion Methods
	}
}