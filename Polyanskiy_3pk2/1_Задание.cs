using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyanskiy_3pk2
{
    internal class _1_Задание
    {
        //случайный массив
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


        // сортировка выбором
        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }
        public static void Method1()
        {
            int[] arr = GenerateRandomArray(7000); // генерируем случайный массив из 7 тысяч элементов

            Stopwatch stopwatch = new Stopwatch(); // измереняем время


            // сортировка выбором
            stopwatch.Restart(); // сбрасываем секундомер
            SelectionSort(arr);
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения сортировки выбором: {stopwatch.ElapsedMilliseconds} мс");
        }
    }
}
