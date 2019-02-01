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
                string s = $"Navn: {kaffe.Navn()}    Styrke: {kaffe.Styrke()}    Pris: {kaffe.Pris()}kr.     Rabat: {kaffe.Rabat}%";
                if (kaffe is Imælk kaffeMælk)
                {
                    s += $"      Mælk: {kaffeMælk.MlMælk()}ml";
                }

                Console.WriteLine(s);
            }
            


            Console.ReadLine();
        }
    }
}
