using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Numbers();


            //OddNumbers();

            //IsEqualOrNot(2 , 4);


            //EvenOrOdd(11);

            //PositiveOrNegative(1);

            OldEnoughToVote(17);
        }


        public static void Numbers()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }


        public static void OddNumbers()
        {
            for (int a = 3; a <=999; a += 3)
            {
                Console.WriteLine(a);
            }
        }


        public static void IsEqualOrNot(int x, int y)
        {
            // return x == y;

            if (x == y)
            {
                Console.WriteLine("true");
            }


            else
            {
                Console.WriteLine("false");
                
            }       
        }



        public static void EvenOrOdd(int num)
        {
            if (num %2 == 0)
            {
                Console.WriteLine("even");
               
            }
            else
            {
                Console.WriteLine("odd");
                
                

            }

            

        }
        public static void PositiveOrNegative(int num1)
        {
            if (num1 > -0)
            {
                Console.WriteLine("positive");
            }

            else 
            {
                Console.WriteLine("negative");
            }

            
        }
        public static void OldEnoughToVote(int num2)
        {
            if (num2 > 18)
            {
                Console.WriteLine("def can vote");
            }
            else
            {
                Console.WriteLine("def cannot vote");
            }
        }
    }
}
