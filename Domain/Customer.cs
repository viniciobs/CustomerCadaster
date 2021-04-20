using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
	[Table("Customers")]
	public class Customer
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		[MinLength(3), MaxLength(60)]
		public string Name { get; set; }

		[Required]
		[MaxLength(60)]
		public string Email { get; set; }

		[Required]
		[MaxLength(15)]
		public string Phone { get; set; }

		[Required]
		[MaxLength(18)]
		public string Document { get; set; }

		[Required]
		[EnumDataType(typeof(DocumentType))]
		public DocumentType DocumentType { get; set; }

		[Required]
		[DataType(DataType.DateTime)]
		public DateTime BirthDate { get; set; }

		[Required]
		[EnumDataType(typeof(Sex))]
		public Sex Sex { get; set; }

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

		public byte[] Photo { get; set; }
	}
}