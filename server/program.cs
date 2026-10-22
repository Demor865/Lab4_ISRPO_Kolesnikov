using System;

namespace server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!");
            Console.WriteLine("ФИО: Колесников Владислав Александрович");
            Console.WriteLine("");

            Console.WriteLine("Группа: ИСП-241");
            Console.WriteLine("Текущая дата - 22.10");
            Console.WriteLine("");

            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("");
                Console.WriteLine("Меню:");
                Console.WriteLine("1 — Показать ФИО");
                Console.WriteLine("2 — Показать группу");
                Console.WriteLine("3 — Показать дату");
                Console.WriteLine("4 — Выход");
                Console.Write("Выберите пункт: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Колесников Владислав Александрович");
                        break;
                    case "2":
                        Console.WriteLine("Группа: ИСП-241");
                        break;
                    case "3":
                        Console.WriteLine("Дата - 22.10");
                        break;
                    case "4":
                        Console.WriteLine("Выход из программы...");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}