using System;
using System.IO;

namespace OddLines
{
    class OddLines
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"c:\users\ivan\downloads\sometext.txt");
            using (reader)
            {
                int i = 1;
                for (string inParts; (inParts = reader.ReadLine()) != null; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine(inParts);
                        inParts = reader.ReadLine();
                    }
                }
            }
        }
    }
}
