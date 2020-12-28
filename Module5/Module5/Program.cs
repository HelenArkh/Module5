using System;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction.Task1();
            // FavouriteColors.MyFavcolors();

          var array = GetArrayFromConsole(10);
            ShowArray(array, true);

        }

        static string GetDataFromConsole()
        {
            return Console.ReadLine();
        } 

        static string GetDataFromConsole2() => Console.ReadLine();

        static void ShowArray(int[] array, bool sort = false)
        {
            var temp = array;
           if(sort)
            {
               temp = SortArray(array);
            }
            
            foreach (var item in temp)
            {
                Console.Write(item + " ");
            }
        }

        static int[] SortArray(int[] array)
        {
            int value;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[i] > array[j])
                    {
                        value = array[i];
                        array[i] = array[j];
                        array[j] = value;
                    }
                }
            }
            return array;

        }

        static int[] GetArrayFromConsole(int num = 5)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }
    }
}
