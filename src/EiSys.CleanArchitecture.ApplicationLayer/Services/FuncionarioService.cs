
using EiSys.CleanArchitecture.ApplicationLayer.DTOs;
using EiSys.CleanArchitecture.DomainLayer.Entities;
using System.Net.Http;
using System.Net.Http.Json;

namespace EiSys.CleanArchitecture.ApplicationLayer.Services
{
    internal class FuncionarioService : IFuncionarioService
    {
        private readonly HttpClient httpClient;

        public FuncionarioService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<ServiceResponse> AddAsync(Funcionario funcionario)
        {
            // Envia um objeto funcionario para a API e espera pela resposta assíncrona
            var data = await httpClient.PostAsJsonAsync("api/funcionario", funcionario);

            // Desserializa a resposta JSON para o tipo ServiceResponse
            var response = await data.Content.ReadFromJsonAsync<ServiceResponse>();

            // Retorna o objeto de resposta desserializado
            return response!;
        }

        public async Task<ServiceResponse> DeleteAsync(Guid id)
        {
            // Envia um pedido DELETE para a API para remover um funcionário pelo ID e espera pela resposta
            var data = await httpClient.DeleteAsync($"api/funcionario/{id}");

            // Desserializa a resposta JSON para o tipo ServiceResponse
            var response = await data.Content.ReadFromJsonAsync<ServiceResponse>();

            // Retorna o objeto de resposta desserializado
            return response!;
        }

        public async Task<List<Funcionario>> GetAsync() =>
            // Solicita a lista de funcionários da API e a retorna
            await httpClient.GetFromJsonAsync<List<Funcionario>>($"api/funcionario")!;

        public async Task<Funcionario> GetByIdAsync(Guid id) =>
            // Solicita um funcionário pelo ID para a API e retorna o objeto correspondente
            await httpClient.GetFromJsonAsync<Funcionario>($"api/funcionario/{id}"!);

        public async Task<ServiceResponse> UpdateAsync(Funcionario funcionario)
        {
            // Envia um objeto funcionario atualizado para a API usando PUT e espera pela resposta
            var data = await httpClient.PutAsJsonAsync("api/funcionario", funcionario);

            // Desserializa a resposta JSON para o tipo ServiceResponse
            var response = await data.Content.ReadFromJsonAsync<ServiceResponse>();

            // Retorna o objeto de resposta desserializado
            return response!;
        }

    }
}
