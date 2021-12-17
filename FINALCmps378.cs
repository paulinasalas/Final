using System;

namespace Midterm
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            {
                Console.WriteLine("\t\tWelcome To Target! Choose the following options:\n");
                Console.WriteLine("\t\t1) Make a purchase\n");
                Console.WriteLine("\t\t2) Make a return\n");
                Console.WriteLine("\t\t3) Manage Inventory\n");
                Console.WriteLine("\t\t4) View Report\n");
                //Transaction option
                char[] purchase = new char[400];
                int counter = 0;
                double total = 0;
                double[] prices = new double[400];
                int choice = Convert.ToChar(Console.ReadLine());
                ///Make a purchase
                if (choice == '1')
                {

                    Console.Write("Which product would you like to purchase?\n");
                    Console.WriteLine("Item Name            Price");
                    Console.WriteLine("a = Lego Star Wars       $25");
                    Console.WriteLine("b = Cookie               $5");

                    purchase[counter] = Convert.ToChar(Console.ReadLine());
                    if (purchase[counter] == 'a')
                    {
                        prices[counter] = 25;
                    }
                    else if (purchase[counter] == 'b')
                    {
                        prices[counter] = 5;
                    }
                    counter++;

                    //Another purchase option
                    Console.WriteLine("Anything else? Y/N");
                    char option = Convert.ToChar(Console.ReadLine());
                    if (option == 'N')
                    {
                        for (int i = 0; i < purchase.Length; i++)

                            total += prices[i];
                        Console.WriteLine("Your total is $" + total);
                        Console.WriteLine("Thank you for shopping at target");

                    }
                    else if (option == 'Y')

                    //Yes option
                    {
                        Console.Write("Which product would you like to purchase?\n");
                        Console.WriteLine("Item Name            Price");
                        Console.WriteLine("a = Lego Star Wars       $25");
                        Console.WriteLine("b = Cookie               $5");

                        purchase[counter] = Convert.ToChar(Console.ReadLine());
                        if (purchase[counter] == 'a')
                        {
                            prices[counter] = 25;
                        }
                        else if (purchase[counter] == 'b')
                        {
                            prices[counter] = 5;
                        }
                        counter++;

                        //Another purchase option
                        Console.WriteLine("Anything else? Y/N");
                        char option2 = Convert.ToChar(Console.ReadLine());
                        if (option2 == 'N')
                        {
                            for (int i = 0; i < purchase.Length; i++)

                                total += prices[i];
                            Console.WriteLine("Your total is $" + total);
                            Console.WriteLine("Thank you for shopping at target");

                        }
                    }
                }
                //Make a Return
                else if (choice == '2')
                {
                    Console.Write("Which product would you like to return?\n");
                    Console.WriteLine("Item Name            Price");
                    Console.WriteLine("a = Lego Star Wars       $25");
                    Console.WriteLine("b = Cookie               $5");

                    char return1 = Convert.ToChar(Console.ReadLine());
                    int rtotal;
                    if (return1 == 'a')
                    {
                        Console.WriteLine("Your refund total is $25");
                        Console.WriteLine("Thank you for shopping at target");
                    }
                    else if (return1 == 'b')
                    {
                        Console.WriteLine("Your refund total is $5");
                        Console.WriteLine("Thank you for shopping at target");
                    }

                }
                //Another return option
                Console.WriteLine("Anything else? Y/N");
                char roption = Convert.ToChar(Console.ReadLine());
                if (roption == 'N')
                {

                    Console.WriteLine("Your refund total is $");
                    Console.WriteLine("Thank you for shopping at target");
                }
                else if (roption == 'Y')

                //Yes option
                {
                    Console.Write("Which product would you like to return?\n");
                    Console.WriteLine("Item Name            Price");
                    Console.WriteLine("a = Lego Star Wars       $25");
                    Console.WriteLine("b = Cookie               $5");

                    char return2 = Convert.ToChar(Console.ReadLine());
                    int rtotal2;
                    if (return2 == 'a')
                    {
                        Console.WriteLine("Your refund total is $25");
                        Console.WriteLine("Thank you for shopping at target");

                    }
                    else if (return2 == 'b')
                    {
                        Console.WriteLine("Your refund total is $5");
                        Console.WriteLine("Thank you for shopping at target");
                    }

                }
                //Inventory
                else if (choice == '3')
                {
                    Console.WriteLine("Manage Inevntory\n");
                    Console.WriteLine("The following items is currently stored in the system:\n");
                    Console.WriteLine("Item Name            Price");
                    Console.WriteLine("a = Lego Star Wars       $25");
                    Console.WriteLine("b = Cookie               $5");
                    Console.WriteLine("1. Add New Item");
                    Console.WriteLine("2. Remove Item");
                    Console.WriteLine("3. Main Menu");
                }
                char inventory = Convert.ToChar(Console.ReadLine());

                if (inventory == '1')
                {
                    Console.WriteLine("Add Item:\n");
                    Console.WriteLine("Item Name\n");
                    char itemname = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Item Price\n");
                    char itemprice = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Added Successfully!");

                }
                else if (inventory == '2')
                {
                    Console.WriteLine("Remove Item:\n");
                    Console.WriteLine("Item Name\n");
                    char itemname = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Item Price\n");
                    char itemprice = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Removed Successfully!");
                }
                else if (inventory == '3')
                {
                    Console.WriteLine("\t\tWelcome To Target! Choose the following options:\n");
                    Console.WriteLine("\t\t1) Make a purchase\n");
                    Console.WriteLine("\t\t2) Make a return\n");
                    Console.WriteLine("\t\t3) Manage Inventory\n");
                    Console.WriteLine("\t\t4) View Report\n");
                }

                //Report
                else if (choice == '4')
                {
                    Console.WriteLine("Reports\n");
                    Console.WriteLine("Total Customers\n");
                    Console.WriteLine("Total Profit\n");
                    char itemprice = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Removed Successfully!");
                }
            }
        }
    }
}
    