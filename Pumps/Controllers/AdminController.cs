using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pumps.Interface;
using Pumps.Models;
using Pumps.Models.Enums;


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

        [HttpPost("pump/create")]
        public async Task CreatePump([FromForm] IFormCollection formData)
        {
            var rand = new Random();
            var pump = new Pump.Models.Pump
            {
                ArtivendorСode = int.Parse(formData["artivendorCode"]),
                Title = "TF3",
                H = 80,
                Q = 3,
                Price = 15000,
                Typ = PumpTyp.Вownhole,
                Picture = "Pump.jpg"

            };
            await _pumpRepository.CrearAsync(pump);
        }
    }
}
