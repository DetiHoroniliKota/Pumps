using Pumps.Models;

namespace Pumps.Interface
{
    public interface IPumpRepository
    {

        Task CrearAsync(Pump.Models.Pump pump);

        Task<List<Pump.Models.Pump>> GetAllAsync();

          

        Task UpdateAsync(Pump.Models.Pump pump);

        Task DelitedAsync(Pump.Models.Pump pump);
        
        Task<Pump.Models.Pump> GetPumpId(int id);
    }


}
