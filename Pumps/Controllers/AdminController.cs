using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pumps.Interface;
using Pumps.Models;
using Pumps.Models.Enums;
using Pumps.Utilities;


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
        public async Task<string> CreatePump([FromForm] IFormCollection formData)
        {
            
            var pump = new Pump.Models.Pump
            {
                ArtivendorСode = int.Parse(formData["artivendorCode"]),
                //Title = "TF3",
                //H = 80,
                //Q = 3,
                Price = decimal.Parse(formData["price"])
                //Typ = PumpTyp.Вownhole,
                //Picture = "Pump.jpg"

            };
            await _pumpRepository.CrearAsync(pump);
            return "Ok";
        }

        [HttpPost("pumps/upload")]
        public async Task<object> UploadPicture([FromForm] IFormFile file) {
            if (file == null)
            {
                return new
                {
                    Status = "No file provided"
                };
            }
            var path = Path.Combine(Settings.UploadDir, file.FileName);
            try
            {
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            catch (Exception ex)
            {
                return new { Status = ex.Message };
            }

            return new
            {
                Status = "File successfully uploaded",
                fileName = file.FileName
            };

        }
    }
}
