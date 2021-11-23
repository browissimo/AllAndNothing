using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AllAndNothing
{
    public static class PiLenthToN
    {
        public static void InN()
        {
            Console.Clear();

            string pi = "3,1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657595919530921861173819326117931051185480744623799627495673518857527248912279381830119491298336733624406566430860213949463952247371907021798609437027705392171762931767523846748184676694051320005681271452635608277857713427577896091736371787214684409012249534301465495853710507922796892589235420199561121290219608640344181598136297747713099605187072113499999983729780499510597317328160963185950244594553469083026425223082533446850352619311881710100031378387528865875332083814206171776691473035982534904287554687311595628638823537875937519577818577805321712268066130019278766111959092164201989";

            Console.WriteLine("Введите номер знака, до которого необходио отобразить число pi");

            bool rez = int.TryParse(Console.ReadLine(), out int n);
            if (rez)
            {
                Console.WriteLine($"\n Число pi до {n} сивола:");
                Console.WriteLine(pi.Remove(n+2));

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
                    InN();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nВведите целое число \n");
                Console.ResetColor();
                InN();
            }
        }
    }
}
