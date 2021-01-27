using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class SellOrderEfService:ISellOrderService
    {
        private readonly HeavyContext _context;

        public SellOrderEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<SellOrder>> GetAllAsync()
        {
            return await _context.SellOrders.ToListAsync();
        }

        public async Task<SellOrder> GetByIdAsync(int id)
        {
            return await _context.SellOrders.FindAsync(id);
        }

        public async Task<SellOrder> AddAsync(SellOrder model)
        {
            _context.SellOrders.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(SellOrder model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(SellOrder model)
        {
            _context.SellOrders.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
