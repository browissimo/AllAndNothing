using System;


namespace AllAndNothing
{
    static public class InputParce
    {
        public static string InParce(string input)
        {

            bool tryResult;
            string wrongAnswer = $"Введите корректное значение";
            ProgramList programList = new ProgramList();
            int programCount = programList.programDict.Count;

            tryResult = int.TryParse(input, out int rez);
            if (tryResult == true)
            {
                if (rez>0 && rez <= programCount)
                {
                    return Convert.ToString(rez); 
                }
                else
                {
                    while (programCount < rez || rez <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(wrongAnswer);
                        Console.ResetColor();
                        return InParce(Console.ReadLine());
                    }
                    return Convert.ToString(rez);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(wrongAnswer);
                Console.ResetColor();
                return InParce(Console.ReadLine());
            }
        }
    }
}
