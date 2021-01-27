using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IMarketService
    {
        Task<List<Market>> GetAllAsync();
        Task<Market> GetByIdAsync(int id);
        Task<Market> AddAsync(Market model);
        Task UpdateAsync(Market model);
        Task DeleteAsync(Market model);
    }
}
