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

            (string name, int age) anketa;

            Console.Write("Enter your name: ");
            anketa.name = Console.ReadLine();

            Console.Write("Enter your age: ");
            anketa.age = Convert.ToInt32(Console.ReadLine());

           for (int i=0;i<favcolors.Length;i++)
            {
                favcolors[i] = ShowColor(anketa.name, anketa.age);
            }

            ShowColors(anketa.name);

          /* foreach (var item in favcolors)
            {
                Console.WriteLine(item);
            } */
        }

        static void ShowColors(string userName, params string[] favcolors)
        {
            Console.WriteLine("{0}, ваши любимые цвета:", userName);
            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
        }
        static string ShowColor(string userName, int userage)
        {
            Console.WriteLine("{0}, {1} лет\nНапишите свой любимый цвет на английском с маленькой буквы", userName, userage); 
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
