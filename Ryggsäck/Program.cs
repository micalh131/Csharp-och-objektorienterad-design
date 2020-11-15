using System;
using System.Collections.Generic;

namespace Ryggsäck
{
    class Program
    {
        static void Main(string[] args)
        {
            var bag = new List<string>() { "Bulle", "Saft" };

            while (true)
            {


                Console.WriteLine("Välkommen till ryggsäcken!");
                Console.WriteLine("[1] Lägg till ett föremål");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Rense innehållet");
                Console.WriteLine("[4] Avsluta");
                Console.WriteLine("Välj:");
                var number = Convert.ToInt32(Console.ReadLine());


                if (number == 1)
                {
                    Console.WriteLine("Skriv föremål du vill lägga till:");
                    var item = Console.ReadLine();
                    bag.Add(item);
                    Console.WriteLine("Föremålet är sparat");

                }
                else if (number == 2)
                {
                    foreach (var item in bag)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (number == 3)
                {
                    bag.Clear();
                    Console.WriteLine("Ryggsäcken är nu tom");
                }
                else if (number == 4)
                {
                    return;
                }

            }

        }
    }
}
