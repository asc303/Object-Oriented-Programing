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
                Console.WriteLine("Welcome to Object Oriented Programs");
                Console.WriteLine("Choose the Option : \n 1.JSON \n 2.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryMain inv = new InventoryMain();
                        inv.DisplayData(@"D:\git project\ObjectOrientedProgram\ObjectOrientedProgram\ObjectOrientedProgram\Files\Inventory.json");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}