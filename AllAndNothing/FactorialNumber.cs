using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllAndNothing
{
    public static class FactorialNumber
    {
        public static void FacNum()
        {
            Console.Clear();

            Console.WriteLine("Введите число, для вычисления его факториала");

            bool rez = int.TryParse(Console.ReadLine(), out int n);
            if (rez)
            {
                double fac = 1;
                for (int i = 1; i <= n ; i++)
                {
                    fac *= i;
                }
                Console.WriteLine($"Факториал для числа {n} равен {fac}");

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\nВведите S для возвращение в окно списка программ\nВведите R для повторного выполнения текущей программы\n" +
                    "Нажмите иную клавишу для звершения работы");
                Console.ResetColor();

                string restartOrExit = Console.ReadLine().ToUpper();
                if (restartOrExit == "S")
                {
                    Console.Clear();
                    Program.ProgramStart();
                }
                else if (restartOrExit == "R")
                {
                    Console.Clear();
                    FacNum();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВведите целое число \n");
                Console.ResetColor();
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadLine();
                FacNum();
            }
        }
    }
}
