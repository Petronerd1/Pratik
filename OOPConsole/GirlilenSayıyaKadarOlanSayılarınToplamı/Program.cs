using System;

namespace GirlilenSayıyaKadarOlanSayılarınToplamı
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int toplam = 0;
            Console.WriteLine("N Sayısını Girin:");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                toplam += n;
                n--;
            }
            Console.WriteLine("Sayıların Toplamı {0}",toplam);
            Console.ReadLine();
        }
    }
}
