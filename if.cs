using System;

namespace if_Test
{
    class Program
    {
        static bool verbose = false;
        static bool continuOnError = false;
        static bool logging = false;

    static void Main(string[] args)
        {
           if(args.Length != 1)
            {
                Console.WriteLine("Usage: MyApp.exe option");
                return;
            }
            string option = args[0];
            switch (option.ToLower())
            {
                case "/v":
                case "/verbose":
                    verbose = true;
                    break;
                case "/c":
                    continuOnError= true;
                    break;
                case "/l":
                    logging = true;
                    break;
                default:
                    Console.WriteLine("Unknown argument: {0}", option);
                    break;

            }
        }
    }
}
