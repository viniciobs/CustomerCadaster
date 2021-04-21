using System.ComponentModel.DataAnnotations;

namespace Domain
{
	public class Address
	{
		[Required]
		[MinLength(8), MaxLength(9)]
		public string PostalCode { get; set; }

		[Required]
		public string City { get; set; }

		[Required]
		[StringLength(2)]
		public string State { get; set; }

		[Required]
		public string Street { get; set; }

		[Required]
		public string Burgh { get; set; }

		[Required]
		public string Number { get; set; }

		public string Complement { get; set; }
	}
}