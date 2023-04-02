using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2
{
    internal class _2_Задание
    {
        public static void Method2()
        {
            int[,] matrix = new int[,] {{0,7,9,0,0},
                             {7,0,10,15,0},
                             {9,10,0,11,5},
                             {0,15,11,0,6},
                             {0,0,5,6,0}};
            int n = matrix.GetLength(0); // количество вершин в графе
            int start = 0; // начальная вершина
            int[] distances = new int[n]; // массив расстояний до вершин графа
            bool[] visited = new bool[n]; // массив посещенных вершин
            for (int i = 0; i < n; i++)
            {
                distances[i] = int.MaxValue; // инициализация расстояний до вершин бесконечностью
                visited[i] = false; // инициализация массива посещенных вершин значением false
            }
            distances[start] = 0; // расстояние до начальной вершины равно 0
            for (int i = 0; i < n - 1; i++)
            {
                int minDist = int.MaxValue;
                int minIndex = -1;
                // выбор вершины с наименьшим расстоянием до начальной вершины
                for (int j = 0; j < n; j++)
                {
                    if (!visited[j] && distances[j] < minDist)
                    {
                        minDist = distances[j];
                        minIndex = j;
                    }
                }
                // обновление расстояний до соседних вершин
                for (int k = 0; k < n; k++)
                {
                    if (matrix[minIndex, k] > 0 && distances[minIndex] + matrix[minIndex, k] < distances[k])
                    {
                        distances[k] = distances[minIndex] + matrix[minIndex, k];
                    }
                }
                visited[minIndex] = true; // пометка вершины как посещенной
            }
            // вывод расстояний до вершин
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Расстояние от вершины {0} до вершины {1} равно {2}", start, i, distances[i]);
            }
        }
    }
}
