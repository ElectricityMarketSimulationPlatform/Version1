using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IHistroyOrderService
    {
        Task<List<HistroyOrder>> GetAllAsync();
        Task<HistroyOrder> GetByIdAsync(int id);
        Task<HistroyOrder> AddAsync(HistroyOrder model);
        Task UpdateAsync(HistroyOrder model);
        Task DeleteAsync(HistroyOrder model);
    }
}
