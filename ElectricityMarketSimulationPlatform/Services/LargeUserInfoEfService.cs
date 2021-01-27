using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class LargeUserInfoEfService:ILargeUserInfoService
    {
        private readonly HeavyContext _context;

        public LargeUserInfoEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<LargeUserInfo>> GetAllAsync()
        {
            return await _context.LargeUserInfos.ToListAsync();
        }

        public async Task<LargeUserInfo> GetByIdAsync(int id)
        {
            return await _context.LargeUserInfos.FindAsync(id);
        }

        public async Task<LargeUserInfo> AddAsync(LargeUserInfo model)
        {
            _context.LargeUserInfos.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(LargeUserInfo model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(LargeUserInfo model)
        {
            _context.LargeUserInfos.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
