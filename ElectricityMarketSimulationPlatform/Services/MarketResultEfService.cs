using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class MarketResultEfService:IMarketResultService
    {
        private readonly HeavyContext _context;

        public MarketResultEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<MarketResult>> GetAllAsync()
        {
            return await _context.MarketResults.ToListAsync();
        }

        public async Task<MarketResult> GetByIdAsync(int id)
        {
            return await _context.MarketResults.FindAsync(id);
        }

        public async Task<MarketResult> AddAsync(MarketResult model)
        {
            _context.MarketResults.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(MarketResult model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(MarketResult model)
        {
            _context.MarketResults.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
