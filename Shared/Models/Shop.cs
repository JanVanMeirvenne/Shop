using System;
namespace Shared.Models
{
    public class Shop
    {
        public string Id {
            get;set;
        }

        public string Name {
            get;set;
        }

        public string Description {
            get;set;
        }

        public bool Open {get;set;}

        public Shop(){
            this.Id = Guid.NewGuid().ToString();
        }


    }
}