using AshesMapBib.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Services.AccountServices.ClientServices.Api

{
    public class ClientService : IClientService
    {
        private readonly IAPIHelper _client;


        public ClientService(IAPIHelper client)
        {
            _client = client;
        }

        public async Task<KrakenClientView> ClientCall()
        {

            HttpResponseMessage response = await _client.ApiClient.GetAsync("/api/KrakenClient/Client");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsAsync<KrakenClientView>();
                return result;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public async Task GetMyInfos()
        {

            HttpResponseMessage response = await _client.ApiClient.GetAsync($"/GetAllHeaders");
            var x = response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode == false)
            {
                throw new Exception(response.ReasonPhrase);
            }

        }

        public Task<KrakenClientView> GetClientCall(KrakenClientView model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteView(KrakenClientView model)
        {
            throw new NotImplementedException();
        }
    }
}
