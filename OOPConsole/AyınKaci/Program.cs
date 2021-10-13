using System;

namespace AyınKaci
{
    class Program
    {
        static int AyinKaci()
        {
            return DateTime.Now.Day;
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AyinKaci());
            Console.ReadLine();
        }
    }
}
