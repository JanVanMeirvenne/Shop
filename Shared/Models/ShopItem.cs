using System;
using System.Collections.Generic;
namespace Shared.Models
{
    public class ShopItem
    {
        public string Id {get;set;}

        public string Name {get;set;}

        public string Description {get;set;}

        public bool AllowQuantity {
            get;set;
        }

        public double Price {get;set;}

        

        public IEnumerable<ShopItem> SubItems {get;set;}

        public ShopItem(){
            this.Id = Guid.NewGuid().ToString();
        }
    }
}