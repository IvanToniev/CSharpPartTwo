
using System;
using System.IO;

namespace Concatenate
{
    class Concatenate
    {
        static void Main(string[] args)
        {
            StreamWriter comboFile = new StreamWriter(@"c:\users\ivan\downloads\combotext.txt");
            using (comboFile)
            {
                StreamReader fileOne = new StreamReader(@"c:\users\ivan\downloads\sometext.txt");
                using (fileOne)
                {
                    string a = fileOne.ReadToEnd();
                    comboFile.WriteLine(a);

                }
                StreamReader fileTwo = new StreamReader(@"c:\users\ivan\downloads\sometext2.txt");
                using (fileTwo)
                {
                    string b = fileTwo.ReadToEnd();
                    comboFile.WriteLine(b);
                }

            }

        }
    }
}