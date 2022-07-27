/*Пользователь вводит с клавиатуры показания тем-
пературы. В зависимости от выбора пользователя про-
грамма переводит температуру из Фаренгейта в Цельсий
или наоборот.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Доброго дня!\nВведіть будь-ласка значення температури, після чого натисніть 1 для перетвореня Фаренгейта в цельсій і 2 для перетворення навпаки: ");
            int temp = Convert.ToInt32(Console.ReadLine());
            int f = Convert.ToInt32(Console.ReadLine());
            switch (f)
            {
                case 1:
                    double cels = (temp - 32) / 1.8;
                    Console.WriteLine($"За целсієм {cels} градусів"); break;
                case 2:
                    double faren = temp * 1.8 + 32;
                    Console.WriteLine($"За фаренгейтом {faren} градусів "); break;
                default:
                    Console.WriteLine("Ви вели не коректну функцію");
                    break;
            }

            Console.WriteLine("Дякуємо!!!");
            Console.ReadKey();


        }
    }
}