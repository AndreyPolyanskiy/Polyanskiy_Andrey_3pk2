using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_4
{
    internal class _4_Задание
    {
        class Node
        {
            public int Key;
            public int Value;
            public Node Left;
            public Node Right;

            public Node(int key, int value)
            {
                Key = key;
                Value = value;
                Left = null;
                Right = null;
            }
        }

        class BinaryTree
        {
            public Node Root;

            public BinaryTree()
            {
                Root = null;
            }

            public void Insert(int key, int value)
            {
                Root = Insert(Root, key, value);
            }

            private Node Insert(Node node, int key, int value)
            {
                if (node == null)
                {
                    node = new Node(key, value);
                }
                else if (key < node.Key)
                {
                    node.Left = Insert(node.Left, key, value);
                }
                else if (key > node.Key)
                {
                    node.Right = Insert(node.Right, key, value);
                }
                else
                {
                    node.Value = value;
                }

                return node;
            }

            public void InOrderTraversal(List<int> list)
            {
                InOrderTraversal(Root, list);
            }

            private void InOrderTraversal(Node node, List<int> list)
            {
                if (node != null)
                {
                    InOrderTraversal(node.Left, list);
                    list.Add(node.Value);
                    InOrderTraversal(node.Right, list);
                }
            }
        }


        public static void Method4()
        {
            //Тут я решил составить сам, без пользователя
            BinaryTree tree1 = new BinaryTree();
            tree1.Insert(5, 10);
            tree1.Insert(2, 20);
            tree1.Insert(8, 30);
            tree1.Insert(1, 40);
            tree1.Insert(3, 50);
            
            BinaryTree tree2 = new BinaryTree();
            tree2.Insert(5, 60);
            tree2.Insert(2, 70);
            tree2.Insert(8, 80);
            tree2.Insert(1, 40);
            tree2.Insert(3, 50);

            List<int> commonValues = new List<int>();
            List<int> values1 = new List<int>();
            List<int> values2 = new List<int>();

            tree1.InOrderTraversal(values1);
            tree2.InOrderTraversal(values2);

            foreach (int value in values1)
            {
                if (values2.Contains(value))
                {
                    commonValues.Add(value);
                }
            }

            Console.WriteLine("Значения, которые совпадают в обоих деревьях: ");
            foreach (int value in commonValues)
            {
                Console.WriteLine(value);
            }
        }
    }
}
