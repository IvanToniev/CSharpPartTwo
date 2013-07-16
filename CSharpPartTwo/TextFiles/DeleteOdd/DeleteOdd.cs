using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DeleteOdd
{
    class DeleteOdd
    {
        static List<string> ReadEvenLines()
        {
            int n = 1;
            List<string> lines = new List<string>();

            

            using (StreamReader input = new StreamReader("../../input.txt"))
                for (string line; (line = input.ReadLine()) != null; n++)
                {
                    if (n % 2 == 0) { lines.Add(line); }
                }
            return lines;
        }

        static void WriteLines(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter("../../input.txt"))
            {
                foreach (string line in lines)
                { output.WriteLine(line); }
            }
        }

        static void Main()
        {
            WriteLines(ReadEvenLines());
        }
    }
}
