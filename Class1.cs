using System;
using System.Collections.Generic;
using System.Text;

namespace Black_Friday
{
    class Class1
    {
        public static void testGoTo()
        {
            menu:
            Console.WriteLine("Select an option");
            Console.WriteLine("1 - Register");
            Console.WriteLine("2 - Edit");
            Console.WriteLine("3 - Delete");
            Console.WriteLine("Press any other key to exit...");

            string option = Console.ReadLine();

            switch(option)
            {
                case "1":
                    Console.WriteLine("This is the register menu");
                    goto menu;

                case "2":
                    Console.WriteLine("This is the edit menu");
                    goto menu;

                case "3":
                    Console.WriteLine("This is the delete menu");
                    goto menu;

                default:
                    Console.WriteLine("Bye!");
                    break;
            }
        }
        
        static void Main()
        {

        }
    }
}
