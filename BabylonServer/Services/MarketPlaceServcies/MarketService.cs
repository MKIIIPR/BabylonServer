using AshesMapBib.Models;
using Services.AccountServices.ClientServices.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Services.MarketPlaceServcies
{
    public interface IMarketService
    {
        Task<List<MarketItem>> GetItemsForGameAsync(string gameId);
    }

    public class MarketService : IMarketService
    {
        private readonly IAPIHelper _client;

        public MarketService(IAPIHelper httpClient)
        {
            _client = httpClient;
        }

        public async Task<List<MarketItem>> GetItemsForGameAsync(string gameId)
        {
            // Baue die URL abhängig von gameId und T
            var response = await _client.ApiClient.GetFromJsonAsync<List<MarketItem>>($"api/market/{gameId}");
            return response ?? new List<MarketItem>();
        }
    }
}
