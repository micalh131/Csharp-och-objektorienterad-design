using System;

namespace Inmatning
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mata in ditt namn:");
            var inputName = Console.ReadLine();
            Console.WriteLine($"Hej och välkommen {inputName}!");
            Console.WriteLine("Mata in året du är född:");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in månaden du är född:");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mata in dagen du är född:");
            var day = Convert.ToInt32(Console.ReadLine());


            DateTime birthday = new DateTime(year, month, day);

            Console.WriteLine($"Din födelsedag är: {birthday.Date}");

            TimeSpan diff = DateTime.Now.Date - birthday.Date;
            Console.WriteLine($"Du har left {diff.TotalDays} dagar på denna planet");

        }
    }
}
