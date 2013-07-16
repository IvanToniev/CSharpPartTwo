using System;

namespace TriangeSurface
{
    class TriangleSurface
    {
        static void SideHeight(double a, double ha)
        {
            double area = a * ha / 2;
            Console.WriteLine("The area is:{0}",area);
        }

        static void ThreeSides(double a, double b, double c)
        {
            double p=(a+b+c)/2;
            double area=Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine("The area is:{0}", area);
        }

        static void TwoSidesAngle(double a,double b,double gama)
        { 
            double area=(a*b*Math.Sin(gama*Math.PI/180))/2;
            Console.WriteLine("The area is:{0}", area);      
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose a number:");
            Console.WriteLine("1.Area by a given side and height.");
            Console.WriteLine("2.Area by three given sides");
            Console.WriteLine("3.Area by 2 given sides and an angle.");
            int n=int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                {
                    Console.WriteLine("Enter side and height.");
                    double sideOne = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    SideHeight(sideOne,height);
                    break;                
                }
                case 2:
                {
                    Console.WriteLine("Enter the 3 sides.");
                    double sideOne = double.Parse(Console.ReadLine());
                    double sideTwo = double.Parse(Console.ReadLine());
                    double sideThree = double.Parse(Console.ReadLine());
                    ThreeSides(sideOne,sideTwo,sideThree);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Enter two side and an angle.");
                    double sideOne = double.Parse(Console.ReadLine());
                    double sideTwo = double.Parse(Console.ReadLine());
                    double angle = double.Parse(Console.ReadLine());
                    TwoSidesAngle(sideOne,sideTwo,angle);
                    break;
                }
                default: break;
            }
        }
    }
}
