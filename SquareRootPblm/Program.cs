using System;

namespace SquareRootPblm
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte t = Byte.Parse(Console.ReadLine());

            //for (byte i = 0; i < t; i++)
            //{
            //    ushort n = UInt16.Parse(Console.ReadLine());
            //    byte ans = Convert.ToByte(Math.Floor(Math.Sqrt(n)));
            //    Console.WriteLine(ans);
            //}
            int t = int.Parse(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int ans = Convert.ToInt32(Math.Floor(Math.Sqrt(n)));
                Console.WriteLine(ans);
            }
        }
    }
}
