using System;

namespace UnitTest_Pornthita
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //int score;
            //Console.Write("Enter your score = ");
            //score = int.Parse(Console.ReadLine());
            //calGeade(score); 


            //4
            //    double x1, y1, x2, y2, result;
            //Console.Write("P1(x1) = ");
            //x1 = double.Parse(Console.ReadLine());
            //Console.Write("P1(y1) = ");
            //y1 = double.Parse(Console.ReadLine());
            //Console.Write("P1(x2) = ");
            //x2 = double.Parse(Console.ReadLine());
            //Console.Write("P1(y2) = ");
            //y2 = double.Parse(Console.ReadLine());

            //result = distanceXY(x1, y1, x2, y2);
            //Console.WriteLine("result = {0:0.00}", result);


            //3
            //int num, result;
            //Console.Write("factorial = ");
            //num = int.Parse(Console.ReadLine());
            //result = factorial(num);
            //Console.WriteLine("Result = {0}", result);

            string text;
            bool result;
            Console.Write("Insert your password = ");
            text = Console.ReadLine();
            result = checkPass(text);
            Console.WriteLine(result);


        }
        static void calGeade(int score)
        {
            if(score >= 80)
            {
                Console.WriteLine("A");
            }
            else if(score >= 75)
            {
                Console.WriteLine("B+");
            }
            else if (score >= 70)
            {
                Console.WriteLine("B");
            }
            else if (score >= 65)
            {
                Console.WriteLine("C+");
            }
            else if (score >= 60)
            {
                Console.WriteLine("C");
            }
            else if (score >= 55)
            {
                Console.WriteLine("D+");
            }
            else if (score >= 50)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }

        static int factorial(int x)
        {
            int num = 1;
            for(int i = 1; i <= x; i++)
            {
                num = num * i;
            }
            return num;
        }
        static double distanceXY(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        static bool checkPass(string text)
        {
            int cT;
            double cS;
            bool checkNum, checkText;
            bool result = false;
            if (text.Length >= 8)
            {
                checkNum = int.TryParse(text, out cT);
                checkText = Double.TryParse(text, out cS);
                if (checkNum)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            }
            else if (text.Length < 8)
            {
                result = false;
            }

            return result;
        }
    }
}
