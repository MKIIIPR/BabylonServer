

using AshesMapBib.Models.AccountModels;

namespace Services.AccountServices
{
    public interface IClientService
    {
        Task<KrakenClientView> ClientCall();
        Task DeleteView(KrakenClientView model);
        Task<KrakenClientView> GetClientCall(KrakenClientView model);
        Task GetMyInfos();
    }
}