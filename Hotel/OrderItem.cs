using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class OrderItem
    {
        public MenuItem Menu { get; set; }
        public int Quantity { get; set; }


        public OrderItem(MenuItem menu, int quantity)
        {
            Menu = menu;
            Quantity = quantity;
        }


        public double GetTotalPrice()
        {
            return Menu.Price * Quantity;
        }
        public override string ToString()
        {
            return $"{Menu}:{Quantity}";
        }


    }

    


}
