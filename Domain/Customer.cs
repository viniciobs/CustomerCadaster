using System;

namespace Domain
{
	public class Customer
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }

		public string Document { get; set; }

		public DocumentType DocumentType { get; set; }

		public DateTime BirthDate { get; set; }

		public string PostalCode { get; set; }

		public string City { get; set; }

		public string State { get; set; }

		public string Street { get; set; }

		public string Number { get; set; }

		public string Complement { get; set; }

		public byte[] Photo { get; set; }
	}
}