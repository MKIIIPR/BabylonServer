using Models.RSIShopModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AshesMapBib.Models.GameRelatedModels.AshesOfCreation
{

    public class AOC_Item_Json : IGameItem
    {
        [JsonProperty("itemNameUID")]
        [JsonPropertyName("itemNameUID")]
        public string Id { get; set; }
        [JsonProperty("gameId")]
        [JsonPropertyName("gameId")]
        public string GameId { get; set; }
        [JsonProperty("itemName")]
        [JsonPropertyName("itemName")]
        public string Name { get; set; }
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonProperty("displayIcon")]
        [JsonPropertyName("displayIcon")]
        public string Icon{get; set;}
    } 
    public class AOCItem: IGameItem
    {

        public string Id { get; set; }
        public string GameId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
       public string Icon { get; set; }
    }
    public interface IGameItem
        {
            string Id { get; }
        public string GameId { get; set; }
    }
}