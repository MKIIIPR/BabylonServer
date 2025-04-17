using AshesMapBib.Models.GameRelatedModels;
using System.Diagnostics.Contracts;
using System.Text.Json;

namespace APIBackeEnd.Games.AshesOfCreation
{
    public class AOCGameSettings
    {
        // Constants for file paths and names
        // These paths are relative to the game's data directory wwwroot/GameFiles/AshesOfCreation/{version}/
        public string GameName = "AshesOfCreation";
        public string GameVersion = "Alpha-1.0.0";
        public string ItemRootFilePath => $"GameFiles/AshesOfCreation/{GameVersion}/Data/ItemRoot.json";
        public string InGameItemsFilePath => $"GameFiles/AshesOfCreation/{GameVersion}/Data/Rarity.json";
        public string RarityFilePath => $"GameFiles/AshesOfCreation/{GameVersion}/Data/Rarity.json";

        public AOCGameSettings()
        {           
        }
        //load itemrootfilepath from the file 
        public async Task<ItemRootTree> LoadItemRootTreeAsync()
        {
            var itemRootPath = Path.Combine("wwwroot", ItemRootFilePath);
            if (File.Exists(itemRootPath))
            {
                var itemRootJson = await File.ReadAllTextAsync(itemRootPath);
                var itemRoot = JsonSerializer.Deserialize<ItemRootTree>(itemRootJson);
                return itemRoot;
            }
            else
            {
                throw new FileNotFoundException($"Item root file not found at {itemRootPath}");
            }
        }
        //load generic T from File for example Rarity, ItemRootTree
        
    }
}
