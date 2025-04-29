using AshesMapBib.Models;
using AshesMapBib.Models.GameRelatedModels;
using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using Services.AccountServices.ClientServices.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.MarketPlaceServcies
{

    public class MarketContext<T> where T : IGameItem
    {
        public string GameId { get; set; }
        public Dictionary<string, MarketItem> Listing { get; } = new(StringComparer.OrdinalIgnoreCase);
        
        public ItemRootTree ItemRoot => _gameContext.ItemRoot;
        public Dictionary<string, ItemRarity> RarityList => _gameContext.RarityList;
        public Dictionary<string, T> PrimeList => _gameContext.PrimeList;
        public Dictionary<string, T> AttachList => _gameContext.AttachList;
        public (bool, T) GetPrimeItemById(string id) => PrimeList.TryGetValue(id, out var item) ? (true, item) : (false, default(T));
        public (bool, T) GetAttachItemById(string id) => PrimeList.TryGetValue(id, out var item) ? (true, item) : (false, default(T));
        public ItemRarity RarityById(string id) => RarityList.TryGetValue(id, out var item) ? item : null;


        public InGameItemContext<T> _gameContext;

        public MarketContext(InGameItemContext<T> gameContext)
        {
            _gameContext = gameContext;
            GameId = typeof(T).Name; // oder eine andere Logik, um das GameId zu setzen
        }
    }

}
