using System;

namespace UcgenAlanHesaplama
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double taban, yükseklik, alan;
            Console.WriteLine("Üçgenin Tabanını Giriniz");
            taban = double.Parse(Console.ReadLine());
            Console.WriteLine("Üçgenin Yüksekliğini Giriniz");
            yükseklik = double.Parse(Console.ReadLine());
            alan = (taban*yükseklik)/2;
            Console.WriteLine("Sonuç={0}", alan);
            Console.ReadKey();
            
        }
    }
}
