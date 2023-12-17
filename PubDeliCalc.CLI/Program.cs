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
        }

        static void Sub()
        {
            Console.WriteLine("Sub called");
        }

        static void HotCase()
        {
            Console.WriteLine("Hot called");
        }
    }
}