using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace Cadaster.UI
{
	public class CustomerContextFactory : IDesignTimeDbContextFactory<CustomerContext>
	{
		public CustomerContext CreateDbContext(string[] args)
		{
			return new CustomerContext(CustomerContextOptions.GetContextOptions());
		}
	}
}