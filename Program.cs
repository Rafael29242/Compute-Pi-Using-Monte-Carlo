using System;

namespace Lab5MonteCarloPi   //Console called MonteCarloPi
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Random randoNum = new System.Random();
            //
            //double x = randoNum.NextDouble();
            //
            //Console.WriteLine(x);
            //
            //double y = randoNum.NextDouble();
            //
            //Console.WriteLine(y);
            //
            //
            //double distance = Math.Sqrt((x * x) + (y * y));  // using pythagorean's theorem a^2+b^2=c^2
            //Console.WriteLine(distance);
            //
            //if (distance < 1)
            //{
            //    Console.WriteLine("\nThe point is inside the circle");
            //}
            //else
            //{
            //    Console.WriteLine("\nThe point is outside the circle");
            //}
            Random randomNumberGenerator = new Random();








            int j = 0;
            int k = 0;
            int iterations = 1;

            //do
            //{
            //    double x;
            //    double y;
            //    (x, y) = RandomXY(randomNumberGenerator);



            //    double hypotenuse = Math.Sqrt((x * x) + (y * y));
            //    Console.WriteLine(hypotenuse);
            //    if (hypotenuse > 1)
            //    {
            //        Console.WriteLine($"Hypotenuse was greater than 1: {j}");
            //        j++;
            //    }
            //    else if (hypotenuse < 1)
            //    {
            //        Console.WriteLine($"Hypotenuse was less than 1: {k}");
            //        k++;
            //    }
            //    i++;
            //} while (i <= 10);

            //Console.WriteLine($"\nWe have ran the process 10 times. Compiling is complete. \nHypotenuse was greater than 1: {j} \nHypotenuse was less than 1: {k}");



            //do
            //{
            //    double x;
            //    double y;
            //    (x, y) = RandomXY(randomNumberGenerator);



            //    double hypotenuse = Math.Sqrt((x * x) + (y * y));
            //    Console.WriteLine(hypotenuse);
            //    if (hypotenuse > 1)
            //    {
            //        Console.WriteLine($"Hypotenuse was greater than 1: {j}");
            //        j++;
            //    }
            //    else if (hypotenuse < 1)
            //    {
            //        Console.WriteLine($"Hypotenuse was less than 1: {k}");
            //        k++;
            //    }
            //    i++;
            //} while (i <= 100);

            //Console.WriteLine($"\nWe have ran the process 100 times. Compiling is complete. \nHypotenuse was greater than 1: {j} \nHypotenuse was less than 1: {k}");


            //do
            //{
            //    double x;
            //    double y;
            //    (x, y) = RandomXY(randomNumberGenerator);



            //    double hypotenuse = Math.Sqrt((x * x) + (y * y));
            //    Console.WriteLine(hypotenuse);
            //    if (hypotenuse > 1)
            //    {
            //        Console.WriteLine($"Hypotenuse was greater than 1: {j}");
            //        j++;
            //    }
            //    else if (hypotenuse < 1)
            //    {
            //        Console.WriteLine($"Hypotenuse was less than 1: {k}");
            //        k++;
            //    }
            //    i++;
            //} while (i <= 1000);

            //Console.WriteLine($"\nWe have ran the process 1000 times. Compiling is complete. \nHypotenuse was greater than 1: {j} \nHypotenuse was less than 1: {k}");

            

                double pumpkinPi = 4 * j / iterations;
                double differencePi = Math.PI - pumpkinPi;

                Console.WriteLine($"\nThe value of pi is {Math.PI}");
                Console.WriteLine($"The estimated value of pi is {pumpkinPi}");
                Console.WriteLine($"The difference between both these pi(s) are {differencePi}");
            

            do
            {
                double x;
                double y;
                (x, y) = RandomXY(randomNumberGenerator);



                double hypotenuse = Math.Sqrt((x * x) + (y * y));
                Console.WriteLine(hypotenuse);
                if (hypotenuse > 1)
                {
                    Console.WriteLine($"Hypotenuse was greater than 1: {j}");
                    j++;
                }
                else if (hypotenuse < 1)
                {
                    Console.WriteLine($"Hypotenuse was less than 1: {k}");
                    k++;
                }
                iterations++;
            } while (iterations <= 10000);



            Console.WriteLine($"\nWe have ran the process 10000 times. Compiling is complete. \nHypotenuse was greater than 1: {j} \nHypotenuse was less than 1: {k}");
        }



        static (double randomX, double randomY) RandomXY(Random randomPoint)
        {
            //Random randoNum2 = new Random();
            double x = randomPoint.NextDouble();
            double y = randomPoint.NextDouble();
            //double distance = Math.Sqrt((x * x) + (y * y));  
            //Console.WriteLine(distance);
            return (x, y);
        }

     // Questions:
//1) The value  is multiplied by 4 because there are 2 coordinates (X and Y) that can either be -1 or 1.
//2) I observe the the largest  number in the output when running my program.
//3) If I run the program multiple times with the same parameter, the output will change because both coordinates are being randomly generated between 0 and 1.
//4)1,000
//5)The estimated value of Pi is higher when the number of iterations is also high.
//6) Monte Carlo is a technique used to understand different factors/risks within forecast models.




    }
}