using System;

namespace TMS_Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            while (true)
            {
                Console.Clear();
                double FirstValue, SecondValue, result;
                string typeOperation, lineForValue;

                Console.WriteLine("Введите число: ");
                lineForValue = Console.ReadLine();
                var lineVal = double.TryParse(lineForValue, out FirstValue);
                if (lineVal == true)
                {



                    Console.WriteLine("Операция над числами: ");
                    typeOperation = Console.ReadLine();



                    switch (typeOperation)
                    {
                        case "+":
                            Console.WriteLine("Введите второе число: ");
                            lineForValue = Console.ReadLine();
                            var lineValue = double.TryParse(lineForValue, out SecondValue);

                            if (lineValue == true)
                            {
                                result = FirstValue + SecondValue;
                                Console.WriteLine("Сумма: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Значения введены некорректно!");
                            }
                            break;


                        case "-":
                            Console.WriteLine("Введите второе число: ");
                            lineForValue = Console.ReadLine();
                            var lineValue2 = double.TryParse(lineForValue, out SecondValue);

                            if (lineValue2 == true)
                            {
                                result = FirstValue - SecondValue;
                                Console.WriteLine("Вычитание: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Значения введены некорректно!");
                            }
                            break;


                        case "/":
                            Console.WriteLine("Введите второе число: ");
                            lineForValue = Console.ReadLine();
                            var lineValue3 = double.TryParse(lineForValue, out SecondValue);

                            if (lineValue3 == true)
                            {
                                result = FirstValue / SecondValue;
                                Console.WriteLine("Деление: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Значения введены некорректно!");
                            }
                            break;


                        case "*":
                            Console.WriteLine("Введите второе число: ");
                            lineForValue = Console.ReadLine();
                            var lineValue4 = double.TryParse(lineForValue, out SecondValue);

                            if (lineValue4 == true)
                            {
                                result = FirstValue * SecondValue;
                                Console.WriteLine("Умножение: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Значения введены некорректно!");
                            }
                            break;


                        case "%":
                            Console.WriteLine("Введите второе число: ");
                            lineForValue = Console.ReadLine();
                            var lineValue5 = double.TryParse(lineForValue, out SecondValue);

                            if (lineValue5 == true)
                            {
                                result = FirstValue * SecondValue / 100;
                                Console.WriteLine("Процент от числа: " + result);
                            }
                            else
                            {
                                Console.WriteLine("Значения введены некорректно!");
                            }
                            break;


                        case "//":
                            result = Math.Sqrt(FirstValue);
                            Console.WriteLine("Квадратный корень: " + result);
                            break;

                        default:
                            Console.WriteLine("Невозможный оператор!");
                            break;


                    }
                    Console.WriteLine("Желаете продолжить? - Нажмите Enter!");
                }
                else
                {
                    Console.WriteLine("Значения введены некорректно!");
                }
                Console.ReadLine();
            }

        }

    }
}
