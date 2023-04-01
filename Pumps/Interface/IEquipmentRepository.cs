using Pump.Models;

namespace Pumps.Interface
{
    public interface IEquipmentRepository
    {
        Task CrearAsync(Equipment device);

        Task<List<Equipment>> GetAllAsync();

        Task UpdateAsync(Equipment device);

        Task DelitedAsync(Equipment device);

    }
}
