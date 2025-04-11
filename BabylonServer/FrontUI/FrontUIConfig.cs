using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontUI
{
    public class FrontUIConfig
    {
        // Dictionary für Entwicklungs- und Produktionsumgebung
        public Dictionary<string, string> DevSettings { get; set; }
        public Dictionary<string, string> ProdSettings { get; set; }

        // Konstruktor, der die beiden Dictionarys mit Standardwerten initialisiert
        public FrontUIConfig()
        {
            // Initialisieren der Entwicklungsumgebungseinstellungen
            DevSettings = new Dictionary<string, string>
            {
                { "api", "" },
                { "token", "" },
                { "hash", "" }
            };

            // Initialisieren der Produktionsumgebungseinstellungen
            ProdSettings = new Dictionary<string, string>
            {
                { "api", "" },
                { "token", "" },
                { "hash", "" }
            };
        }

        // Methode zum Hinzufügen oder Ändern von Einstellungen für die Entwicklungsumgebung
        public void AddDevSetting(string key, string value)
        {
            if (!DevSettings.ContainsKey(key))
            {
                DevSettings.Add(key, value);
            }
            else
            {
                DevSettings[key] = value; // Wert aktualisieren, wenn der Schlüssel bereits existiert
            }
        }

        // Methode zum Hinzufügen oder Ändern von Einstellungen für die Produktionsumgebung
        public void AddProdSetting(string key, string value)
        {
            if (!ProdSettings.ContainsKey(key))
            {
                ProdSettings.Add(key, value);
            }
            else
            {
                ProdSettings[key] = value; // Wert aktualisieren, wenn der Schlüssel bereits existiert
            }
        }

        // Methode zum Abrufen eines Werts für die Entwicklungsumgebung basierend auf dem Schlüssel
        public string GetDevSetting(string key)
        {
            return DevSettings.ContainsKey(key) ? DevSettings[key] : null;
        }

        // Methode zum Abrufen eines Werts für die Produktionsumgebung basierend auf dem Schlüssel
        public string GetProdSetting(string key)
        {
            return ProdSettings.ContainsKey(key) ? ProdSettings[key] : null;
        }

        // Optional: Methode zum Entfernen eines Schlüssels für die Entwicklungsumgebung
        public bool RemoveDevSetting(string key)
        {
            return DevSettings.Remove(key);
        }

        // Optional: Methode zum Entfernen eines Schlüssels für die Produktionsumgebung
        public bool RemoveProdSetting(string key)
        {
            return ProdSettings.Remove(key);
        }
    }

}
