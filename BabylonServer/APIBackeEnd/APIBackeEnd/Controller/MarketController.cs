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
using AshesMapBib.Models;
namespace ApiServer.Controllers.ComunityController
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {

        private readonly ILogger<MarketController> _logger;


        public MarketController(ILogger<MarketController> logger)
        {


            _logger = logger;


        }
        // GET: api/Comunities
        [HttpGet]
        [Route("/api/Market/AOCItem/{itemid}")]
        public async Task<ActionResult> InitNewBuild(string itemid)
        {
            List<MarketItem> marketItems = SeedList(itemid);
            marketItems = marketItems.Where(e => e.TrueItemId == itemid).ToList();

            return Ok(marketItems);
        }

        private List<MarketItem> SeedList(string itemid)
        {
            var marketItems = new List<MarketItem>();

            var random = new Random();
            var itemId = "Gear_Armor_Heavy_2ndSwordDivision_Feet";
            var rarityId = "aoc.common";
            var serverId = "example-server"; // ggf. anpassen!

            for (int i = 0; i < 15; i++)
            {
                var isBuyOrder = i % 2 == 0; // abwechselnd buy/sell

                var marketItem = new MarketItem
                {
                    CreatorId = Guid.NewGuid().ToString(),                    
                    Name = itemid,
                    GameId = itemId,
                    OrderType = isBuyOrder ? "buy" : "sell",
                    LastUpdated = DateTime.UtcNow,
                    RarityId = rarityId,
                    IsTradable = true,
                    Value = random.Next(500, 1500), // zufälliger Preis zwischen 500 und 1500
                    ServerId = serverId,
                    TrueItemId = itemid
                };

                marketItems.Add(marketItem);
            }

            return marketItems;
        }
    }
    
}
