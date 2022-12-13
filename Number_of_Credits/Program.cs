using System;

namespace Number_of_Credits
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < cases; i++)
            {
                string[] cal = Console.ReadLine().Split(" ");
                int first = Convert.ToInt32(cal[0]);
                int second = Convert.ToInt32(cal[1]);
                int theird = Convert.ToInt32(cal[2]);
                int total = (first * 4) + (second * 2) + (theird * 0);
                Console.WriteLine(total);
            }
            Console.ReadKey();
        }
    }
}
