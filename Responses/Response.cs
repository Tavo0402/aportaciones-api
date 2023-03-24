namespace Aportaciones.Responses
{
	public class Response
	{
		public string Message { get; set; } = string.Empty;
        public object? Results { get; set; }
		public List<string>? Errors { get; set; }
    }
}
