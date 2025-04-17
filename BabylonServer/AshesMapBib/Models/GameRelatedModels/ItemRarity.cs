using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshesMapBib.Models.GameRelatedModels
{
    public class ItemRarity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string? Color { get;set; }
        public string? RarityIcon { get; set; }
    }
}
