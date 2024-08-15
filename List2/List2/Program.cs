using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kahveListesi = new List<string>();

        // Kullanıcıdan 5 kahve ismi alalım
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string kahveIsmi = Console.ReadLine();
            kahveListesi.Add(kahveIsmi);
        }

        // foreach döngüsü ile listeyi yazdırma
        Console.WriteLine("\nGirilen kahve isimleri:");
        foreach (string kahve in kahveListesi)
        {
            Console.WriteLine(kahve);
        }
    }
}
