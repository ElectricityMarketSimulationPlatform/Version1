using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IScatteredUserInfoService
    {
        Task<List<ScatteredUserInfo>> GetAllAsync();
        Task<ScatteredUserInfo> GetByIdAsync(int id);
        Task<ScatteredUserInfo> AddAsync(ScatteredUserInfo model);
        Task UpdateAsync(ScatteredUserInfo model);
        Task DeleteAsync(ScatteredUserInfo model);
    }
}
