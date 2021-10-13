using System;

namespace Ilk50AsalSayı
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 2;
            int sayac = 0;
            int sayac2 = 0;
            int sayac3 = 0;

            Console.WriteLine("İlk 50 asal sayı");
            Console.WriteLine(".................");
            while(true)
            {
                sayac = 0;
                if(sayac2 == 50)
                {
                    break;
                }
                for (int i = 2; i < sayi; i++)
                {
                    if(sayi % i == 0)
                        {
                            sayac++;
                            break;
                        }
               }
                if(sayac==0)
                {
                    sayac3++;
                    Console.WriteLine(sayi+"\t");
                    if(sayac3%10==0)
                    {
                        Console.WriteLine();
                    }
                    sayac2++;

                }
                sayi++;
            }
            Console.ReadKey();
        }
    }
}
