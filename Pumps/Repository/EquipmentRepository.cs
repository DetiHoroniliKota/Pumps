using Pumps.Interface;
using Pumps.Data;
using Microsoft.EntityFrameworkCore;
using Pump.Models;

namespace Pumps.Repository
{
    public class EquipmentRepository : IEquipmentRepository
    {

        private readonly ApplicationDbContext _context;

        public EquipmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CrearAsync(Equipment device)
        {
            _context.Add(device);
            await _context.SaveChangesAsync();
        }

        public async Task DelitedAsync(Equipment device)
        {
            _context.Remove(device);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Equipment>> GetAllAsync()
        {
            return await _context.Equipment
               .ToListAsync();
        }

        public async Task UpdateAsync(Equipment device)
        {
            _context.Equipment.Update(device);
            await _context.SaveChangesAsync();
        }
    }
}
