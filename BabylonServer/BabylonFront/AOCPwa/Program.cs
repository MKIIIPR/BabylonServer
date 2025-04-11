using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using AOCPwa;
using FrontUI;
using System.Text;
using System.Reflection;
using Microsoft.Extensions.Configuration;
using System.IO;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// RootComponents definieren
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

#region Load Config
string environment = "Production"; // Standardm‰ﬂig auf Production setzen
#if DEBUG
environment = "Development"; // In Debug-Mode auf Development setzen
#endif

// Embedded JSON-Datei ausw‰hlen
var assembly = Assembly.Load("FrontUI");  // Verwendet die Assembly von FrontUI
var resourceName = environment == "Development"
    ? "FrontUI.dev_appsettings.json"  // Wenn in Development
    : "FrontUI.pro_appsettings.json"; // Wenn in Production

// Die Datei als Stream laden
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
#endregion

// Registriere die Konfiguration im DI-Container
//builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
var apiUrl = builder.Configuration["api"];

// FrontUI-Dienste und Konfiguration registrieren
builder.Services.ADDFrontUIServices();

await builder.Build().RunAsync();
