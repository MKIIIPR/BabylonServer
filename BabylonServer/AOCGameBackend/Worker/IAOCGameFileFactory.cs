
using AOCGameBackend;

namespace APIBackeEnd.Games.AshesOfCreation.Worker
{
    public interface IAOCGameFileFactory
    {
        AOCGameSettings _settings { get; set; }

        Task CreateInGameItemsAsync();
        Task CreateItemRarityAsync();
        Task CreateItemRootTreeAsync();
        Task<List<T>> LoadGenericListAsync<T>(string filePath);
        Task<List<T>> SaveGenericListAsync<T>(string filePath, List<T> list);
        void SetGameSettings(AOCGameSettings settings);
    }
}