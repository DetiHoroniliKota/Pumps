using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pumps.Interface;
using Pumps.Models;

namespace Pumps.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PumpController : ControllerBase
    {
        private IPumpRepository _pumpRepository;
        public PumpController(IPumpRepository pumpRepository)
        {
            _pumpRepository = pumpRepository;
        }

        [HttpGet]
        public async Task<List<Pump.Models.Pump>> Index()
        {
            return await _pumpRepository.GetAllAsync();
        }

        [HttpGet("{Id}")]
        public async Task<Pump.Models.Pump> GetPump(string id)
        {
            return await _pumpRepository.GetPumpId(id);
        }
    }
}
