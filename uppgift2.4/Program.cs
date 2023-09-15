using System;

namespace uppgift_2_4
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in lönen på den första personen...");
            string x = Console.ReadLine();
            Console.WriteLine("Skriv in lönen på den andra personen...");
            string y = Console.ReadLine();
            Console.WriteLine("Skriv in lönen på den tredje personen...");
            string z= Console.ReadLine();

            int lön1 = int.Parse(x);
            int lön2 = int.Parse(y);
            int lön3 = int.Parse(z);
            int medel = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("Medelvärdet på dessa löner blir "+ medel +" kr.");
            Console.ReadKey();
        }
    }
}