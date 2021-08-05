using System;


namespace TMS_Lesson_2._1
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                int FiveWorksDays = 5;
                int PozitionOnWeek;



                Console.WriteLine("Укажите день недели в сокращенной форме: ");
                string Day;
                Day = Console.ReadLine();


                switch (Day)
                {
                    case "Mon":
                        {

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.White;


                            Console.WriteLine("Monday = Понедельник");
                            PozitionOnWeek = 1;
                            Console.WriteLine("Порядковый номер: " + PozitionOnWeek);
                            Console.WriteLine("Дней до выходного: " + (FiveWorksDays));

                            if (DateTime.Now.DayOfWeek.ToString() == "Monday")
                            {
                                Console.WriteLine("Сегодня Понедельник!");
                            }

                            Console.WriteLine("Нажмите, чтобы начать сначала...");
                        }
                        break;

                    case "Tues":
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.WriteLine("Tuesday = Вторник");
                            PozitionOnWeek = 2;
                            Console.WriteLine("Порядковый номер: " + PozitionOnWeek);
                            Console.WriteLine("Дней до выходного: " + (FiveWorksDays - PozitionOnWeek + 1));

                            if (DateTime.Now.DayOfWeek.ToString() == "Tuesday")
                            {
                                Console.WriteLine("Сегодня Вторник!");
                            }

                            Console.WriteLine("Нажмите, чтобы начать сначала...");
                        }
                        break;

                    case "Wed":
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;


                            Console.WriteLine("Wednesday = Среда");
                            PozitionOnWeek = 3;
                            Console.WriteLine("Порядковый номер: " + PozitionOnWeek);
                            Console.WriteLine("Дней до выходного: " + (FiveWorksDays - PozitionOnWeek + 1));

                            if (DateTime.Now.DayOfWeek.ToString() == "Wednesday")
                            {
                                Console.WriteLine("Сегодня Среда!");
                            }

                            Console.WriteLine("Нажмите, чтобы начать сначала...");
                        }
                        break;

                    case "Thur":
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Blue;

                            Console.WriteLine("Thursday = четверг");
                            PozitionOnWeek = 4;
                            Console.WriteLine("Порядковый номер: " + PozitionOnWeek);
                            Console.WriteLine("Дней до выходного: " + (FiveWorksDays - PozitionOnWeek + 1));

                            if (DateTime.Now.DayOfWeek.ToString() == "Thursday")
                            {
                                Console.WriteLine("Сегодня Четверг!");
                            }

                            Console.WriteLine("Нажмите, чтобы начать сначала...");
                        }
                        break;

                    case "Fri":
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.BackgroundColor = ConsoleColor.Magenta;

                            Console.WriteLine("Friday = Пятница");
                            PozitionOnWeek = 5;
                            Console.WriteLine("Порядковый номер: " + PozitionOnWeek);
                            Console.WriteLine("Дней до выходного: " + (FiveWorksDays - PozitionOnWeek + 1));

                            if (DateTime.Now.DayOfWeek.ToString() == "Friday")
                            {
                                Console.WriteLine("Сегодня Пятница!");
                            }

                            Console.WriteLine("Нажмите, чтобы начать сначала...");
                        }
                        break;

                    case "Sat":
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.DarkRed;

                            Console.WriteLine("Saturday = Суббота");
                            PozitionOnWeek = 6;
                            Console.WriteLine("Порядковый номер: " + PozitionOnWeek);
                            Console.WriteLine("Дней до выходного: " + (FiveWorksDays - PozitionOnWeek + 1) + " - Сегодня выходной");

                            if (DateTime.Now.DayOfWeek.ToString() == "Saturday")
                            {
                                Console.WriteLine("Сегодня Суббота!");
                            }

                            Console.WriteLine("Нажмите, чтобы начать сначала...");
                        }
                        break;

                    case "Sun":
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;

                            Console.WriteLine("Sunday = Воскресенье");
                            PozitionOnWeek = 7;
                            Console.WriteLine("Порядковый номер: " + PozitionOnWeek);
                            Console.WriteLine("Дней до выходного: " + (FiveWorksDays - PozitionOnWeek + 2) + " - Сегодня выходной");

                            if (DateTime.Now.DayOfWeek.ToString() == "Sunday")
                            {
                                Console.WriteLine("Сегодня Воскресенье!");
                            }

                            Console.WriteLine("Нажмите, чтобы начать сначала...");
                        }
                        break;

                    default:
                        {
                            Console.WriteLine("Такого дня не существует или данные введены некорректно!");
                        }
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
