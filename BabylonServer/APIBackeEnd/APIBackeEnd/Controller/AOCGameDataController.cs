using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using APIBackeEnd.Games.AshesOfCreation;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using AshesMapBib.Models.GameRelatedModels;
using APIBackeEnd.Games.AshesOfCreation.Worker;
namespace ApiServer.Controllers.ComunityController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AOCGameDataController : ControllerBase
    {

        private readonly ILogger<AOCGameDataController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly HttpClient _httpClient;
        public AOCGameFileFactory _factory { get; set; } 
        public AshesAssembly _newAss { get; set; }

        public AOCGameDataController(IWebHostEnvironment env,ILogger<AOCGameDataController> logger, IHttpClientFactory httpClientFactory)
        {
            _env = env;
            _httpClient = httpClientFactory.CreateClient(); // Standard-Client
            _logger = logger;
            _factory = new AOCGameFileFactory(env);
           
        }
        // GET: api/Comunities
        [HttpGet]
        [Route("/BuildNew")]
        public async Task<ActionResult> InitNewBuild(string BuildVersion)
        {

            //create AocGameSettings
            var settings = new AOCGameSettings(BuildVersion);
            //create AocGameAssembly
            _newAss = new AshesAssembly(settings, null, null);
            PrepareFolderStructure(settings);
            _factory.SetGameSettings(settings);
            await _factory.CreateItemRootTreeAsync();
            await _factory.CreateItemRarityAsync();
            await _factory.CreateInGameItemsAsync();
            
            //CreateGameItems();
            CreateItemRoot(settings);

            return Ok($"Neues GameVersion {BuildVersion} erfolgreich Verarbeitet.");
        }
        private void CreateItemRoot(AOCGameSettings settings)
        {
            List<ItemRootTree> itemRootTrees = new List<ItemRootTree>();
            // Hier können Sie den Code zum Erstellen der ItemRoot-Datei hinzufügen
            //write itemroot trees to file
            var itemRootPath = Path.Combine(_env.WebRootPath, settings.ItemRootFilePath);
            if (!System.IO.File.Exists(itemRootPath))
            {
                System.IO.File.WriteAllText(itemRootPath, "[]");
            }
            else
            {
                //read itemroot trees from file
                var itemRootJson = System.IO.File.ReadAllText(itemRootPath);
                itemRootTrees = System.Text.Json.JsonSerializer.Deserialize<List<ItemRootTree>>(itemRootJson);
            }

            _logger.LogInformation("ItemRoot-Datei erstellt.");
        }

        private void PrepareFolderStructure(AOCGameSettings settings)
        {
            // Hole den absoluten Pfad zum wwwroot-Verzeichnis
            var rootPath = _env.WebRootPath;

            if (string.IsNullOrEmpty(rootPath))
            {
                _logger.LogError("Das wwwroot-Verzeichnis konnte nicht ermittelt werden.");
                throw new InvalidOperationException("Das wwwroot-Verzeichnis ist nicht verfügbar.");
            }

            // erstelle die Pfade aus AOCGameSettings
            var itemRootPath = Path.Combine(rootPath, settings.ItemRootFilePath);
            var inGameItemsPath = Path.Combine(rootPath, settings.InGameItemsFilePath);
            var rarityPath = Path.Combine(rootPath, settings.RarityFilePath);
            var srcPath = Path.Combine(rootPath, settings.SRCPath);
            // Erstelle die Verzeichnisse, falls sie nicht existieren
            Directory.CreateDirectory(Path.GetDirectoryName(itemRootPath) ?? string.Empty);
            Directory.CreateDirectory(Path.GetDirectoryName(inGameItemsPath) ?? string.Empty);
            Directory.CreateDirectory(Path.GetDirectoryName(rarityPath) ?? string.Empty);
            Directory.CreateDirectory(Path.GetDirectoryName(srcPath) ?? string.Empty);
            //wenn der ordner nicht existiert, erstelle ihn
            if (!Directory.Exists(srcPath))
            {
                Directory.CreateDirectory(srcPath);
            }


            // Erstelle leere JSON-Dateien, falls sie nicht existieren
            if (!System.IO.File.Exists(itemRootPath))
            {
                System.IO.File.WriteAllText(itemRootPath, "[]");                
            }
            
            if (!System.IO.File.Exists(inGameItemsPath))
            {               
                System.IO.File.WriteAllText(inGameItemsPath, "[]");                
            }
            if (!System.IO.File.Exists(rarityPath))
            {
                System.IO.File.WriteAllText(rarityPath, "[]");
            }








        }

    }
    
    }
