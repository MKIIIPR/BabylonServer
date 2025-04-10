using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Text.Json;


namespace FrontPWA.Shared.AppState.VarState
{
    public class AppState
    {


        [JsonProperty]
        public string Message { get; private set; } = "";
        [JsonProperty]
        public bool Enabled { get; private set; } = false;
        [JsonProperty]
        public int Counter { get; private set; } = 0;
        [JsonProperty]
        public int TimeToLiveInSeconds { get; set; } = 3600;
        [JsonProperty]
        public DateTime LastAccessed { get; set; } = DateTime.Now;

        //[JsonProperty]
        //public List<ComServerView> ConnectedServer = new List<ComServerView>();

        //public void AddServerGroupe(ComponentBase Source, ComServerView newGroup)
        //{
        //    ConnectedServer.Add(newGroup);
        //    NotifyStateChanged(Source, "Groupe added");
        //}


        public void UpdateMessage(ComponentBase Source, string Message)
        {
            this.Message = Message;
            NotifyStateChanged(Source, "Message");
        }

        public void UpdateEnabled(ComponentBase Source, bool Enabled)
        {
            this.Enabled = Enabled;
            NotifyStateChanged(Source, "Enabled");
        }

        public void UpdateCounter(ComponentBase Source, int Counter)
        {
            this.Counter = Counter;
            NotifyStateChanged(Source, "Counter");
        }

        public event Action<ComponentBase, string> StateChanged;

        private void NotifyStateChanged(ComponentBase Source, string Property) => StateChanged?.Invoke(Source, Property);


        //public void AddServerGroup(ComponentBase Source, ComServerView toAdd)
        //{
        //    ConnectedServer.Add(toAdd);
        //    NotifyStateChanged(Source, "ServerGroup added");
        //}


    }
}
