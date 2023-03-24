using Aportaciones.Dtos;

namespace Aportaciones.Interfaces
{
	public interface IInputRepository
	{
		Task<InputDto> GetCurrentInput();
		Task<InputDetailsDto> SaveInputDetails(InputDetailsDto details);
	}
}
