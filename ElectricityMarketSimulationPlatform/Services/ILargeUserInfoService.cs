using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface ILargeUserInfoService
    {
        Task<List<LargeUserInfo>> GetAllAsync();
        Task<LargeUserInfo> GetByIdAsync(int id);
        Task<LargeUserInfo> AddAsync(LargeUserInfo model);
        Task UpdateAsync(LargeUserInfo model);
        Task DeleteAsync(LargeUserInfo model);
    }
}
