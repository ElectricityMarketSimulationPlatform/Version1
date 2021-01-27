using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IMarketJoinService
    {
        Task<List<MarketJoin>> GetAllAsync();
        Task<MarketJoin> GetByIdAsync(int id);
        Task<MarketJoin> AddAsync(MarketJoin model);
        Task UpdateAsync(MarketJoin model);
        Task DeleteAsync(MarketJoin model);
    }
}
