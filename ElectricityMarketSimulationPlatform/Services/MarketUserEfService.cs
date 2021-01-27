using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class MarketUserEfService:IMarketUserService
    {
        private readonly HeavyContext _context;

        public MarketUserEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<MarketUser>> GetAllAsync()
        {
            return await _context.MarketUsers.ToListAsync();
        }

        public async Task<MarketUser> GetByIdAsync(int id)
        {
            return await _context.MarketUsers.FindAsync(id);
        }

        public async Task<MarketUser> AddAsync(MarketUser model)
        {
            _context.MarketUsers.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(MarketUser model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(MarketUser model)
        {
            _context.MarketUsers.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
