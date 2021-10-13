using System;

namespace UsAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            double sayi, us, sonuc;
            Console.WriteLine("Üssü alıncak sayıyı giriniz:");
            sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Üssü giriniz");
            us = int.Parse(Console.ReadLine());
            sonuc = Math.Pow(sayi, us);
            Console.WriteLine("Sonuç= {0}", sonuc);
            Console.ReadKey();
        }
    }
}
