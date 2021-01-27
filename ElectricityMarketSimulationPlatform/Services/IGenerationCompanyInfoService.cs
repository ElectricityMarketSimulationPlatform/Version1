using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectricityMarketSimulationPlatform.Models;

namespace ElectricityMarketSimulationPlatform.Services
{
    public interface IGenerationCompanyInfoService
    {
        Task<List<GenerationCompanyInfo>> GetAllAsync();
        Task<GenerationCompanyInfo> GetByIdAsync(int id);
        Task<GenerationCompanyInfo> AddAsync(GenerationCompanyInfo model);
        Task UpdateAsync(GenerationCompanyInfo model);
        Task DeleteAsync(GenerationCompanyInfo model);
    }
}
