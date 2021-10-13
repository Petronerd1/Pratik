using System;

namespace DoğumTarihiHangiAya
{
    class Program
    {
        static void Main(string[] args)
        {
            string tarih;
            string[] parcalar;
            Console.WriteLine("Tarih Giriniz = ");
            tarih = Console.ReadLine();
            parcalar = tarih.Split('.');
            if (int.Parse(parcalar[1]) == 1)
                Console.WriteLine("DOĞDUĞUNUZ AY OCAK");
            if (int.Parse(parcalar[1]) == 2)
                Console.WriteLine("DOĞDUĞUNUZ AY ŞUBAT");
            if (int.Parse(parcalar[1]) == 3)
                Console.WriteLine("DOĞDUĞUNUZ AY MART");
            if (int.Parse(parcalar[1]) == 4)
                Console.WriteLine("DOĞDUĞUNUZ AY NİSAN");
            if (int.Parse(parcalar[1]) == 5)
                Console.WriteLine("DOĞDUĞUNUZ AY MAYIS");
            if (int.Parse(parcalar[1]) == 6)
                Console.WriteLine("DOĞDUĞUNUZ AY HAZİRAN");
            if (int.Parse(parcalar[1]) == 7)
                Console.WriteLine("DOĞDUĞUNUZ AY TEMMUZ");
            if (int.Parse(parcalar[1]) == 8)
                Console.WriteLine("DOĞDUĞUNUZ AY AĞUSTOS");
            if (int.Parse(parcalar[1]) == 9)
                Console.WriteLine("DOĞDUĞUNUZ AY EYLÜL");
            if (int.Parse(parcalar[1]) == 10)
                Console.WriteLine("DOĞDUĞUNUZ AY EKİM");
            if (int.Parse(parcalar[1]) == 11)
                Console.WriteLine("DOĞDUĞUNUZ AY KASIM");
            if (int.Parse(parcalar[1]) == 12)
                Console.WriteLine("DOĞDUĞUNUZ AY ARALIK");
            Console.ReadKey();



        }
    }
}
