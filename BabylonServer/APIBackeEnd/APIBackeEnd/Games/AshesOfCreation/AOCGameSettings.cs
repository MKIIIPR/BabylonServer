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
        public string BuildVersion = "Alpha-1.0.0";
        public string ItemRootFilePath => $"wwwroot/GameFiles/AshesOfCreation/{BuildVersion}/Data/ItemRoot.json";
        public string InGameItemsFilePath => $"wwwroot/GameFiles/AshesOfCreation/{BuildVersion}/Data/Items.json";
        public string RarityFilePath => $"wwwroot/GameFiles/AshesOfCreation/{BuildVersion}/Data/Rarity.json";
        public string SRCPath => $"wwwroot/GameFiles/AshesOfCreation/{BuildVersion}/src";


        public AOCGameSettings(string gameVersion)
        {
            BuildVersion = gameVersion;
            
        }
        // Create all necessary subfolders: Data and SRC
       
        
        //load generic T from File for example Rarity, ItemRootTree
        
    }
}
