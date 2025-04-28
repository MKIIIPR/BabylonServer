using AOCGameBackend;
using APIBackeEnd.Games.AshesOfCreation.Services;
using APIBackeEnd.Games.AshesOfCreation.Worker;
using AshesMapBib.Models.GameRelatedModels;
using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using System.Text.Json;

namespace APIBackeEnd.Games.AshesOfCreation
{
    public class AshesAssembly
    {
        public AOCGameSettings _settings { get; set; }
        public AOCGameDataServices _gdservice { get; set; }
        public List<AOC_Item> AOCItems { get; set; } = new List<AOC_Item>();
        public List<ItemRootTree> ItemRootTrees { get; set; } = new List<ItemRootTree>();
        public List<ItemRarity> ItemRarities { get; set; } = new List<ItemRarity>();
        public AshesAssembly(AOCGameSettings settings,  AOCGameDataServices gdservice )
        {

            _gdservice = gdservice;
            _settings = settings;            
            InititializeAsync(settings).GetAwaiter().GetResult();

        }
        public async Task InititializeAsync(AOCGameSettings settings)
        {
            
            ItemRootTrees = await _gdservice.LoadItemRootTreeAsync() ;
            ItemRarities = await _gdservice.LoadItemRaritiesAsync();
            AOCItems = await _gdservice.LoadInGameItemsAsync();
        }
    
        

    }
}
