using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshesMapBib.Models.GameRelatedModels
{
    public class ItemRarity
    {
        public string Id { get; set; } 
        public string GameId { get; set; }
        public string Name { get; set; }
        public string? Color { get; set; }
        public string? RarityIcon { get; set; }
    }
}
