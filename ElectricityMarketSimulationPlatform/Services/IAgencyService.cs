using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IAgencyService
    {
        Task<List<Agency>> GetAllAsync();
        Task<Agency> GetByIdAsync(int id);
        Task<Agency> AddAsync(Agency model);
        Task UpdateAsync(Agency model);
        Task DeleteAsync(Agency model);
    }
}
