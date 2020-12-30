using System;

namespace Module5
{
    class Program
    {

        static void Main(string[] args)
        {

            (string, string, int, bool, int, string[], int, string[]) userData = GetUserData();
            ShowData(userData);
            
            
            //Console.WriteLine(Recursion.Factorial(20));

            //Recursion.UseEcho();
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

        static (string name, string surname, int age, bool hasPet, int countOfPets, string[] petNames, int countOfFavColors, string[] favColors) GetUserData()
        {

            (string name, string surname, int age, bool hasPet, int countOfPets, string[] petNames, int countOfFavColors, string[] favColors) User;

            Console.WriteLine("Введите имя");
            User.name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.surname = Console.ReadLine();

            string infAge;
            int intage;
            do
            {
                Console.WriteLine("Введите возраст цифрами:");
                infAge = Console.ReadLine();
            } while (CheckInput(infAge, out intage)==false);

            User.age = intage;

            Console.WriteLine("Есть ли у Вас животные? Да или Нет");
            string answer = Console.ReadLine();

            if (answer == "Да")
            {
                //проверить, что будет если да или ДА
                User.hasPet = true;

                Console.WriteLine("А сколько у Вас животных? ");
                string infPetCount;
                int intPetCount;
                do
                {
                    Console.WriteLine("Введите количество цифрами:");
                    infPetCount = Console.ReadLine();
                } while (CheckInput(infPetCount, out intPetCount)==false);

                User.countOfPets = intPetCount;

                User.petNames = GetPetNames(User.countOfPets);                

            }
            else
            {
                User.hasPet = false;
                User.countOfPets = 0;
                User.petNames = Array.Empty<string>();
            }

            Console.WriteLine("Сколько у Вас любимых цветов?");
            string infFavColorCount;
            int intFavColorCount;
            do
            {
                Console.WriteLine("Введите количество цифрами:");
                infFavColorCount = Console.ReadLine();
            } while (CheckInput(infFavColorCount, out intFavColorCount)==false);

            User.countOfFavColors = intFavColorCount;

            User.favColors = GetFavColors(User.countOfFavColors);
            
            return User;
        }

        static string[] GetPetNames(int countOfPets)
        {
            string[] petNames = new string[countOfPets];

            for (int i = 0; i < petNames.Length; i++)
            {
                Console.Write("Введите имя {0} питомца: ", i + 1);
                petNames[i] = Console.ReadLine();
            }

            return petNames;
        }

        static string[] GetFavColors(int countOfFavColors)
        {
            string[] favColors = new string[countOfFavColors];

            for (int i = 0; i < favColors.Length; i++)
            {
                Console.Write("Введите любимый цвет номер {0}: ", i + 1);
                favColors[i] = Console.ReadLine();
            }

            return favColors;
        }

        static bool CheckInput(string number, out int corrnumber)
        {           
            if(int.TryParse(number, out int intnum))
            {
                if(intnum>0)
                {
                    corrnumber = intnum;
                    return true;
                }
            }
            {
                corrnumber = 0;
                return false;
            }
        }

        static void ShowData((string name, string surname, int age, bool hasPet, int countOfPets, string[] petNames, int countOfFavColors, string[] favColors) cortege)
        {
            Console.WriteLine(); //пустая строка между введением данных и результатами
            Console.WriteLine("Имя пользователя: {0}", cortege.name);

            Console.WriteLine("Фамилия пользователя: {0}", cortege.surname);

            Console.WriteLine("Возраст пользователя: {0}", cortege.age);

            if (cortege.hasPet)
            {
                Console.WriteLine("Есть {0} питомцев", cortege.countOfPets);
                Console.WriteLine("Питомцев зовут:");

                foreach(var item in cortege.petNames)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Питомцев нет");
            }

            Console.WriteLine("У пользователя {0} любимых цветов. Среди них:", cortege.countOfFavColors);
            foreach (var item in cortege.favColors)
            {
                Console.WriteLine(item);
            }

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
