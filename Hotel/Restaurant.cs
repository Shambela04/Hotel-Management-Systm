using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    public class Restaurant
    {
        private List<MenuItem> menu = new List<MenuItem>();
        private List<OrderItem> orderItems = new List<OrderItem>();

        public void ListOfItems()
        {
            Console.WriteLine("----------------------------------------------------");
            menu.Add(new MenuItem(1, "Veg Masala", 120));
            menu.Add(new MenuItem(2, "Veg Pulav ", 110));
            menu.Add(new MenuItem(3, "Kaju Masala", 120));
            menu.Add(new MenuItem(4, "Dum Biryani", 150));
            menu.Add(new MenuItem(5, "Veg Thali", 100));
            menu.Add(new MenuItem(6, "Chicken Masala", 170));
            menu.Add(new MenuItem(7, "Tandoori Chicken", 200));
            menu.Add(new MenuItem(8, "Fried Rice", 90));
            menu.Add(new MenuItem(9, "Jeera Rice", 100));
            menu.Add(new MenuItem(10, "Ice-Cream", 60));

        }
        public void DisplayMenu()
        {
            try
            {
                ListOfItems();
                foreach (var item in menu)
                {
                    Console.WriteLine(item);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Error Occurring the display Menu");
            }

        }

        public void PlaceOrder()
        {
            try
            {
                //DisplayMenu();
                Console.WriteLine("Enter the the Item Number you want to order....");
                if (int.TryParse(Console.ReadLine(), out int itemId))
                {
                    MenuItem selectItem = menu.Find(m => m.Number == itemId);


                    if (selectItem != null)
                    {
                        Console.WriteLine("Enter the Quantity");
                        if (int.TryParse(Console.ReadLine(), out int quantity))
                        {
                            orderItems.Add(new OrderItem(selectItem, quantity));
                            Console.WriteLine($"{selectItem.Name} is added to your order");

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "Error Occuring to add the order");
            }
        }

        public void ViewOrder()
        {
            try
            {
                if (orderItems.Count > 0)
                {
                    Console.WriteLine("Your Order............");
                    foreach (var item in orderItems)
                    {
                        Console.WriteLine(item);
                    }
                }
                else
                {
                    Console.WriteLine("Your Order Not Placed...........");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occuring for view the order..." + ex.Message);
            }
        }
        public void Checkout()
        {
            try
            {
                if (orderItems.Count > 0)
                {
                    double total = 0;
                    Console.WriteLine("Your Order Details...");
                    foreach (var item in orderItems)
                    {
                        Console.WriteLine(item);
                        total = total + item.GetTotalPrice();
                    }

                    Console.WriteLine("Total Amount:" + total);
                    Console.WriteLine("Thank You for your order ");
                    Console.WriteLine("Please Proceed your Payment......");
                    menu.Clear();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Occuring during the checkout" + ex.Message);
            }
        }

    }
}   