using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose which operation you would like to make: +, - , * , /");

            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine("You choose plus");
                    break;

                case "-":
                    Console.WriteLine("You choose minus");
                    break;

                case "*":
                    Console.WriteLine("You choose multiply");
                    break;

                case "/":
                    Console.WriteLine("You choose divide");
                    break;
                default:
                    Console.WriteLine("Choose a proper operation, please!");
                    break;
            }


        }
      
    }
}