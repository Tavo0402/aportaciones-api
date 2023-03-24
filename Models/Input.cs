using System.ComponentModel.DataAnnotations.Schema;

namespace Aportaciones.Models
{
	public class Input
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }

        public List<InputDetails>? Details { get; set; }	
    }
}
