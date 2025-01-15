using ArticleHub.Models;
using System.Net.Http.Json;

namespace ArticleHub.Services
{
    public class ArticleService
    {
        private readonly HttpClient _httpClient;

        public ArticleService(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        public async Task<List<Articles>> GetArticlesAsync()
        {
            return await FetchDataAsync<List<Articles>>("https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles");
        }

        public async Task<Articles> GetArticleByIdAsync(int id)
        {
            return await FetchDataAsync<Articles>($"https://ps-dev-1-partnergateway.patientsky.dev/assignment/articles/{id}");
        }

        private async Task<T> FetchDataAsync<T>(string url)
        {
            try
            {
                var response = await _httpClient.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Request to {url} failed with status code {response.StatusCode}.");
                }

                var data = await response.Content.ReadFromJsonAsync<T>();
                if (data == null)
                {
                    throw new InvalidOperationException($"Received null data from {url}.");
                }

                return data;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while fetching data: {ex.Message}", ex);
            }
        }
    }
}