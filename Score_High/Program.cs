using System;
using System.Linq;

namespace Score_High
{
    class Program
    {
        static void Main(string[] args)
        {
            var T = int.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                var q = Console.ReadLine();
                var max = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).Max();
                Console.WriteLine(max);
            }
        }
    }
}
