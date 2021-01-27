using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class ScatteredUserInfoEfService:IScatteredUserInfoService
    {
        private readonly HeavyContext _context;

        public ScatteredUserInfoEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<ScatteredUserInfo>> GetAllAsync()
        {
            return await _context.ScatteredUserInfos.ToListAsync();
        }

        public async Task<ScatteredUserInfo> GetByIdAsync(int id)
        {
            return await _context.ScatteredUserInfos.FindAsync(id);
        }

        public async Task<ScatteredUserInfo> AddAsync(ScatteredUserInfo model)
        {
            _context.ScatteredUserInfos.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(ScatteredUserInfo model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ScatteredUserInfo model)
        {
            _context.ScatteredUserInfos.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
