using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class AgencyEfService: IAgencyService
    {
        private readonly HeavyContext _context;

        public AgencyEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<Agency>> GetAllAsync()
        {
            return await _context.Agencys.ToListAsync();
        }

        public async Task<Agency> GetByIdAsync(int id)
        {
            return await _context.Agencys.FindAsync(id);
        }

        public async Task<Agency> AddAsync(Agency model)
        {
            _context.Agencys.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(Agency model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Agency model)
        {
            _context.Agencys.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
