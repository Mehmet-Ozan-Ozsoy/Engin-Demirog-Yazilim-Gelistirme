using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, double> krediFaiz = new MyDictionary<string, double>();
            krediFaiz.Add("Konut Kredisi", 1.36);
            krediFaiz.Add("İhtiyaç Kredisi", 1.64);
            krediFaiz.Add("Taşıt Kredisi", 1.72);

            Console.Write("[1]Konut Kredisi\n[2]İhtiyaç Kredisi\n[3]Taşıt Kredisi\n\nLütfen kredi seçiminizi yapınız: ");
            int secim = int.Parse(Console.ReadLine());

            while (secim>0 && secim<4)
            {
                Console.WriteLine(krediFaiz.Key[secim - 1] + " -----> %" + krediFaiz.Value[secim - 1]);

                Console.Write("Lütfen kredi seçiminizi yapınız: ");
                secim = int.Parse(Console.ReadLine());
            }
        }
    }
}