using System;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction.Task1();
            // FavouriteColors.MyFavcolors();
            GetArrayFromConsole();
        }

        static string GetDataFromConsole()
        {
            return Console.ReadLine();
        } 

        static string GetDataFromConsole2() => Console.ReadLine();

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            int value;

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {

                    if (result[i] > result[j])
                    {
                        value = result[i];
                        result[i] = result[j];
                        result[j] = value;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            return result;
        }
    }
}
