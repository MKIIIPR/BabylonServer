using APIBackeEnd.Games.AshesOfCreation;
using APIBackeEnd.Games.AshesOfCreation.Worker;
using AshesMapBib.Models.GameRelatedModels;
using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
namespace ApiServer.Controllers.ComunityController
{
    [Route("api/[controller]")]
    [ApiController]
    public class AOCItemController : ControllerBase
    {

        private readonly ILogger<AOCGameDataController> _logger;
        private readonly IWebHostEnvironment _env;
        private readonly HttpClient _httpClient;
    
        public AshesAssembly _newAss { get; set; }

        public AOCItemController(IWebHostEnvironment env, ILogger<AOCGameDataController> logger)
        {
            _env = env;
            
            _logger = logger;
    

        }
        // GET: api/Comunities
        [HttpGet]
        [Route("/api/AOCItem")]
        public async Task<ActionResult> AllAOCItems()
        {
            //load jsonfile from \wwwroot\GameFiles\AshesOfCreation\Alpha-1.0.0\Data\ItemRoot.json


            try
            {
                // Pfad zur Datei aufbauen
                var filePath = Path.Combine(_env.WebRootPath, "GameFiles", "AshesOfCreation", "Alpha-1.0.0", "Data", "Items.json");

                if (!System.IO.File.Exists(filePath))
                {
                    _logger.LogError($"Datei nicht gefunden: {filePath}");
                    return NotFound("Datei nicht gefunden.");
                }

                // Datei lesen
                var jsonContent = await System.IO.File.ReadAllTextAsync(filePath);

                // JSON in Liste von AOCItem deserialisieren
                var items = JsonSerializer.Deserialize<List<AOCItem>>(jsonContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return Ok(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fehler beim Laden der AOC Items.");
                return StatusCode(500, "Fehler beim Verarbeiten der Anfrage.");
            }
        }
        [HttpGet]
        [Route("/api/AOCItem/itemroot")]
        public async Task<ActionResult> GetItemRoot()
        {
            //load jsonfile from \wwwroot\GameFiles\AshesOfCreation\Alpha-1.0.0\Data\ItemRoot.json


            try
            {
                // Pfad zur Datei aufbauen
                var filePath = Path.Combine(_env.WebRootPath, "GameFiles", "AshesOfCreation", "Alpha-1.0.0", "Data", "ItemRoot.json");

                if (!System.IO.File.Exists(filePath))
                {
                    _logger.LogError($"Datei nicht gefunden: {filePath}");
                    return NotFound("Datei nicht gefunden.");
                }

                // Datei lesen
                var jsonContent = await System.IO.File.ReadAllTextAsync(filePath);

                // JSON in Liste von AOCItem deserialisieren
                var items = JsonSerializer.Deserialize<List<ItemRootTree>>(jsonContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return Ok(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fehler beim Laden der AOC Items.");
                return StatusCode(500, "Fehler beim Verarbeiten der Anfrage.");
            }
        }
        [HttpGet]
        [Route("/api/AOCItem/rarity")]
        public async Task<ActionResult> GetRarity()
        {
            //load jsonfile from \wwwroot\GameFiles\AshesOfCreation\Alpha-1.0.0\Data\ItemRoot.json


            try
            {
                // Pfad zur Datei aufbauen
                var filePath = Path.Combine(_env.WebRootPath, "GameFiles", "AshesOfCreation", "Alpha-1.0.0", "Data", "rarity.json");

                if (!System.IO.File.Exists(filePath))
                {
                    _logger.LogError($"Datei nicht gefunden: {filePath}");
                    return NotFound("Datei nicht gefunden.");
                }

                // Datei lesen
                var jsonContent = await System.IO.File.ReadAllTextAsync(filePath);

                // JSON in Liste von AOCItem deserialisieren
                var items = JsonSerializer.Deserialize<List<ItemRarity>>(jsonContent, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

                return Ok(items);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Fehler beim Laden der AOC Items.");
                return StatusCode(500, "Fehler beim Verarbeiten der Anfrage.");
            }
        }

    }

}
