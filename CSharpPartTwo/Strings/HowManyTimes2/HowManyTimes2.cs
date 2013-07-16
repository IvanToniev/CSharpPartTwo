using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowManyTimes2
{
    class HowManyTimes2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string.");
            string str = Console.ReadLine();
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string[] split = str.Split(' ','\n','.',',',':',';');

            for (int i = 0; i < split.Length; i++)
            {
                Console.WriteLine(split[i]);
                if (dic.ContainsKey(split[i]))
                {
                    dic[split[i]]++;
                }
                else
                {
                    dic.Add(split[i],1);
                }
            }
            foreach (var word in dic)
            {
                Console.WriteLine("{0} - {1,3} times found",word.Key,word.Value);
            }
            Console.WriteLine();
        }
    }
}
