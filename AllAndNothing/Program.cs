using System;
using System.Collections.Generic;

namespace AllAndNothing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветсвую, Друг, чем займемся на этот раз?\n");

            ProgramList programList = new ProgramList();

            foreach (KeyValuePair<int, string> keyValue in programList.programDict)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.WriteLine("\nВведити цифру соответсвующую соответствующую требуемому функционалу");

            bool rez = int.TryParse(Console.ReadLine(), out int num);
            if (rez)
            {
                switch (num)
                {
                    case 1 :  
                        PiLenthToN.InN();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введите корректное значение");
                        Console.ResetColor();
                        break;
                }
            }

        }
    }
}
