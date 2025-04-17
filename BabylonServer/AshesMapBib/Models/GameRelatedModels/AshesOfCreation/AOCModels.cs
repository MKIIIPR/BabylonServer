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

    public class AOC_Item
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }
        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonProperty("icon")]
        [JsonPropertyName("icon")]
        public string Icon { get; set; }


    }
}