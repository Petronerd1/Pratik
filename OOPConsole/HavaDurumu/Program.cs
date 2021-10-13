using System;

namespace SuSicakliği
{
    class Program
    {
        static void Main(string[] args)
        {
            int sicaklik;
            Console.WriteLine("Su sıcaklığı Giriniz");
            sicaklik = Convert.ToInt32(Console.ReadLine());
            if(sicaklik<10) { Console.WriteLine("Su buz halindedir");} else if(sicaklik>=0 && sicaklik<=100)
            {
                Console.WriteLine("Su sıvı haldedir.");
            }
            else
            {
                Console.WriteLine("Su buhar haldedir.");
            }
            Console.ReadKey();
        }
    }
}
