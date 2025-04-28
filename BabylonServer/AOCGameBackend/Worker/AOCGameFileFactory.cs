using AOCGameBackend;
using AshesMapBib.Models.GameRelatedModels;
using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using System.Text.Json;

namespace APIBackeEnd.Games.AshesOfCreation.Worker
{
    public class AOCGameFileFactory : IAOCGameFileFactory
    {
        //abhängig von den AOCGameSettings werden hier Task<T> generiert
        public AOCGameSettings _settings { get; set; }
        public AOCGameFileFactory()
        {
        }
        public void SetGameSettings(AOCGameSettings settings)
        {
            _settings = settings;
            EnsureFilesExistAsync().Wait();
        }
        public async Task EnsureFilesExistAsync()
        {
            if (!File.Exists(_settings.InGameItemsFilePath))
            {
                await CreateInGameItemsAsync();
            }

            if (!File.Exists(_settings.RarityFilePath))
            {
                await CreateItemRarityAsync();
            }

            if (!File.Exists(_settings.ItemRootFilePath))
            {
                await CreateItemRootTreeAsync();
            }
        }
        //Create ItemRootTree and save with SaveGenericListAsync
        public async Task CreateItemRootTreeAsync()
        {
            List<ItemRootTree> itemRootTree = new List<ItemRootTree>();

            await SaveGenericListAsync(_settings.ItemRootFilePath, itemRootTree);

        }
        public async Task CreateItemRarityAsync()
        {
            List<ItemRarity> itemRarity = new List<ItemRarity>();
            await SaveGenericListAsync(_settings.RarityFilePath, itemRarity);
        }
        public async Task CreateInGameItemsAsync()
        {
            List<AOC_Item> inGameItems = new List<AOC_Item>();
            await SaveGenericListAsync(_settings.InGameItemsFilePath, inGameItems);
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
        public async Task<List<T>> SaveGenericListAsync<T>(string filePath, List<T> list)
        {
            try
            {
                var fullPath = Path.Combine("wwwroot", filePath);
                var directory = Path.GetDirectoryName(fullPath);

                // Check if the directory exists, if not, create it
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                var json = JsonSerializer.Serialize(list);
                await File.WriteAllTextAsync(fullPath, json);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving file: {ex.Message}");
            }

        }
    }
}
