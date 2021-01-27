using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IMarketUserService
    {
        Task<List<MarketUser>> GetAllAsync();
        Task<MarketUser> GetByIdAsync(int id);
        Task<MarketUser> AddAsync(MarketUser model);
        Task UpdateAsync(MarketUser model);
        Task DeleteAsync(MarketUser model);
    }
}
