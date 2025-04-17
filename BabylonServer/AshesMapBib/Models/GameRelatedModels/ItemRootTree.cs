using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AshesMapBib.Models.GameRelatedModels
{
    public class ItemRootTree
    {
        public ItemRootTree()
        {
         
        }
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string GameId { get; set; }
        public string FilePath { get;set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        
        public List<ItemRootTree> Children { get; set; } = new List<ItemRootTree>();
        
        public void AddChild(ItemRootTree child)
        {
            Children.Add(child);
        }
    }
}
