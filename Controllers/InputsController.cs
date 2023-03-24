using Aportaciones.Dtos;
using Aportaciones.Interfaces;
using Aportaciones.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Aportaciones.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class InputsController : ControllerBase
	{
		private readonly IInputRepository _inputRepository;
		private readonly IAddressRepository _addressRepository;
		public InputsController(IInputRepository inputRepository, IAddressRepository addressRepository)
		{
			_inputRepository = inputRepository;
			_addressRepository = addressRepository;
		}

		[Route("Current")]
        [HttpGet]
        public async Task<IActionResult> GetCurrentInput()
        {
			try
			{
				var result = await _inputRepository.GetCurrentInput();
				return Ok(result);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}			
        }

		[Route("AddressDetails/{id:int}")]
		[HttpGet]
		public async Task<IActionResult> GetAddressDetails(int id)
		{
			try
			{
				var result = await _addressRepository.GetAddressDetails(id);
				return Ok(result);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[Route("GetAllAdresses")]
		[HttpGet]
		public async Task<IActionResult> GetAllAdresses()
		{
			try
			{
				var results = await _addressRepository.GetAllAddresses();
				return Ok(results);	
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}	
		}

		[Route("SaveInputDetails")]
		[HttpPost]
		public async Task<IActionResult> SaveInputDetails([FromBody] InputDetailsDto details)
		{
			try
			{
				var results = await _inputRepository.SaveInputDetails(details);
				return Ok(results);
			}
			catch (Exception ex )
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
