using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class MarketEfService:IMarketService
    {
        private readonly HeavyContext _context;

        public MarketEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<Market>> GetAllAsync()
        {
            return await _context.Markets.ToListAsync();
        }

        public async Task<Market> GetByIdAsync(int id)
        {
            return await _context.Markets.FindAsync(id);
        }

        public async Task<Market> AddAsync(Market model)
        {
            _context.Markets.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(Market model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Market model)
        {
            _context.Markets.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
