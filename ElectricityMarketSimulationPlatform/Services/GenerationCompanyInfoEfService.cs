using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class GenerationCompanyInfoEfService:IGenerationCompanyInfoService
    {
        private readonly HeavyContext _context;
        public GenerationCompanyInfoEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<GenerationCompanyInfo>> GetAllAsync()
        {
            return await _context.GenerationCompanyInfos.ToListAsync();
        }

        public async Task<GenerationCompanyInfo> GetByIdAsync(int id)
        {
            return await _context.GenerationCompanyInfos.FindAsync(id);
        }

        public async Task<GenerationCompanyInfo> AddAsync(GenerationCompanyInfo model)
        {
            _context.GenerationCompanyInfos.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(GenerationCompanyInfo model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(GenerationCompanyInfo model)
        {
            _context.GenerationCompanyInfos.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
