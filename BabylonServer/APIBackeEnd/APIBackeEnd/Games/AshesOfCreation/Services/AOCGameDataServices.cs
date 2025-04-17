using APIBackeEnd.Games.AshesOfCreation.Worker;
using AshesMapBib.Models.GameRelatedModels;
using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using System.Text.Json;

namespace APIBackeEnd.Games.AshesOfCreation.Services
{
    public class AOCGameDataServices
    {
        public AOCGameSettings _settings { get; set; }
        public AOCGameFileFactory _fileFactory { get; set; }
        public AOCGameDataServices(AOCGameSettings settings, AOCGameFileFactory fileFactory)
        {
            _fileFactory = fileFactory;
            _settings = settings;
            _fileFactory.SetGameSettings(settings);
        }
        public async Task<ItemRootTree> LoadItemRootTreeAsync()
        {
            var itemRootPath = Path.Combine("wwwroot", _settings.ItemRootFilePath);

            try
            {
                if (File.Exists(itemRootPath))
                {
                    var itemRootJson = await File.ReadAllTextAsync(itemRootPath);
                    var itemRoot = JsonSerializer.Deserialize<ItemRootTree>(itemRootJson);

                    if (itemRoot == null)
                    {
                        throw new InvalidOperationException("Deserialization of ItemRootTree returned null.");
                    }

                    return itemRoot;
                }
                else
                {
                    // Asynchroner Aufruf der Erstellungsmethode
                    await _fileFactory.CreateItemRootTreeAsync();

                    throw new FileNotFoundException(
                        $"Item root file not found at {itemRootPath}. A creation attempt was made.");
                }
            }
            catch (Exception ex)
            {
                // Fehlerbehandlung und Logging (falls erforderlich)
                throw new Exception($"An error occurred while loading the ItemRootTree: {ex.Message}", ex);
            }
        }
        public async Task<List<ItemRarity>> LoadItemRaritiesAsync()
        {
            var rarityPath = Path.Combine("wwwroot", _settings.RarityFilePath);
            if (File.Exists(rarityPath))
            {
                var rarityJson = await File.ReadAllTextAsync(rarityPath);
                var rarities = JsonSerializer.Deserialize<List<ItemRarity>>(rarityJson);
                return rarities;
            }
            else
            {
                throw new FileNotFoundException($"Rarity file not found at {rarityPath}");
            }
        }
        public async Task<List<AOC_Item>> LoadInGameItemsAsync()
        {
            var inGameItemsPath = Path.Combine("wwwroot", _settings.InGameItemsFilePath);
            if (File.Exists(inGameItemsPath))
            {
                var inGameItemsJson = await File.ReadAllTextAsync(inGameItemsPath);
                var inGameItems = JsonSerializer.Deserialize<List<AOC_Item>>(inGameItemsJson);
                return inGameItems;
            }
            else
            {
                throw new FileNotFoundException($"In-game items file not found at {inGameItemsPath}");
            }
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
