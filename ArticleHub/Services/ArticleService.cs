using ArticleHub.Models;
using System.Net.Http.Json;

namespace ArticleHub.Services
{
    public class ArticleService
    {
        private readonly HttpClient _httpClient;

        public ArticleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Articles>> GetArticlesAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<Articles>>("https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles");
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch articles.");
            }
        }

        public async Task<Articles> GetArticleByIdAsync(int id)
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<Articles>($"https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles/{id}");
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch the article details.");
            }
        }
    }
}
