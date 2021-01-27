using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class RetailCompanyInfoEfService:IRetailCompanyInfoService
    {
        private readonly HeavyContext _context;

        public RetailCompanyInfoEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<RetailCompanyInfo>> GetAllAsync()
        {
            return await _context.RetailCompanyInfos.ToListAsync();
        }

        public async Task<RetailCompanyInfo> GetByIdAsync(int id)
        {
            return await _context.RetailCompanyInfos.FindAsync(id);
        }

        public async Task<RetailCompanyInfo> AddAsync(RetailCompanyInfo model)
        {
            _context.RetailCompanyInfos.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(RetailCompanyInfo model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(RetailCompanyInfo model)
        {
            _context.RetailCompanyInfos.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
