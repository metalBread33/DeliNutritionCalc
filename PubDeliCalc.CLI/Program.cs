using PDC.Database;
using PDC.Library.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PDC.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Continue = true;
            Console.WriteLine("Welcome to the Publix Deli Nutritional" +
                " Calculator (Not Official) \nThis CLI is used for testing" +
                "features as they are implemented");
            do
            {
                int choice = int.Parse(Menu());

                switch (choice) 
                {
                    case 0:
                        Continue= false;
                        break;
                    case 1:
                        Traditional();
                        break;
                    case 2:
                        Sub();
                        break;
                    case 3:
                        HotCase();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid menu option?");
                        break;
                }
            } while (Continue);
        }

        static string Menu()
        {
            Console.WriteLine("What would you like to see?" +
                "\n1) Traditional Order" +
                "\n2) Sub Order\n3) Hotcase Order \n0) Quit");
            return Console.ReadLine() ?? "10";
        }

        static void Traditional()
        {
            Console.WriteLine("Traditional called");
            Console.WriteLine("Testing TROG abilitiy to read from a file");
            List<TrogSQLEntry>? turkeys = TrogSQL.current.getFromFile(TradFileSelection());
            foreach (var turkey in turkeys)
                Console.WriteLine(turkey.ToString());
        }

        static void Sub()
        {
            Console.WriteLine("Sub called");
        }

        static void HotCase()
        {
            Console.WriteLine("Hot called");
        }

        //Function used to determine which file to read from when using CLI
        static string? TradFileSelection()
        {
            Console.WriteLine("1)Publix \n2)Boar's Head?");
            var pOrBh = Console.ReadLine();
            int.TryParse(pOrBh, out var response);
            if(response == 1)
            {
                //Publix
            }
            if (response == 2)
            {
                Console.WriteLine("1) Turkey \n2) Ham \n3) Beef \n4) Cheese \n5) Loaves and shit");
                var meatType = Console.ReadLine();
                int.TryParse(meatType, out var file);
                if (file == 1)
                    return "\\Trad\\BH\\Turkey\\Turkey.txt";
                return null;
            }

            Console.WriteLine("File not found, try again");
            return null;
            
        }
    }
}