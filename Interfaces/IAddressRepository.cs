using Aportaciones.Dtos;

namespace Aportaciones.Interfaces
{
	public interface IAddressRepository
	{
		Task<AddressDto> GetAddressDetails(int id);
		Task<List<AddressDto>> GetAllAddresses();
	}
}
