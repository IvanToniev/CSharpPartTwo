using System;

namespace Randoms
{
    class Randoms
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}",rnd.Next(100,201));
            }
        }
    }
}
