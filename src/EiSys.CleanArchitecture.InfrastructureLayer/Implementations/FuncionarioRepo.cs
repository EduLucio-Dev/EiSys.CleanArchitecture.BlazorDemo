using EiSys.CleanArchitecture.ApplicationLayer.Contracts;
using EiSys.CleanArchitecture.ApplicationLayer.DTOs;
using EiSys.CleanArchitecture.DomainLayer.Entities;
using EiSys.CleanArchitecture.InfrastructureLayer.Data;
using Microsoft.EntityFrameworkCore;

namespace EiSys.CleanArchitecture.InfrastructureLayer.Implementations
{
    public class FuncionarioRepo : IFuncionario
    {
        private readonly AppDbContext appDbCOntext;

        public FuncionarioRepo(AppDbContext appDbContext)
        {
            this.appDbCOntext = appDbContext;
        }
        public async Task<ServiceResponse> AddAsync(Funcionario funcionario)
        {
            appDbCOntext.Funcionarios.Add(funcionario);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Adicionado.");

        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            var funcionario = await appDbCOntext.Funcionarios.FindAsync(id);
            if (funcionario != null)
                return new ServiceResponse(false, "Usuario não encontrado.");
            appDbCOntext.Funcionarios.Remove(funcionario);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Removido.");
        }

        // Método assíncrono para buscar todos os funcionários do banco de dados sem rastreamento de alterações, retornando uma lista de objetos Funcionario.
        public async Task<List<Funcionario>> GetAsync() => await appDbCOntext.Funcionarios.AsNoTracking().ToListAsync();

        public async Task<Funcionario> GetByIdAsync(Guid id) => await appDbCOntext.Funcionarios.FindAsync(id);

        public async Task<ServiceResponse> UpdateAsync(Funcionario funcionario)
        {
            appDbCOntext.Update(funcionario);
            await SaveChangesAsync();
            return new ServiceResponse(true, "Atualizado");
        }

        private async Task SaveChangesAsync() => await appDbCOntext.SaveChangesAsync();
    }
}
