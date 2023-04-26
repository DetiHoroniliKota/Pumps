using Pump.Models;

namespace Pumps.Interface
{
    public interface IEquipmentRepository
    {
        Task CrearAsync(Order device);

        Task<List<Order>> GetAllAsync();

        Task UpdateAsync(Order device);

        Task DelitedAsync(Order device);

    }
}
