using System;

namespace Module5
{
    class Program
    {
        static int num1 = 667;

        static void Main(string[] args)
        {

            Recursion.UseEcho();
            // Console.WriteLine(num1);

           // Console.WriteLine(Sum());

          /*  if(num1>0)
            {
                var num3 = 5;

                Console.WriteLine(num1 + num3);
            } */

            //Introduction.Task1();
            // FavouriteColors.MyFavcolors();

           /* int razm = 10;
            GetArrayFromConsole(ref razm); */
            // ShowArray(array, true);

           // string name = "Евгения";
            //GetName(out name);
             // ChangeName(ref name);
             // Console.WriteLine(name);

            //  int age = 33;
              //ChangeAge(age);
              //Console.WriteLine(age); */

          /*  var arr = new int[] { 1, 2, 3 };
            var data = 5;
            BigDataOperation(arr,in data);

            Console.WriteLine(arr[0]); */

        }

        static int Sum()
        {
            var num1 = 0;
            var num2 = 1;
            return num1 - num2;
        }

        static void BigDataOperation(int[] arr, in int data)
        {
          //  data = 4;
            arr[0] = data;
        }

        static void GetName(out string name, out string oldname)
        {
            oldname = "Евгения";
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static void ChangeName(ref string name)
        {
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

        }

        static void ChangeAge(int age)
        {
            Console.WriteLine("Введите возраст");
            age = Convert.ToInt32(Console.ReadLine());

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
            //   temp = SortArray(array);
            }
            
            foreach (var item in temp)
            {
                Console.Write(item + " ");
            }
        }

        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sortedasc = SortArrayAsc(array);

            sorteddesc = SortArrayDesc(array);

        }

        static int[] SortArrayAsc(int[] array)
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

        static int[] SortArrayDesc(int[] array)
        {
            int value;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {

                    if (array[i] < array[j])
                    {
                        value = array[i];
                        array[i] = array[j];
                        array[j] = value;
                    }
                }
            }
            return array;
        }

        static int[] GetArrayFromConsole(ref int num)
        {
            num = 6;
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
