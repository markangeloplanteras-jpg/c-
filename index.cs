
using System;

class Program
{
    static void Main()
    {
        int choice, quantity;
        double total = 0;
        string order = "";

        Console.WriteLine("================================");
        Console.WriteLine("       SIMPLE ORDER MENU");
        Console.WriteLine("================================");
        Console.WriteLine("1. Burger       - $5.00");
        Console.WriteLine("2. Pizza        - $8.00");
        Console.WriteLine("3. Fries        - $3.00");
        Console.WriteLine("4. Soda         - $2.00");
        Console.WriteLine("5. Exit");
        Console.WriteLine("================================");

        Console.Write("Enter your choice: ");
        choice = Convert.ToInt32(Console.ReadLine());

        if (choice >= 1 && choice <= 4)
        {
            Console.Write("Enter quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    order = "Burger";
                    total = 5.00 * quantity;
                    break;

                case 2:
                    order = "Pizza";
                    total = 8.00 * quantity;
                    break;

                case 3:
                    order = "Fries";
                    total = 3.00 * quantity;
                    break;

                case 4:
                    order = "Soda";
                    total = 2.00 * quantity;
                    break;
            }

            Console.WriteLine("\n================================");
            Console.WriteLine("          ORDER RECEIPT");
            Console.WriteLine("================================");
            Console.WriteLine("Item: " + order);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Total: $" + total.ToString("F2"));
            Console.WriteLine("================================");
            Console.WriteLine("Thank you for your order!");
        }
        else if (choice == 5)
        {
            Console.WriteLine("Thank you! Goodbye.");
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
