using APIBackeEnd.Games.AshesOfCreation;
using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using AshesMapBib.Models.GameRelatedModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System.Text.Json;
using AshesMapBib.Models.GameRelatedModels.StarCitizen;
using System.Threading.Tasks;
using System.Linq;

public class AOCGameFileFactory
{
    private readonly IWebHostEnvironment _env;
    private AOCGameSettings _settings;

    public AOCGameFileFactory(IWebHostEnvironment env)
    {
        _env = env;
    }

    public void SetGameSettings(AOCGameSettings settings)
    {
        _settings = settings ?? throw new ArgumentNullException(nameof(settings));
    }

    public async Task CreateItemRootTreeAsync()
    {
        // Lade die Items
        List<AOC_Item_Json> allItems = LoadInGameItemsFromSRC();

        // Erzeuge Baumstruktur
        ItemRootTree tree =await BuildNavTreeFromItems(allItems);
        List<ItemRootTree> treeList= new List<ItemRootTree> { tree };

        var fullPath = Path.Combine(_env.ContentRootPath, _settings.ItemRootFilePath);

        // Optional: schön formatiert mit Einrückung
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        // Objekt → JSON-String
        var json = JsonSerializer.Serialize(treeList, options);

        // JSON in Datei schreiben
        await File.WriteAllTextAsync(fullPath, json);

    }
    private async Task<ItemRootTree> BuildNavTreeFromItems(List<AOC_Item_Json> items)
    {
        var root = new ItemRootTree { Name = "Root" };

        foreach (var item in items)
        {
            if (string.IsNullOrWhiteSpace(item.Icon)) continue;

            var pathParts = item.Id.Split('_', StringSplitOptions.RemoveEmptyEntries).ToList();
            if (!pathParts.Any()) continue;

            var current = root;

            // Prüfen ob der letzte Part eine Zahl ist (z.B. _0, _1)
            bool lastPartIsNumber = int.TryParse(pathParts.Last(), out int dummy);

            // Pfadteile: nur die ersten 2 verwenden ("Mount" und "Grounded")
            int depth = Math.Min(2, pathParts.Count - (lastPartIsNumber ? 1 : 0));

            for (int i = 0; i < depth; i++)
            {
                var part = pathParts[i];

                var child = current.Children.FirstOrDefault(c => c.Name == part);
                if (child == null)
                {
                    child = new ItemRootTree { Name = part };
                    current.Children.Add(child);
                }

                current = child;
            }

            // Danach das eigentliche Item einfügen
            var itemNode = new ItemRootTree
            {
                Name = item.Name,
                Id = item.Id
            };
            current.Children.Add(itemNode);
        }

        await CleanUpRoot(root);

        return root;
    }


    private List<string> UnwantedNavTreeElements { get; set; } = new List<string> { "tower", "sq", "event", "eid", "rvr", "Weapon", "proge", "qeustitem", "gm", "csq", "stattesting", "narrative","war", "questitem", "dunir chair", "testitem" };
    private async Task CleanUpRoot(ItemRootTree root)
    {
        // Remove unwanted tree elements from children root using case-insensitive comparison
        root.Children.RemoveAll(c => UnwantedNavTreeElements
            .Any(unwanted => string.Equals(unwanted, c.Name, StringComparison.OrdinalIgnoreCase)));
    }
    public async Task CreateItemRarityAsync()
    {
        var fullPath = Path.Combine(_env.ContentRootPath, _settings.RarityFilePath);
        var itemRarity = new List<ItemRarity>
        {
            new() {GameId="aoc",Id="aoc.common", Name = "Common", Color = "#56d546" },
            new() {GameId="aoc",Id="aoc.uncommon", Name = "Uncommon", Color = "#56d546" },
            new() {GameId="aoc",Id="aoc.rare", Name = "Rare", Color = "#56d546" },
            new() {GameId="aoc",Id="aoc.heroic", Name = "Heroic", Color = "#56d546" },
            new() {GameId="aoc",Id="aoc.epic", Name = "Epic", Color = "#56d546" },
            new() {GameId="aoc",Id="aoc.legendary", Name = "Legendary", Color = "#56d546" }
        };

        await SaveGenericListAsync<ItemRarity>(fullPath, itemRarity);
    }

    public async Task CreateInGameItemsAsync()
    {
        List<AOC_Item_Json> inGameItems = LoadInGameItemsFromSRC();
        List<AOCItem> AOCItemList = new();
        
        var fullPath = Path.Combine(_env.ContentRootPath, _settings.InGameItemsFilePath);
        foreach (var item in inGameItems)
        {
            AOCItemList.Add(new AOCItem { Id = item.Id, GameId = "AOCItem", Name = item.Name, Description = item.Description, Icon = item.Icon });
        }
        await SaveGenericListAsync<AOCItem>(fullPath, AOCItemList);
    }

    public List<AOC_Item_Json> LoadInGameItemsFromSRC()
    {
        List<AOC_Item_Json> Items = new List<AOC_Item_Json>();    
        var fullSrcPath = Path.Combine(_env.ContentRootPath, _settings.SRCPath);
        var inGameItemsPath = Path.Combine(fullSrcPath, "AOC_Items.json");


        if (!File.Exists(inGameItemsPath))
            throw new FileNotFoundException($"In-game items file not found at {inGameItemsPath}");

        var json = File.ReadAllText(inGameItemsPath);

        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,

        };



        try
        {
            // Entferne die äußeren eckigen Klammern des Arrays
            json = json.Trim('[').Trim(']');

            // Splitte den String anhand von "}, {", aber behalte die Klammern bei jedem Element bei
            var itemStrings = json.Split(new[] { "}," }, StringSplitOptions.None);



            foreach (var itemString in itemStrings)
            {

                var cleanitemString = itemString.Trim('{');
                // Console.WriteLine(cleanitemString);
                try
                {
                    // Füge die fehlenden geschweiften Klammern hinzu, um ein vollständiges JSON-Objekt zu erhalten
                    var fullJson = cleanitemString + "}";
                    // Console.WriteLine(fullJson);
                    // Deserialisiere das vollständige JSON-Objekt in ein Item
                    var item = JsonSerializer.Deserialize<AOC_Item_Json>(fullJson);
                    if (item != null)
                    {
                        Items.Add(item);

                    }
                }
                catch (JsonException ex)
                {
                    Console.WriteLine($"[ERROR] Failed to deserialize item: {ex.Message}. Skipping this item.");
                }
            }
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"[ERROR] JSON Parsing failed: {ex.Message}");
        }

        // Navigationsbaum erstellen

        // Console.WriteLine($"[DEBUG] Root has {NavTree.Children.Count} children.");


        return Items;
    }

    public async Task<List<T>> LoadGenericListAsync<T>(string filePath)
    {
        try
        {
            var fullPath = Path.Combine(_env.WebRootPath, filePath);

            if (File.Exists(fullPath))
            {
                var json = await File.ReadAllTextAsync(fullPath);
                return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }

            var dir = Path.GetDirectoryName(fullPath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            await File.WriteAllTextAsync(fullPath, "[]");
            return new List<T>();
        }
        catch (Exception ex)
        {
            throw new Exception($"Error loading file: {ex.Message}");
        }
    }

    public async Task SaveGenericListAsync<T>(string filePath, List<T> list)
    {
        try
        {
            var fullPath = Path.Combine(_env.WebRootPath, filePath);
            var dir = Path.GetDirectoryName(fullPath);
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            var json = JsonSerializer.Serialize(list);
            await File.WriteAllTextAsync(fullPath, json);
            
        }
        catch (Exception ex)
        {
            throw new Exception($"Error saving file: {ex.Message}");
        }
    }

}
