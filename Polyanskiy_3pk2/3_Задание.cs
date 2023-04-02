using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyanskiy_3pk2
{
    internal class _3_Задание
    {
        public static void Method3()
        {
            //Делаем почти тоже самое что и во втором задании, но меняем массив на список
            //Создаем случайный список из 5к символов
            List<int> list = GenerateRandomList(5000); 
            list.Sort(); 

            Stopwatch stopwatch = new Stopwatch();

            // прямой поиск
            stopwatch.Start(); 
            int linearSearchIndex = LinearSearch(list, list[2500]);
            stopwatch.Stop(); 
            Console.WriteLine($"Время выполнения прямого поиска: {stopwatch.ElapsedMilliseconds} мс");

            // бинарный поиск
            stopwatch.Restart(); 
            int binarySearchIndex = list.BinarySearch(list[2500]);
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения бинарного поиска: {stopwatch.ElapsedMilliseconds} мс");

           
        }
        //Создаем случайный список
        static List<int> GenerateRandomList(int size)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(rand.Next(0, 1000));
            }
            return list;
        }

        static int LinearSearch(List<int> list, int target)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
