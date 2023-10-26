using System;

namespace Uppgift_3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            double tal1 = double.Parse(Console.ReadLine());
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
           
            string räknesätt = Console.ReadLine();

            double addition = tal1 + tal2;
            double subtraktion = tal1 - tal2;
            double multiplikation = tal1 * tal2;
            double division = tal1 / tal2;


            switch (räknesätt)
            {
                case "1":
                    Console.WriteLine(addition);
                    break;
               
                case "2":
                    Console.WriteLine(subtraktion);
                    break;

                case "3":
                    Console.WriteLine(multiplikation);
                    break;

                case "4":
                    Console.WriteLine(division);
                    break;

                default : Console.WriteLine("Detta alternativet finns inte.");
                    break;


            }
            Console.ReadKey();
        }
    }
}
