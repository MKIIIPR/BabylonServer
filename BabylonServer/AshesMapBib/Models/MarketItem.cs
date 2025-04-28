using AshesMapBib.Models.GameRelatedModels;
using AshesMapBib.Models.GameRelatedModels.AshesOfCreation;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshesMapBib.Models
{

    public class MarketItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string CreatorId { get; set; } // ID des Erstellers des Angebots
        // Allgemeine Marktplatz-Daten
        public string Name { get; set; }
        public string GameId { get; set; } 
        public string OrderType { get; set; } // "buy" oder "sell"
        
        public DateTime? LastUpdated { get; set; } = DateTime.UtcNow;        
        public string? RarityId { get; set; }
        public bool IsTradable { get; set; } = true;
        public double Value { get; set; } // Preis in kleinster Einheit (z. B. Copper, Credits, etc.)
        public string ServerId { get; set; } // ID des Servers, auf dem das Item gehandelt wird
        // Verknüpfung zum Original-Item
        public string TrueItemId { get; set; }
        
    }

    public static class MarketItemExtensions
    {
        /// <summary>
        /// Gibt den Preis formatiert zurück, je nach GameId:
        /// - "starcitizen" → "12345 Credits"
        /// - "ashesofcreation" → "1G 23S 45C"
        /// - sonst → "12345 Coins"
        /// </summary>
        public static string GetFormattedValue(this MarketItem item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            return item.GameId?.ToLowerInvariant() switch
            {
                "starcitizen" => $"{item.Value:N0} Credits",
                "ashesofcreation" => FormatAshesCurrency((int)item.Value),
                _ => $"{item.Value:N0} Coins",
            };
        }

        /// <summary>
        /// Nimmt einen Kupfer-Wert und wandelt ihn in Gold/Silber/Kupfer um.
        /// </summary>
        private static string FormatAshesCurrency(int copper)
        {
            int gold = copper / 10000;
            int silver = (copper % 10000) / 100;
            int remainingCopper = copper % 100;

            var parts = new List<string>();
            if (gold > 0) parts.Add($"{gold}G");
            if (silver > 0) parts.Add($"{silver}S");
            // Wenn gar nichts übrig bleibt, zeige wenigstens 0C
            if (remainingCopper > 0 || parts.Count == 0)
                parts.Add($"{remainingCopper}C");

            return string.Join(" ", parts);
        }
    }
    public static class GamePriceFormatter
    {
        public static string FormatPrice(string gameId, double value)
        {
            return gameId.ToLower() switch
            {
                "starcitizen" => $"{value:N0} Credits",

                "ashesofcreation" => FormatAshesCurrency((int)value),

                _ => $"{value:N0} Coins"
            };
        }

        private static string FormatAshesCurrency(int copper)
        {
            int gold = copper / 10000;
            int silver = (copper % 10000) / 100;
            int remainingCopper = copper % 100;

            var parts = new List<string>();
            if (gold > 0) parts.Add($"{gold}G");
            if (silver > 0) parts.Add($"{silver}S");
            if (remainingCopper > 0 || parts.Count == 0) parts.Add($"{remainingCopper}C");

            return string.Join(" ", parts);
        }
        
    }


}
   


