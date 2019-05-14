using System.Collections.Generic;
using System;
namespace Shared.Models
{
    public class Order
    {
        public string Id {
            get;set;
        }

        public string FirstName {
            get;set;
        }

        public string LastName {get;set;}

        public string Mail {get;set;}

        public string Description {get;set;}

        public IEnumerable<OrderItem> Items {get;set;}

        public Order()
        {
            this.Id = Guid.NewGuid().ToString();
            
        }

        public double GetTotalPrice(){
            double price = 0;
            foreach(var item in Items){
                price += item.GetPrice();
                

            }
            return price;

            
        }
    }
}