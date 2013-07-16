using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Indices
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            string[] split = input.Split(' ');
            int[] arr = new int[split.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(split[i]);
            }
            int current = 0;
            int start = 0;
            List<int> visited = new List<int>();
            bool cyc = false;
            while (current < n)
            {
                if (visited.Contains(current))
                {
                    start = arr[current];
                    cyc = true;
                    break;
                }               
                   
                 visited.Add(current);
                 current = arr[current];                                              
            }
            if (cyc==true)
            {
                for (int i = 0; i < visited.Count; i++)
                {
                    if (i == 0)
                    {
                        sb.Append(visited[i]);
                    }
                    else
                    {
                        sb.Append(" " + visited[i]);
                    }
                }
                Console.WriteLine(sb.ToString().Substring(0,input.IndexOf(start.ToString())-1) + '(' + sb.ToString().Substring(input.IndexOf(start.ToString())) + ')');
            }
            if(cyc==false)
            {
                for (int i = 0; i < visited.Count; i++)
                {
                    if (i == 0)
                    {
                        sb.Append(visited[i]);
                    }
                    else
                    {
                        sb.Append(" " + visited[i]);
                    }
                }
                Console.WriteLine(sb.ToString());
            }
            
        }
    }
}
