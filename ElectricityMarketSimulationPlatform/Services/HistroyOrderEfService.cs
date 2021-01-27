using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class HistroyOrderEfService: IHistroyOrderService
    {
        private readonly HeavyContext _context;

        public HistroyOrderEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<HistroyOrder>> GetAllAsync()
        {
            return await _context.HistroyOrders.ToListAsync();
        }

        public async Task<HistroyOrder> GetByIdAsync(int id)
        {
            return await _context.HistroyOrders.FindAsync(id);
        }

        public async Task<HistroyOrder> AddAsync(HistroyOrder model)
        {
            _context.HistroyOrders.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(HistroyOrder model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(HistroyOrder model)
        {
            _context.HistroyOrders.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
