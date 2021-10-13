using System;

namespace Maas
{
    class Program
    {
        static void Main(string[] args)
        {
            double maas = 1000;
            double maas1, maas2, maas3, maas4, maas5;
            maas1 = maas + maas * 0.15;
            maas2 = maas1 + maas1 * 0.15;
            maas3 = maas2 + maas2 * 0.15;
            maas4 = maas3 + maas3 * 0.15;
            maas5 = maas4 + maas4 * 0.15;

            Console.WriteLine("Şu anki Maaş:"+maas);
            Console.WriteLine("1 Yıl Sonra:"+maas1);
            Console.WriteLine("2 Yıl Sonra:" + maas2);
            Console.WriteLine("3 Yıl Sonra:" + maas3);
            Console.WriteLine("4 Yıl Sonra:" + maas4);
            Console.WriteLine("5 Yıl Sonra:" + maas5);
            Console.ReadKey();
        }
    }
}
