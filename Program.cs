using System;

namespace Week6Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Morning!");
            HelloUser();
            SumAnswer();
        }
        public static void HelloUser()
        {
            Console.WriteLine("What's your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");
        }

        public static void SumAnswer()
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());
            int sum = firstNumber + secondNumber;
            Console.WriteLine($"Answer is {sum}");
        }
    }
}
