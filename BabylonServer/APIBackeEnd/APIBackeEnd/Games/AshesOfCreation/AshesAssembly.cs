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
        public List<AOC_Item_Json> AOCItems { get; set; } = new List<AOC_Item_Json>();
        public List<ItemRootTree> ItemRootTrees { get; set; } = new List<ItemRootTree>();
        public List<ItemRarity> ItemRarities { get; set; } = new List<ItemRarity>();
        public AshesAssembly(AOCGameSettings settings, IAOCGameFileFactory _fac, AOCGameDataServices gdservice )
        {
            _gdservice = gdservice;
            _settings = settings;
            LoadAssemblyFromSettings(settings);
        }

        public void LoadAssemblyFromSettings(AOCGameSettings settings)
        {
           
            // Load the items
            AOCItems = LoadGenericListAsync<AOC_Item_Json>(settings.InGameItemsFilePath).Result;
        }
        public async Task<List<T>> LoadGenericListAsync<T>(string filePath)
        {
            try
            {
                var fullPath = Path.Combine("wwwroot", filePath);
                if (File.Exists(fullPath))
                {
                    var json = await File.ReadAllTextAsync(fullPath);
                    var list = JsonSerializer.Deserialize<List<T>>(json);
                    return list;
                }
                else
                {
                    // Create directory structure and empty JSON file if not exists
                    var directory = Path.GetDirectoryName(fullPath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    await File.WriteAllTextAsync(fullPath, "[]"); // Create an empty JSON array
                    return new List<T>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading file: {ex.Message}");
            }
        }

    }
}
