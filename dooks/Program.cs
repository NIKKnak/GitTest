using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isOpen = true;
            string[,] books =
            {
                {"Пушкин" , "Лермонтов", "Есенин"},
                {"Мартин", "Шелл", " Тепляков" },
                {"Кинг","Лавкрафт","Стоккер" }


            };


            while (isOpen)
            {
                Console.SetCursorPosition(0, 20);
                Console.WriteLine("\nВесь список авторов\n");
                for (int i = 0; i < books.GetLength(0); i++)
                {
                    for (int j = 0; j < books.GetLength(1); j++)
                    {
                        Console.Write(books[i, j] + " | ");
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Библиотека");
                Console.WriteLine("\n1 - узнать имя автора по индексу книги." +
                                  "\n2 - найти книгу по автора." +
                                  "\n3 - выход ");
                Console.Write("Выберите пункт меню ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {

                    case 1:
                        int line, colum;
                        Console.Write("Введите номенр полки");
                        line = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.Write("Введите номер столбца");
                        colum = Convert.ToInt32(Console.ReadLine()) - 1;

                        Console.WriteLine("Это автор " + books[line, colum]);
                        break;
                    case 2:
                        string auter;
                        bool auterIsFound = false;
                        Console.Write("Введите автора ");
                        auter = Console.ReadLine();

                        for (int i = 0; i < books.GetLength(0); i++)
                        {
                            for (int j = 0; j < books.GetLength(1); j++)
                            {
                                if (auter.ToLower() == books[i, j].ToLower())
                                {
                                    Console.Write($"Автор {books[i, j]} находится по адресу полка {i + 1}, место {j + 1}");
                                    auterIsFound = true;
                                }
                            }
                        }
                        if (auterIsFound = true)
                        {
                            Console.WriteLine("Такого автора нет");
                        }
                        break;
                    case 3:
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Введена неверная команда.");
                        break;

                }

                if (isOpen)
                {
                    Console.WriteLine("\nНажмите любу. клавишу для продолжения...");
                }

                Console.ReadKey();
                Console.Clear();



            }



        }
    }
}
