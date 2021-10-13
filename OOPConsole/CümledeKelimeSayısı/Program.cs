using System;

namespace CümledeKelimeSayısı
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin;
            Console.WriteLine("Metni Girin :");
            metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Kelime Sayısı :"+kelimeler.Length);
            foreach(string kelime in kelimeler)
            {
                Console.WriteLine(kelime); 
            }
            Console.ReadKey();

        }
    }
}
