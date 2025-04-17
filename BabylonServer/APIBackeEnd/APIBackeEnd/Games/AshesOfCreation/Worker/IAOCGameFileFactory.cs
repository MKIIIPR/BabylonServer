namespace APIBackeEnd.Games.AshesOfCreation.Worker
{
    public interface IAOCGameFileFactory
    {
        AOCGameSettings AocgameSettings { get; set; }

        void GetLatestAOCGameSettings();
    }
}