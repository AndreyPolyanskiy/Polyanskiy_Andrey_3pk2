using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    internal class _3_Задание
    {
        
        public static void Method3()
        {
            // Создаем дерево и заполняем его элементами
            Console.WriteLine("Введите 8 значений:");
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(Convert.ToInt32(Console.ReadLine()));
            tree.Add(Convert.ToInt32(Console.ReadLine()));
            tree.Add(Convert.ToInt32(Console.ReadLine()));
            tree.Add(Convert.ToInt32(Console.ReadLine()));
            tree.Add(Convert.ToInt32(Console.ReadLine()));
            tree.Add(Convert.ToInt32(Console.ReadLine()));
            tree.Add(Convert.ToInt32(Console.ReadLine()));
            tree.Add(Convert.ToInt32(Console.ReadLine()));

            // Задаем значение для поиска
            Console.WriteLine("Введите узел для поиска:");
            int valueToFind = Convert.ToInt32(Console.ReadLine());

            // Ищем узлы с заданным значением
            int count = tree.CountNodesWithValue(valueToFind);

            // Выводим результаты на экран
            Console.WriteLine($"Количество узлов со значением {valueToFind}: {count}");
        }
        

        // Реализация сбалансированного дерева
        class BinaryTree<T> where T : IComparable
        {
            // Класс узла дерева
            class Node
            {
                public T Value { get; set; }
                public Node Left { get; set; }
                public Node Right { get; set; }

                public Node(T value)
                {
                    Value = value;
                }
            }

            private Node root;

            // Добавление элемента в дерево
            public void Add(T value)
            {
                root = AddNode(root, value);
            }

            private Node AddNode(Node node, T value)
            {
                if (node == null)
                {
                    return new Node(value);
                }
                if (value.CompareTo(node.Value) < 0)
                {
                    node.Left = AddNode(node.Left, value);
                }
                else
                {
                    node.Right = AddNode(node.Right, value);
                }
                return node;
            }

            // Подсчет количества узлов с заданным значением
            public int CountNodesWithValue(T value)
            {
                return CountNodesWithValue(root, value);
            }

            private int CountNodesWithValue(Node node, T value)
            {
                if (node == null)
                {
                    return 0;
                }
                int count = 0;
                if (node.Value.CompareTo(value) == 0)
                {
                    count++;
                }
                count += CountNodesWithValue(node.Left, value);
                count += CountNodesWithValue(node.Right, value);
                return count;
            }
        }
    }
}
