using System;
using System.Collections.Generic;
using System.Linq;

namespace övning_list._5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> löner = new List<double>();

            Console.WriteLine("Skriv in dina senaste månadslöner (skriv 0 för att avsluta):");

            double lön = double.Parse(Console.ReadLine());

            while (lön != 0)
            {
                löner.Add(lön);
                lön = double.Parse(Console.ReadLine());
            }

            if (löner.Count > 0)
            {
                double medellön = löner.Average();
                Console.WriteLine($"Din medellön är: {medellön}");

                var sorteradeLöner = löner.OrderBy(x => x).ToList();
                double medianlön = Median(sorteradeLöner);
                Console.WriteLine($"Din medianlön är: {medianlön}");
            }
            else
            {
                Console.WriteLine("Inga löner angivna.");
            }
        }

        static double Median(List<double> list)
        {
            int count = list.Count;
            if (count % 2 == 0)
            {
                return (list[count / 2 - 1] + list[count / 2]) / 2;
            }
            else
            {
                return list[count / 2];
            }
        }
    }
}
