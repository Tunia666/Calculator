using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Muin(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");

            // Запрос ввода первого числа
            Console.Write("Введите первое число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Запрос ввода оператора (+, -, *, /)
            Console.Write("Введите оператор (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            // Запрос ввода второго числа
            Console.Write("Введите второе число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            int result = 0;

            // Выполнение операции в зависимости от введенного оператора
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("Ошибка: деление на ноль!");
                    break;
                default:
                    Console.WriteLine("Ошибка: недопустимый оператор!");
                    break;
            }

            // Вывод результата
            Console.WriteLine($"Результат: {result}");

            Console.WriteLine("Спасибо за использование калькулятора!");
        }
    }
}
