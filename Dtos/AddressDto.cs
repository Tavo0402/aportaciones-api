namespace Aportaciones.Dtos
{
	public class AddressDto
	{
		public int Id { get; set; }
		public string Street { get; set; } = string.Empty;
		public int Number { get; set; }
		public string Email { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
    }
}
