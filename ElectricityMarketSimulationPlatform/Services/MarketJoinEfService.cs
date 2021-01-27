using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class MarketJoinEfService:IMarketJoinService
    {
        private readonly HeavyContext _context;

        public MarketJoinEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<MarketJoin>> GetAllAsync()
        {
            return await _context.MarketJoins.ToListAsync();
        }

        public async Task<MarketJoin> GetByIdAsync(int id)
        {
            return await _context.MarketJoins.FindAsync(id);
        }

        public async Task<MarketJoin> AddAsync(MarketJoin model)
        {
            _context.MarketJoins.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(MarketJoin model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(MarketJoin model)
        {
            _context.MarketJoins.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
