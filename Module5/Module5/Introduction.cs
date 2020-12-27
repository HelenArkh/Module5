using System;
using System.Collections.Generic;
using System.Text;

namespace Module5
{
    class Introduction
    {

        public static void Task1()
        {

            (string name, string[] dishes) User;

            Console.WriteLine("Введите имя пользователя");
            User.name = Console.ReadLine();

            User.dishes = new string[5];
            
            for (int i = 0; i < User.dishes.Length; i++)
            {
                Console.WriteLine("Введите любимое блюдо номер {0}",i+1); 
                User.dishes[i] = Console.ReadLine();
            }
        }
    }
}
