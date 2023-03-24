namespace Aportaciones.Dtos
{
	public class InputDto
	{
        public int Id { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
