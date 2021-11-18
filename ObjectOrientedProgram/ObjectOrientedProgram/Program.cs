using ObjectOrientedProgram;
using System;

namespace ObjectOrientedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Object Oriented Program");
                Console.WriteLine("Choose the Option : \n 1. JSON \n 2. Inventory Management \n 3. Stock List \n 4. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain inv = new InventoryMain();
                        inv.DisplayData(@"D:\git project\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\Files\Inventory.json");
                        break;
                    case 2:
                        InventoryManagementMain inven = new InventoryManagementMain();
                        inven.ReadData(@"D:\git project\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\Files\InventoryList.json");
                        inven.DisplayData("Rice");
                        inven.DisplayData("Wheat");
                        inven.DisplayData("Pulses");
                        break;
                    case 3:
                        StockMain stock = new StockMain();
                        Console.WriteLine("The Stock Report is : ");
                        stock.DisplayData(@"D:\git project\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\Files\Stock.json");
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}