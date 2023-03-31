using Pump.Models;

namespace Pumps.Interface
{
    public interface IEquipmentRepository
    {
        Task CrearAsync(Equipment pump);

        Task<Equipment> GetAllAsync();

        Task UpdateAsync(Equipment pump);

        Task DelitedAsync(Equipment pump);

    }
}
