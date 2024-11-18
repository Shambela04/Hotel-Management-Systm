using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class MenuItem
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }


        public MenuItem(int no, string name, int price)
        {
            Number = no;
            Name = name;
            Price = price;

        }
        public override string ToString()
        {
            return $"{Number}: ${Name}: ${Price}";
                
        }
    }
}
