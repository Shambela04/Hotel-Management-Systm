using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class MenuCard
    {
        private List<MenuCard> menu = new List<MenuCard>();
        private List<Orderitm> Orditem = new List<Orderitm>();

        public void DishList()
        {
            Console.WriteLine("");

            menu.Add(new MenuCard(1, "Kaju Masala", 100));
            menu.Add(new MenuCard(2, "Butter Chicken", 220));
            menu.Add(new MenuCard(3,"Malai kofta", 210));
            menu.Add(new MenuCard());

        }

    }
}
