using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class BuyOrderEfService: IBuyOrderService
    {
        private readonly HeavyContext _context;

        public BuyOrderEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<BuyOrder>> GetAllAsync()
        {
            return await _context.BuyOrders.ToListAsync();
        }

        public async Task<BuyOrder> GetByIdAsync(int id)
        {
            return await _context.BuyOrders.FindAsync(id);
        }

        public async Task<BuyOrder> AddAsync(BuyOrder model)
        {
            _context.BuyOrders.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(BuyOrder model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(BuyOrder model)
        {
            _context.BuyOrders.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
