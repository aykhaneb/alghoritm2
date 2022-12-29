using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //task no 1;

            //int gun = int.Parse(Console.ReadLine());
            //int il,ay,yas;
            //il = gun / 12;
            //ay = gun % 12;
            //Console.WriteLine($"{il} il {ay} ay");

            //task no2;

            int n = int.Parse(Console.ReadLine());
            int r, count=0;
            while (n > 9)
            {
                r = n % 10;
                n = n / 10;

                if (r == 0)
                {
                    count++;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
