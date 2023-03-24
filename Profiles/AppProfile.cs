using Aportaciones.Dtos;
using Aportaciones.Models;
using AutoMapper;

namespace Aportaciones.Profiles
{
	public class AppProfile : Profile
	{
        public AppProfile()
        {
			CreateMap<InputDetailsDto, InputDetails>().ReverseMap();
			CreateMap<InputDto, Input>().ReverseMap();
			CreateMap<AddressDto, Address>().ReverseMap();
		}
    }
}
