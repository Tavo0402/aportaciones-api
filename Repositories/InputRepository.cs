using Aportaciones.Data;
using Aportaciones.Dtos;
using Aportaciones.Interfaces;
using Aportaciones.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Aportaciones.Repositories
{
    public class InputRepository : IInputRepository
	{
		private readonly ApplicationDbContext _context;
		private readonly IMapper _mapper;

		public InputRepository(ApplicationDbContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		/// <summary>
		/// Gets the current input details
		/// </summary>
		/// <returns>Task<InputDto></returns>
		public async Task<InputDto> GetCurrentInput()
		{
			var result = await _context.Inputs.FirstOrDefaultAsync(i => i.IsActive == true);
			return _mapper.Map<InputDto>(result);
		}

		public async Task<InputDetailsDto> SaveInputDetails(InputDetailsDto details)
		{
			var det = _mapper.Map<InputDetails>(details);
			await _context.Details.AddAsync(det);
			await _context.SaveChangesAsync();

			return details;
		}
	}
}
