using Aportaciones.Models;

namespace Aportaciones.Dtos
{
	public class InputDetailsDto
	{
		public int InputId { get; set; }
		public int StreetId { get; set; }
		public decimal Ammount { get; set; }
		public string InputDate { get; set; } = string.Empty;
	}
}
