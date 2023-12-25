using PDC.Database;
using PDC.Library.Models;


/*CLI used to test backend features as they are implemented. Useful for preventing
 confusion when implementing a new feature.*/
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
                        Continue = false;
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
            List<TrogSQLEntry>? meats;
            meats = TrogSQL.current.getFromFile(TradFileSelection());
            while (true)
            {
                if (meats == null)
                {
                    meats = TrogSQL.current.getFromFile(TradFileSelection());
                }
                else break;
            }
          

            foreach (var meat in meats)
                Console.WriteLine(meat.ToString());
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
            Console.WriteLine("1)Publix \n2)Boar's Head");
            var pOrBh = Console.ReadLine();
            int.TryParse(pOrBh, out var response);
            if (response == 1)
            {
                //Publix
                Console.WriteLine("1) Meat\n2)Cheese");
                var pubFileSelect = Console.ReadLine();
                int.TryParse(pubFileSelect, out var file);
                if (file == 1)
                    return "\\Trad\\Publix\\Meat.txt";
                if (file == 2)
                    return "\\Trad\\Publix\\Cheese.txt";
            }

            if (response == 2)
            {
                //Boar's Head
                Console.WriteLine("1) Turkey \n2) Ham \n3) Beef \n4) Chicken" +
                    "\n5) Loaves and shit \n6) Cheese");
                var bHFileSelect = Console.ReadLine();
                int.TryParse(bHFileSelect, out var file);
                if (file == 1)
                    return "\\Trad\\BH\\Turkey.txt";
                if (file == 2)
                    return "\\Trad\\BH\\Ham.txt";
                if (file == 3)
                    return "\\Trad\\BH\\Beef.txt";
                if (file == 4)
                    return "\\Trad\\BH\\Chicken.txt";
                if (file == 5)
                    return "\\Trad\\BH\\Misc.txt";
                if (file == 6)
                    return "\\Trad\\BH\\Cheese.txt";
            }

            Console.WriteLine("File not found, try again");
            return null;

        }
    }
}