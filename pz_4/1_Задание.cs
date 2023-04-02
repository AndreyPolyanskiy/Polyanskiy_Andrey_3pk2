using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_4
{
    internal class _1_Задание
    {
        class Node
        {
            public int data;
            public Node left, right;

            public Node(int value)
            {
                data = value;
                left = null;
                right = null;
            }
        }

        class BinaryTree
        {
            private Node root;

            public BinaryTree()
            {
                root = null;
            }

            public void Insert(int value)
            {
                root = Insert(root, value);
            }

            private Node Insert(Node node, int value)
            {
                if (node == null)
                {
                    node = new Node(value);
                }
                else if (value < node.data)
                {
                    node.left = Insert(node.left, value);
                }
                else
                {
                    node.right = Insert(node.right, value);
                }
                return node;
            }

            public int Sum()
            {
                return Sum(root);
            }

            private int Sum(Node node)
            {
                if (node == null)
                {
                    return 0;
                }
                return node.data + Sum(node.left) + Sum(node.right);
            }
        }

        
        public static void Method1()
        {
            BinaryTree tree = new BinaryTree();
            Random rnd = new Random();
            int n = 10; // количество элементов в дереве
            int sum = 0; // сумма информационных полей узлов
            for (int i = 0; i < n; i++)
            {
                int value = rnd.Next(10, 1001); // рандомное значение от 10 до 1000
                tree.Insert(value);
                sum += value;
            }
            Console.WriteLine("Сумма информационных полей узлов дерева: " + sum);
        }
        
    }
}
