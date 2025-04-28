using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshesMapBib.Models.GameRelatedModels
{
    public interface IHasId
    {
        string Id { get; }
        string Name { get; }

    }

    public class IngameItem<T> where T : IHasId
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string GameId { get; private set; }
        public T? Item { get; private set; }
       

        public IngameItem(T? realItem, string gameId)
        {
            Id = realItem.Id;
            Name = realItem.Name;
            GameId = gameId;
            Item = realItem;
        }
    }
}

    
