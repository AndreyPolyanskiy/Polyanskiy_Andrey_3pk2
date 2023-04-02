using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyanskiy_3pk2
{
    internal class _2_Задание
    {
        
        public static void Method2()
        {
            int[] arr = GenerateRandomArray(5000); // генерируем случайный массив из 5000 элементов
            Array.Sort(arr); // сортируем массив для бинарного поиска

            Stopwatch stopwatch = new Stopwatch(); //измереняем время

            // прямой поиск
            stopwatch.Start(); // запускаем секундомер
            int linearSearchIndex = LinearSearch(arr, arr[2500]);
            stopwatch.Stop(); // останавливаем секундомер
            Console.WriteLine($"Время выполнения прямого поиска: {stopwatch.ElapsedMilliseconds} мс");

            // бинарный поиск
            stopwatch.Restart(); // сбрасываем секундомер
            int binarySearchIndex = Array.BinarySearch(arr, arr[2500]);
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения бинарного поиска: {stopwatch.ElapsedMilliseconds} мс");

            
        }

        static int[] GenerateRandomArray(int size)
        {
            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(0, 1000);
            }
            return arr;
        }

        static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

