using Pumps.Interface;
using Pumps.Data;

namespace Pumps.Repository
{
    public class PumpRepository : IPumpRepository
    {
        private readonly ApplicationDbContext _context;

        public PumpRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CrearAsync(Pump.Models.Pump pump)
        {
            _context.Add(pump);
            await _context.SaveChangesAsync();

        }

        public Task DelitedAsync(Pump.Models.Pump pump)
        {
            throw new NotImplementedException();
        }

        public Task<Pump.Models.Pump> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Pump.Models.Pump pump)
        {
            throw new NotImplementedException();
        }
    }
}
