using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Portafolio.Models;

namespace Portafolio.Services 
{
    public class GitHubService
    {
        private readonly HttpClient _httpClient;

        public GitHubService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("request");
        }

        public async Task<List<GitHubRepo>> GetReposAsync(string username)
        {
            var response = await _httpClient.GetAsync($"https://api.github.com/users/fabdev99/repos");
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            return JsonSerializer.Deserialize<List<GitHubRepo>>(json, options);
        }
    }
}
