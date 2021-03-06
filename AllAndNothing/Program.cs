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
            Console.WriteLine("\n\tПриветсвую, Друг, чем займемся на этот раз?\n");

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
                case "2" :
                    FactorialNumber.FacNum();
                    break;
                case "3" :
                    NameGenerator.NG();
                    break;
                default:
                    break;
            }
        }
    }
}
