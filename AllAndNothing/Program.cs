using System;
using System.Collections.Generic;

namespace AllAndNothing
{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramStart();
        }

        static internal void ProgramStart()
        {
            Console.WriteLine("\tПриветсвую, Друг, чем займемся на этот раз?\n\tДля перизапуска программы, в любой момент, введите 0\n");

            ProgramList programList = new ProgramList();

            foreach (KeyValuePair<int, string> keyValue in programList.programDict)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Console.WriteLine("\nВведити цифру соответсвующую соответствующую требуемому функционалу");

            string rez = InputParce.InParce(Console.ReadLine());

            switch (rez)
            {
                case "1" : 
                    PiLenthToN.InN();
                    break;
                default:
                    break;
            }
        }
    }
}
