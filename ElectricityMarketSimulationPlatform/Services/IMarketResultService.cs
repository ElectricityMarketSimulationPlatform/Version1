using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IMarketResultService
    {
        Task<List<MarketResult>> GetAllAsync();
        Task<MarketResult> GetByIdAsync(int id);
        Task<MarketResult> AddAsync(MarketResult model);
        Task UpdateAsync(MarketResult model);
        Task DeleteAsync(MarketResult model);
    }
}
