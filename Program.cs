using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("1. Игра \"Угадай число\"\r\n2. Таблица умножения\r\n3. Вывод делителей числа\n4. Завершить программу\n ");
            int p;
            
                do
                {
                Console.WriteLine(" \nВыберите номер программы: ");
                p = Convert.ToInt32(Console.ReadLine());
                if (p > 0 && p < 5)
                {
                    switch (p)
                    {
                        case 1:
                            Number();
                            break;
                        case 2: Console.WriteLine();
                            Mult();
                            break;
                        case 3: Console.WriteLine();
                            Div();
                            break;
                        case 4:
                            Console.WriteLine("Программа завершенна");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка. Введен неправильный номер программы. Повторите попытку ");
                }
            } while (p != 4);
            
           
        }
        static void Number()
        {
            Random rnd = new Random();
            int value = rnd.Next(1,100);
            int b;
            Console.WriteLine("Введите число от 1 до 100: ");
            do
            {
                b = int.Parse(Console.ReadLine());
                if (b > value)
                {
                    Console.WriteLine("меньше");
                }
                else if (b < value)
                {
                    Console.WriteLine("больше");
                }
                else
                {
                    Console.WriteLine("Правильно");
                }
            }while(b!= value);
        }

        static void Mult()
        {
            int a = 9;
            int b = 10;
            int[,] Matrix = new int[9, 10];
            for (int i = 1; i < a; i++)
            {
                for (int j = 1; j < b; j++)
                {
                    int cell = i * j;
                    Matrix[i, j] = cell;
                   
                }
               
            }

            for (int i = 1; i < a; i++)
            {
                for (int j = 1; j < b; j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }

            }
        static void Div()
        {
            Console.Write("Введите число ");
            int i = int.Parse(Console.ReadLine());
            for (int a = 1; a <= i; a++)
            {
                if (i % a == 0)
                {
                    Console.Write($" {a}");
                   
                }

            }

        }
    }
}