using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IBuyOrderService
    {
        Task<List<BuyOrder>> GetAllAsync();
        Task<BuyOrder> GetByIdAsync(int id);
        Task<BuyOrder> AddAsync(BuyOrder model);
        Task UpdateAsync(BuyOrder model);
        Task DeleteAsync(BuyOrder model);
    }
}
