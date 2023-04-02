using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2
{
    internal class _1_Задание
    {
        public static void Method1()
        {
            int[,] matrix = new int[,] {{0,1,1,0,0},
                             {0,0,0,1,0},
                             {0,1,0,0,1},
                             {0,0,1,0,0},
                             {0,0,0,1,0}};

            int n = matrix.GetLength(0); // количество вершин в графе

            int[,] reachabilityMatrix = new int[n, n]; // матрица достижимости

            // Инициализация матрицы достижимости нулями
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    reachabilityMatrix[i, j] = 0;
                }
            }

            // Заполнение матрицы достижимости на основе матрицы смежности
            for (int k = 0; k < n; k++)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (matrix[i, k] == 1 && matrix[k, j] == 1)
                        {
                            reachabilityMatrix[i, j] = 1;
                        }
                    }
                }
            }

            // Проверка связности графа
            bool isConnected = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (reachabilityMatrix[i, j] == 0)
                    {
                        isConnected = false;
                        break;
                    }
                }
            }
            string a;
            if (isConnected == true)
            {
                a = "Да";
            }
            else 
            { 
                a = "Нет"; 
            }

            Console.WriteLine("Граф является связным: " + a);
        }
    }
}
