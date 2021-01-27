using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Data;
using ElectricityMarketSimulationPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectricityMarketSimulationPlatform.Services
{
    public class ThermalUnitInfoEfService:IThermalUnitInfoService
    {
        private readonly HeavyContext _context;

        public ThermalUnitInfoEfService(HeavyContext context)
        {
            _context = context;
        }

        public async Task<List<ThermalUnitInfo>> GetAllAsync()
        {
            return await _context.ThermalUnitInfos.ToListAsync();
        }

        public async Task<ThermalUnitInfo> GetByIdAsync(int id)
        {
            return await _context.ThermalUnitInfos.FindAsync(id);
        }

        public async Task<ThermalUnitInfo> AddAsync(ThermalUnitInfo model)
        {
            _context.ThermalUnitInfos.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task UpdateAsync(ThermalUnitInfo model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(ThermalUnitInfo model)
        {
            _context.ThermalUnitInfos.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}
