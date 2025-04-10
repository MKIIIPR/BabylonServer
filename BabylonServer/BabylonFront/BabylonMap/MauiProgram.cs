using System.Reflection;
using Microsoft.Extensions.Configuration;
using System.IO;
using FrontUI; // Wenn FrontUI in der selben Lösung ist
using Microsoft.Extensions.Logging;

namespace BabylonMap;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        // 💡 Umgebung bestimmen
        string environment = "Production"; // Standardmäßig auf Production setzen
#if DEBUG
        environment = "Development"; // In Debug-Mode auf Development setzen
#endif

        // 📄 Embedded JSON-Datei wählen
        var assembly = Assembly.Load("FrontUI");  // Verwendet die Assembly von MauiProgram, oder jede andere Klasse in deinem Maui-Projekt
        var resourceName = environment == "Development"
            ? "FrontUI.dev_appsettings.json"  // Wenn in Development
            : "FrontUI.pro_appsettings.json"; // Wenn in Production

        // 📦 Die Datei als Stream laden
        using var stream = assembly.GetManifestResourceStream(resourceName)
            ?? throw new FileNotFoundException($"Embedded resource not found: {resourceName}");

        // Stream in einen String umwandeln
        using var reader = new StreamReader(stream);
        var jsonString = reader.ReadToEnd();

        // JSON-String in einen MemoryStream umwandeln
        using var memoryStream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(jsonString));

        // Konfiguration aus dem MemoryStream laden
        var config = new ConfigurationBuilder()
            .AddJsonStream(memoryStream)
            .Build();

        builder.Configuration.AddConfiguration(config);

        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.ADDFrontUIServices();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
