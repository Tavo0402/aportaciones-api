using System.ComponentModel.DataAnnotations.Schema;

namespace Aportaciones.Models
{
	public class InputDetails
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public int InputId { get; set; }
		public int StreetId { get; set; }

		[Column(TypeName = "decimal(18,2)")]
		public decimal Ammount { get; set; }
		public DateTime InputDate { get; set; }
		public Input? Input { get; set; }
	}
}
