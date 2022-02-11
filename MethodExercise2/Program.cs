using System;

namespace MethodExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Human! Looking for help with math? I can do that for you! Enter a whole numbers, please.");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the second number?");
            int num2 = int.Parse(Console.ReadLine());
            int sum = Sum(num1, num2);
            int multiplication = Multiplication(num1, num2);
            int division = Division(num1, num2);
            int substraction = Substraction(num1, num2);
            
            Console.WriteLine($"Result of Sum: {sum}.");
            Console.WriteLine();
            Console.WriteLine($"Result of Multiplication: {multiplication}.");
            Console.WriteLine();
            Console.WriteLine($"Result of Division: {division}.");
            Console.WriteLine();
            Console.WriteLine($"Result of Substraction: {substraction}.");
            Console.WriteLine();
         }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Substraction(int num1, int num2)
        {
            return num1 - num2;
        }

    }
}



