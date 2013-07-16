using System;


namespace Factoriels
{
    class FactorielsInRange
    {
        static void fact(int num)
        {
            int factoriel = 1;
            for (int i = 2; i < num+1; i++)
            {
                factoriel = i*factoriel;
            }
            Console.WriteLine(factoriel);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start of your range.");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end of your range.");
            int end = int.Parse(Console.ReadLine());
            for (int i = start; i < end+1; i++)
            {
                fact(i);
            }           
        }
    }
}
