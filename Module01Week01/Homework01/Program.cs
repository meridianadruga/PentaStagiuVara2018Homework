using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int r = rng.Next(0, 100);

            Console.WriteLine("Welcome to guess the number game! I will choose a number between 0 and 100 and you will have to guess it.");
            Console.WriteLine("What is the number you think I chose?");

            int x = -1;

            while (x != r)
            {
                string str = Console.ReadLine();
                x = int.Parse(str);

                if (x > r)

                    Console.WriteLine("The number is higher than the number I chose!");

                else if (x < r)

                    Console.WriteLine("The number is lower than the number I chose! ");

            }

            Console.WriteLine("You're right! The number is" + x);




        }
    }
}
