using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Cadaster.UI
{
	public static class CustomerContextOptions
	{
		public static DbContextOptions<CustomerContext> GetContextOptions()
		{
			var configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json").Build();
			var optionsBuilder = new DbContextOptionsBuilder<CustomerContext>();

			optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DbConn"]);

			return optionsBuilder.Options;
		}
	}
}