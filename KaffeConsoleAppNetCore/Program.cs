using kaffe;
using System;

namespace KaffeConsoleAppNetCore
{
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<Kaffe> kaffeList = new List<Kaffe>() {new Cortado(), new FlatWhite(), new Latte(), new SortKaffe()};
            foreach (var kaffe in kaffeList)
            {
                Console.WriteLine($"Navn: {kaffe.ToString()}    Styrke: {kaffe.Styrke()}    Pris: {kaffe.Pris()}");
            }


            Console.ReadLine();
        }
    }
}
