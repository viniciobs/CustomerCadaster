using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace Cadaster.UI.Context
{
	public class CustomerContextFactory : IDesignTimeDbContextFactory<CustomerContext>
	{
		public CustomerContext CreateDbContext(string[] args)
		{
			var configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
			var optionsBuilder = new DbContextOptionsBuilder<CustomerContext>();

			optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DbConn"]);

			return new CustomerContext(optionsBuilder.Options);
		}
	}
}