using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBrackets
{
    class CheckBrackets
    {
        static void Main()
        {
            Console.WriteLine("Enter your expression.");
            string expression = Console.ReadLine();
            int firstCounter = 0;

            for (int i = 0; i < expression.Length && firstCounter >= 0; i++)
            {
                if (expression[i] == '(')
                {
                    firstCounter++;
                }
                if (expression[i] == ')')
                {
                    firstCounter--;
                }
            }
            if (firstCounter < 0)
            {
                Console.WriteLine("Bad expression.");
            }
            else if (firstCounter == 0 && expression.IndexOf(')') < expression.IndexOf('('))
            {
                Console.WriteLine("Bad expression.");
            }
            else if (firstCounter == 0 && expression.IndexOf(')') > expression.IndexOf('('))
            {
                Console.WriteLine("Right expression.");
            }
            else if (firstCounter > 0)
            {
                Console.WriteLine("Bad expression.");
            }
        }

    }

}
