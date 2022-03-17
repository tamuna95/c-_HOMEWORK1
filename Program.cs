using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double y = 0.000745;
            //String x = "I am a first year student at Gau";
            //Char a = 'A';
            //Char b = '?';
            //Boolean ax = false;
            //short s1 = -3275;

            //savarjisho11

            //Console.Write("Enter a variables for the formula");
            //double a1 = Convert.ToDouble(Console.ReadLine());
            //double b1 = Convert.ToDouble(Console.ReadLine());
            //double h = Convert.ToDouble(Console.ReadLine());
            //double area = (a1 + b1) / h;
            //Console.Write(area);

            //savarjisho 10
            //Console.Write("Enter the side of the square");
            //double side = Convert.ToDouble(Console.ReadLine());
            //double s = side * side;
            //Console.Write(s);
            //double p = 4 * side;
            //Console.Write(p);

            //savarjisho 13
            //Console.Write("Enter the numbers");
            //int numb1 = Convert.ToInt32(Console.ReadLine());
            //int numb2 = Convert.ToInt32(Console.ReadLine());
            //int numb3 = Convert.ToInt32(Console.ReadLine());
            //int result = numb1 * numb2 * numb3;
            //Console.Write(Math.Sqrt(result));

            //savarjisho 12
            //Console.Write("Enter the numbers");
            //double numb4 = Convert.ToInt32(Console.ReadLine());
            //double numb5 = Convert.ToInt32(Console.ReadLine());
            //double numb6 = Convert.ToInt32(Console.ReadLine());
            //double numb7 = Convert.ToInt32(Console.ReadLine());
            //double average = (numb4 + numb5 + numb6 + numb7) / 4;
            //Console.Write(average);

            //savarjisho 9
            //Console.Write("Enter the base and the height");
            //double a = Convert.ToDouble(Console.ReadLine());
            //double h = Convert.ToDouble(Console.ReadLine());
            //double area = a * h / 2;
            //Console.Write(area);

            //savarjisho 8

            //Console.Write("Enter the sides of the rectangular triange");
            //int side1 = Convert.ToInt32(Console.ReadLine());
            //int side2 = Convert.ToInt32(Console.ReadLine());
            //int side3 = Convert.ToInt32(Console.ReadLine());
            //if (side1*side1 +side2*side2 > side3*side3 || side1*side1 +side3*side3 >side2*side2 || side2*side2 +side3*side3 >side1*side1) {
            //    Console.Write("Exist");
            //}
            //else
            //{
            //    Console.Write("doesn't exist");
            //}

            //savarjisho 7
            Console.Write("Enter the sides of the  triange");
            double side1 = Convert.ToDouble(Console.ReadLine());
            double side2 = Convert.ToDouble(Console.ReadLine());
            double side3 = Convert.ToDouble(Console.ReadLine());
            if (side1 +side2 >= side3 & side1 + side3 >= side2 & side2 +side3 >= side1)
            {

                Console.Write("Exist");
            }

            else
            {
                Console.Write("Doesn't exist");
            }
        }
    }
}
