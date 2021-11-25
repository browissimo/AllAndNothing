using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using AllAndNothing.Properties;

namespace AllAndNothing
{
    public static class NameGenerator
    {
        public static void NG()
        {
            Console.Clear();

            Console.WriteLine("Из скольки слов будет состоять имя?\nВведите цифру от 1 до 8");

            string[] phrasesMas = Resources.ShitNames.Split('\n');

            

            bool rez = int.TryParse(Console.ReadLine(), out int n);
            if (rez==true && 0<n && n < 9)
            {
                var phList = new List<string>();
                foreach (var ph in phrasesMas)
                {
                    if (ph.Split(' ').Length == n)
                    {
                        phList.Add(ph);
                    }
                }
                phList.Sort();

                Random rand = new Random();
                int randNum = rand.Next(1, n);

                Console.WriteLine(phList[randNum]);

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n\nВведите S для возвращение в окно списка программ\nВведите R для повторного выполнения текущей программы");
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
                    NG();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВведите целое число от 1 до 8\n");
                Console.ResetColor();
                Console.WriteLine("Нажмите Enter для продолжения");
                Console.ReadLine();
                NG();
            }


            
        }
    }
}
