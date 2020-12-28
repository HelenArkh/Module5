using System;
using System.Collections.Generic;
using System.Text;

namespace Module5
{
    class FavouriteColors
    {
        
       public static void MyFavcolors()
        {
            string[] favcolors = new string[3];

            for (int i=0;i<favcolors.Length;i++)
            {
                favcolors[i] = ShowColor();
            }

            foreach (var item in favcolors)
            {
                Console.WriteLine(item);
            }
        }
        
        
        static string ShowColor()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var colour = Console.ReadLine();

            switch (colour)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow");
                    break;
            }
            return colour;

        }
    }
}
