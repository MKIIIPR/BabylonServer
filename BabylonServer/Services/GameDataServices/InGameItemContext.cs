using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using AshesMapBib.Models.GameRelatedModels;

using System.Text.Json;
using Services.GameDataServices;

public class InGameItemContext<T> where T : IGameItem
{
    private readonly InGameItemApiClient _itemClient;

    private bool _primesLoaded;
    private bool _attachmentsLoaded;
    private bool _raritiesLoaded;

    public Dictionary<string, T> PrimeList { get; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, T> AttachList { get; } = new(StringComparer.OrdinalIgnoreCase);
    public Dictionary<string, ItemRarity> RarityList { get; } = new(StringComparer.OrdinalIgnoreCase);
    public ItemRootTree ItemRoot { get; set; } = new ItemRootTree();
    public InGameItemContext(InGameItemApiClient itemClient)
    {
        _itemClient = itemClient;
    }

    public async Task EnsureCompleteLoaded() 
    { 
        await EnsurePrimesLoadedAsync(); 
        await EnsureRaritiesLoadedAsync();
        await EnsureItemRootLoadedAsync();
    }
    public async Task EnsurePrimesLoadedAsync()
    {
        if (_primesLoaded) return;

        // 1) JSON vom API-Client holen
        var json = await _itemClient.GetPrimaryItemsAsync(typeof(T).Name);

        // 2) Parsen in List<T>
        var items = JsonSerializer.Deserialize<List<T>>(json,new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<T>();

        // 3) In das Dictionary füllen
        foreach (var i in items)
            PrimeList[i.Id] = i;

        _primesLoaded = true;
    }

    public async Task EnsureAttachmentsLoadedAsync()
    {
        if (_attachmentsLoaded) return;

        var json = await _itemClient.GetAttachmentItemsAsync(typeof(T).Name);
        var items = JsonSerializer.Deserialize<List<T>>(
            json,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        ) ?? new List<T>();

        foreach (var i in items)
            AttachList[i.Id] = i;

        _attachmentsLoaded = true;
    }
    public async Task EnsureItemRootLoadedAsync()
    {
        if (_attachmentsLoaded) return;

        var json = await _itemClient.GetItemRootAsync(typeof(T).Name);

        // DEBUG OUTPUT     Console.WriteLine($"JSON von GetItemRootAsync: {json}");

   
        // Dann erst deserialisieren
        var ItemRoots = JsonSerializer.Deserialize<List<ItemRootTree>>(json, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });
        if(ItemRoots !=null && ItemRoots.Any())
        ItemRoot = ItemRoots[0];

    }

    public async Task EnsureRaritiesLoadedAsync()
    {
        if (_raritiesLoaded) return;

        var json = await _itemClient.GetRaritysAsync(typeof(T).Name);
        var list = JsonSerializer.Deserialize<List<ItemRarity>>(
            json,
            new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
        ) ?? new List<ItemRarity>();

        foreach (var r in list)
            RarityList[r.Name] = r;

        _raritiesLoaded = true;
    }

   
}
