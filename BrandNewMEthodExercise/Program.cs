using System;

namespace BrandNewMEthodExercise
{
    
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hello - What is your first name?");
            var fullName = Console.ReadLine();

            Console.WriteLine($"Hi {fullName}. What is your favorite color?");
            var favcolor = Console.ReadLine();

            Console.WriteLine($"The color {favcolor} is such a beautiful color! Now, what is your favorite animal.");
            var favanimal = Console.ReadLine();

            Console.WriteLine($"That is a really good animal. If it's not to much can I ask you what your favorite band is.");
            var favband = Console.ReadLine();

            Console.WriteLine($"It was a dark and stormy night. " + $"The wind was blowing a such a high speed. " + $"{fullName} was traveling in his {favcolor} Honda Civic. " + $"He swerved out of control believing he hit his favorite animal, the {favanimal}, while listening to {favband}. " + $"But alas, there was nothing there.");


        }

        public static void MadLib()
        {
            Console.WriteLine(Add(2, 4));
            Console.WriteLine(Add(2, 4, 6));
            Console.WriteLine(Add(1, 1, 1, 1, 1));

            Console.WriteLine(Sub(4, 4));
            Console.WriteLine(Sub(6,2));
            Console.WriteLine(Sub(4, 1, 1, 1, 1));

            Console.WriteLine(Multiply(8, 4));
            Console.WriteLine(Multiply(5, 7));
            Console.WriteLine(Multiply(4,9));
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Add(params int[] nums)
        {
            var sum = 0;

            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;


        }

        public static int Sub(params int[] nums)
        {
            var sum = 0;

            foreach (var num in nums)
            {
                sum -= num;
            }
            return sum;
        }
        public static int Multiply(params int[] nums)
        {
            var product = 0;

            foreach (var num in nums)
            {
                product *= num;
            }
            return product;
        }

    }


}


