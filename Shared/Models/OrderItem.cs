using System.Collections.Generic;
using System.Linq;

namespace Shared.Models
{
    public class OrderItem
    {
        public int Quantity {get;set;}
        public ShopItem Item {get;set;}

        public IEnumerable<OrderItem> SubItems {get;set;}

        public double GetPrice(){
            double price = 0;
            price += Quantity * Item.Price;
            if(SubItems != null && SubItems.Any()){
                foreach(var subItem in SubItems){
                    price += subItem.GetPrice();
                }
            }

            return price;
        }
    }
}