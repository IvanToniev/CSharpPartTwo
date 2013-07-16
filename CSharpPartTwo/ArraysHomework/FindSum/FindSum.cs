using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSum
{
    class FindSum
    {
        static void Main(string[] args)
        {
            int s = int.Parse(Console.ReadLine());
            int[] myArray = { 4, 3, 1, 4, 2, 5, 8 };
            string sequence = "";
            StringBuilder sequenceBuild = new StringBuilder();
            for (int i = 0; i < myArray.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < myArray.Length; j++)
                {
                    sum = sum + myArray[j];
                    sequenceBuild.AppendFormat("{0}, ", myArray[j]);

                    if (sum > s)
                    {
                        sequenceBuild.Clear();
                        sum = 0;
                        break;
                    }
                    if (sum == s)
                    {
                        sequence = sequenceBuild.ToString();
                        Console.WriteLine("This sequence has the sum of {0} : {1}", s, sequence);
                    }
                }
            }

        }
    }
}
