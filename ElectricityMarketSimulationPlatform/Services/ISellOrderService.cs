using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface ISellOrderService
    {
        Task<List<SellOrder>> GetAllAsync();
        Task<SellOrder> GetByIdAsync(int id);
        Task<SellOrder> AddAsync(SellOrder model);
        Task UpdateAsync(SellOrder model);
        Task DeleteAsync(SellOrder model);
    }
}
