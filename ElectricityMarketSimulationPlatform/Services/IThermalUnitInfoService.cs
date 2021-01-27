using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IThermalUnitInfoService
    {
        Task<List<ThermalUnitInfo>> GetAllAsync();
        Task<ThermalUnitInfo> GetByIdAsync(int id);
        Task<ThermalUnitInfo> AddAsync(ThermalUnitInfo model);
        Task UpdateAsync(ThermalUnitInfo model);
        Task DeleteAsync(ThermalUnitInfo model);
    }
}
