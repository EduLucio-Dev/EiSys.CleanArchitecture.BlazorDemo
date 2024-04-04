using EiSys.CleanArchitecture.ApplicationLayer.DTOs;
using EiSys.CleanArchitecture.DomainLayer.Entities;

namespace EiSys.CleanArchitecture.ApplicationLayer.Services
{
    public interface IFuncionarioService
    {
        Task<ServiceResponse> AddAsync(Funcionario funcionario);
        Task<ServiceResponse> UpdateAsync(Funcionario funcionario);
        Task<ServiceResponse> DeleteAsync(Guid id);
        Task<List<Funcionario>> GetAsync();
        Task<Funcionario> GetByIdAsync(Guid id);
    }
}
