using System;
using System.IO;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            StreamReader fileTwo = new StreamReader(@"c:\users\ivan\downloads\sometext.txt");
            using (fileTwo)
            {
                int i = 1;
                string lines=fileTwo.ReadLine();
                while(lines!=null)
                {
                    Console.WriteLine("{0}.{1}",i,lines);
                    lines = fileTwo.ReadLine();
                    i++;
                }
            }
        }
    }
}
