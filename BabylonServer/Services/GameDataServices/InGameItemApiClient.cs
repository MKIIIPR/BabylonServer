using Services.AccountServices.ClientServices.Api;

namespace Services.GameDataServices
{
    public class InGameItemApiClient
    {
        private readonly IAPIHelper _client;

        public InGameItemApiClient(IAPIHelper client)
            => _client = client;

        public async Task<string> GetPrimaryItemsAsync(string gameId)
        {
            try
            {
                var response = await _client.ApiClient.GetAsync($"/api/{gameId}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                // Netzwerkfehler, DNS-Fehler, Timeout ...
                Console.Error.WriteLine($"[InGameItemApiClient] GetPrimaryItemsAsync failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Sonstige Fehler
                Console.Error.WriteLine($"[InGameItemApiClient] Unexpected error in GetPrimaryItemsAsync: {ex}");
            }

            // Fallback: leeres Array, damit JsonSerializer später nicht crasht
            return "[]";
        }

        public async Task<string> GetAttachmentItemsAsync(string gameId)
        {
            try
            {
                var response = await _client.ApiClient.GetAsync($"/api/{gameId}/attachments");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"[InGameItemApiClient] GetAttachmentItemsAsync failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"[InGameItemApiClient] Unexpected error in GetAttachmentItemsAsync: {ex}");
            }

            return "[]";
        }

        public async Task<string> GetRaritysAsync(string gameId)
        {
            try
            {
                var response = await _client.ApiClient.GetAsync($"/api/{gameId}/rarity");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"[InGameItemApiClient] GetRaritysAsync failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"[InGameItemApiClient] Unexpected error in GetRaritysAsync: {ex}");
            }

            // Fallback: leeres Array oder Objekt
            return "[]";
        }

        public async Task<string> GetItemRootAsync(string gameId)
        {
            try
            {
                var response = await _client.ApiClient.GetAsync($"/api/{gameId}/itemroot");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                Console.Error.WriteLine($"[InGameItemApiClient] GetItemRootAsync failed: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"[InGameItemApiClient] Unexpected error in GetItemRootAsync: {ex}");
            }

            // Fallback: leeres ItemRootTree-JSON, je nach Schema z.B. "{}"
            return "{}";
        }
    }
}