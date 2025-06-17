using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosForm
{
    public  class ApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseUrl;
        public ApiClient(string baseUrl)
        {
            _baseUrl = baseUrl;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Produto>> GetProdutosAsync()
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/api/produtos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Produto>>();
        }

        public async Task<Produto> GetProdutoAsync(int id)
        {
            var response = await _httpClient.GetAsync($"{_baseUrl}/api/produtos/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Produto>();
        }

        public async Task<Produto> AddProdutoAsync(Produto produto)
        {
            var response = await _httpClient.PostAsJsonAsync($"{_baseUrl}/api/produtos", produto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Produto>();
        }

        public async Task<Produto> UpdateProdutoAsync(int id, Produto produto)
        {
            var response = await _httpClient.PutAsJsonAsync($"{_baseUrl}/api/produtos/{id}", produto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Produto>();
        }

        public async Task DeleteProdutoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"{_baseUrl}/api/produtos/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

    //Produto.cs (no projeto windows forms)
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque { get; set; }
    }
}

