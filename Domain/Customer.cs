using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
	[Table("Customers")]
	public class Customer : Address
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
		[Column(TypeName = "TinyInt")]
		public DocumentType DocumentType { get; set; }

		[Required]
		public DateTime BirthDate { get; set; }

		[Required]
		[Column(TypeName = "TinyInt")]
		public Sex Sex { get; set; }

		public byte[] Photo { get; set; }
	}
}