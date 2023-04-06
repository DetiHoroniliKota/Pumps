﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pumps.Interface;

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

         [HttpGet("{id}")]
        public async Task<Pump.Models.Pump> GetPump(int id)
        {
            return  await _pumpRepository.GetByIdAsync(id);
        }
        

      /*  [HttpPost("api/[controller]/createPump")]
        public async Task Post()
        {
            var pump = new Pump.Models.Pump
            {

            };
            await _pumpRepository.CrearAsync(pump);
            

        }
      */

    }
}
