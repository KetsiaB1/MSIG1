

using System;

namespace VirtualPartager
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Hello World!");

            Console.WriteLine("Hello MSGI:");

            Console.WriteLine("Comes tas?");
            answer = Console.ReadLine();

            if (answer == "oui")
            {
                Console.WriteLine("Trop bien pour toi!");

            }
            else
            {
                Console.WriteLine("dommage pour toi // Too bad buddy");
            }
        }
    }
}

