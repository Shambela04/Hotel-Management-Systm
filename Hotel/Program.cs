namespace Hotel
{
    internal class Program
    {
        static void Main()
        {
            Hotel resto = new Hotel();
            int Choose;
            do
            {

                Console.WriteLine("-------------------------");
                Console.WriteLine("WELCOME To The Restaurant...");
                Console.WriteLine("1. Display Menu :");
                Console.WriteLine("2. Place Order :");
                Console.WriteLine("3. View Order :");
                Console.WriteLine("4. Total Bill :");
                Console.WriteLine("5. Finish..");
                Console.WriteLine("-------------------------");

                Choose = int.Parse(Console.ReadLine());
                switch(Choose)
                {
                    case 1:
                        resto.ShowMenu();
                        Console.WriteLine("---------");
                        break;

                    case 2:
                        resto.placeOrder();
                        break;
                        Console.WriteLine("----------");
                        

                    case 3:
                        resto.ViewOrder();
                        break;
                        Console.WriteLine("----------");
                        

                    case 4:
                        resto.TotalBill();
                        break;
                        Console.WriteLine("----------");
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        break;
                        Console.WriteLine("----------");
                        

                    default:
                        Console.WriteLine("Enter Valid Option");
                        break;
                        Console.WriteLine("--------");
                }

            }




        }



    }

    

}