using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironmentGoLex
{
    static class NumberGenerator
    {
        public static void NumGenerator() 
        {
            Random random = new Random();

            int firstNum, secondNum;

            Console.WriteLine("Welcome to the number generator, to start the program, enter a minimal value and a maximum value");
            Console.WriteLine("1) First Number");
            firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2) Second Number");
            secondNum = Convert.ToInt32(Console.ReadLine());
            while(secondNum < firstNum) 
            {
                Console.WriteLine("Your second number is inferior to your first number, type a bigger number");
                secondNum = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < secondNum; i++)
            {
                Console.WriteLine(NextLetter(random, firstNum, secondNum) + " ");
            }
            Console.ReadKey();
        }
        public static int NextLetter(this Random r, int min, int max)
        {
            int number;
            number = r.Next(min, max);
            return number;
        }
    }
}
