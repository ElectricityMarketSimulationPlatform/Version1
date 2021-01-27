using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IRetailCompanyInfoService
    {
        Task<List<RetailCompanyInfo>> GetAllAsync();
        Task<RetailCompanyInfo> GetByIdAsync(int id);
        Task<RetailCompanyInfo> AddAsync(RetailCompanyInfo model);
        Task UpdateAsync(RetailCompanyInfo model);
        Task DeleteAsync(RetailCompanyInfo model);
    }
}
