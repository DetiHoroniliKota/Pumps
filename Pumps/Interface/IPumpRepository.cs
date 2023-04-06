using Pumps.Models;

namespace Pumps.Interface
{
    public interface IPumpRepository
    {

        Task CrearAsync(Pump.Models.Pump pump);

        Task<List<Pump.Models.Pump>> GetAllAsync();

        Task<Pump.Models.Pump> GetByIdAsync(int id);

        Task UpdateAsync(Pump.Models.Pump pump);

        Task DelitedAsync(Pump.Models.Pump pump);

        

    }


}
