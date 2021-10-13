using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdn = new Random();
            int[] rast = new int[6];
            for (int i = 0;i < 6; i++) 
            {
                rast[i] = rdn.Next(1, 50);
            }
            Array.Sort(rast);
            Console.WriteLine("Sayısal Rakamları");
            Console.WriteLine(".................");
            for(int i = 0; i < 6;i++)
            {
                Console.WriteLine(rast[i] + "");
            }
            Console.ReadLine();
        }
    }
}
