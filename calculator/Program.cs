using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double FirstValue, SecondValue;
                string action;
                try
                {
                    Console.WriteLine("Введите число 1");
                    FirstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    SecondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Только числа!");
                    Console.ReadLine();
                    continue;
                }
            

            Console.WriteLine("Выберите операцию: '+' '-' '/' '*'");
            action = Console.ReadLine();
            
                
                switch (action)
                {
                    case "+":
                        Console.WriteLine(FirstValue + SecondValue);
                        break;
                    case "-":
                        Console.WriteLine(FirstValue - SecondValue);
                        break;

                    case "/":
                        Console.WriteLine(FirstValue / SecondValue);
                        break;

                    case "*":
                        Console.WriteLine(FirstValue * SecondValue);
                        break;
                    

                    default:
                        Console.WriteLine("Ошибка, неизвестная операция");
                        break;
                };

                Console.ReadLine();
            }
        }
    }
}
