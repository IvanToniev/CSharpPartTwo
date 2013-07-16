using System;

namespace ReverseAverageLinear
{
    class ReverseAverageLinear
    {
        static void Reverse(int number)
        {
            int nextNum = number;
            int reminder = 0;
            int reversed = 0;
            if (number < 0)
            {
                Console.WriteLine("Enter a positive number.");
            }
            else
            {
                while (nextNum > 0)
                {
                    reminder = nextNum % 10;
                    reversed = reversed * 10 + reminder;
                    nextNum = nextNum / 10;
                }
                Console.WriteLine(reversed);
            }
        }

        static void Average(int[] arr)
        {
            double seqSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                seqSum += arr[i];
            }

            double average = seqSum / 2;
            Console.WriteLine(average);
        }

        static void SolveLinear(double a,double b)
        {
            double answer = (-b) /a;
            Console.WriteLine(answer);
        }

        static void Main(string[] args)
        {      
            Console.WriteLine("Choose a number:");
            Console.WriteLine("1.If you want to reverse a number.");
            Console.WriteLine("2.If you want the average of a sequence.");
            Console.WriteLine("3.If you want to solve a linear equation.");
            int num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                {
                    Console.WriteLine("Enter your number");
                    int someNum = int.Parse(Console.ReadLine());
                    Reverse(someNum);
                    break;
                }

                case 2:
                {
                    Console.WriteLine("How long is your sequence?");
                    int l = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter your sequence.");
                    int[] someArr = new int[l];
                    for (int i = 0; i < someArr.Length; i++)
                    {
                        someArr[i] = int.Parse(Console.ReadLine());
                    }
                    Average(someArr);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("enter the a and b of your linear equation.");

                    double a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());

                    if (a == 0)
                    {
                        Console.WriteLine("Your \"a\" shouldn't be 0.");
                        break;
                    }
                    else
                    {
                        SolveLinear(a, b);
                        break;
                    }
                }
                default: { Console.WriteLine("Invalid choice!"); break; }
            }
        }
    }
}

