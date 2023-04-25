using Pumps.Interface;
using Pumps.Data;
using Microsoft.EntityFrameworkCore;

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


        public async Task<List<Pump.Models.Pump>> GetAllAsync()
        {
            return await _context.Pump
                .OrderByDescending(p => p.Title)
                .ToListAsync();
        }

        public async Task<Pump.Models.Pump> GetPumpId(int id)
        {
            return await _context.Pump.FindAsync(id);
        }

        public async Task UpdateAsync(Pump.Models.Pump pump)
        {
            _context.Pump.Update(pump);
            await _context.SaveChangesAsync();
        }

        public async Task DelitedAsync(Pump.Models.Pump pump)
        {
            _context.Remove(pump);
            await _context.SaveChangesAsync();
        }

        
    }
}
