using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pumps.Interface;

namespace Pumps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private IPumpRepository _pumpRepository;

        public AdminController(IPumpRepository pumpRepository)
        {
            _pumpRepository = pumpRepository;
        }


        [HttpGet("pump")]
        public async Task<List<Pump.Models.Pump>> ListPumps()
        {
            return await _pumpRepository.GetAllAsync();
        }


        [HttpPost("Pump/create")]
        public async Task CreatePump([FromForm] IFormCollection formData)
        {
            var pump = new Pump.Models.Pump
            {

            };
            await _pumpRepository.CrearAsync(pump);
        }
    }
}
