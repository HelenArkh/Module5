using System;
using System.Collections.Generic;
using System.Text;

namespace Module5
{
    class Recursion
    {
        public static void UseEcho()
        {
            Console.WriteLine("Напишите что-то");

            var str = Console.ReadLine();

            Console.WriteLine("Укажите глубину эха");

            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);
        }
        
        static void Echo(string saidword, int deep)
        {
            var modif = saidword;
            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep>1)
            {
                Echo(modif, deep - 1);
            }
        }
        public static decimal Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {

                    return N * PowerUp(N, --pow);
                }
            }
        }


    }
}
