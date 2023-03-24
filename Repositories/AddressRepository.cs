using Aportaciones.Data;
using Aportaciones.Dtos;
using Aportaciones.Interfaces;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;

namespace Aportaciones.Repositories
{
    public class AddressRepository : IAddressRepository
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;
		private readonly IDistributedCache _cache;
		public AddressRepository(ApplicationDbContext context, IMapper mapper, IDistributedCache cache)
		{
			_context = context;
			_mapper = mapper;
			_cache = cache;
		}
		public async Task<AddressDto> GetAddressDetails(int id)
		{
			var result = await _context.Addresses.FirstOrDefaultAsync(a => a.Id == id);
			return _mapper.Map<AddressDto>(result);
		}
		public async Task<List<AddressDto>> GetAllAddresses()
		{			
			var result = await _context.Addresses.ToListAsync();
			return result.Select( adr => new AddressDto
			{
				Id = adr.Id,
				Street = adr.Street,	
				Number = adr.Number,
				Email = adr.Email,
				Name = adr.Name,
			}).ToList();
		}
	}
}
