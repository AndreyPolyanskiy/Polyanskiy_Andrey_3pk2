using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    internal class _1_Задание
    {
        //ну тут однотипно как в 2 и в 3
        class Node
        {
            public int Data;
            public Node Left;//Левый поток узла
            public Node Right;//Правый поток узла

            public Node(int data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }
        // Создаем класс BinaryTree, представляющий сбалансированное дерево.
        class BinaryTree
        {
            public Node Root;

            public BinaryTree()
            {
                Root = null;
            }

            public void Insert(int data)
            {
                Node newNode = new Node(data);

                if (Root == null)
                {
                    Root = newNode;
                    return;
                }

                Node current = Root;
                Node parent = null;
                while (true)
                {
                    parent = current;
                    if (data < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            return;
                        }
                    }
                }
            }

            public double GetAverageValue()
            {
                int sum = 0;
                int count = 0;
                GetAverageValueHelper(Root, ref sum, ref count);
                if (count == 0)
                {
                    return 0;
                }
                return (double)sum / count;
            }

            private void GetAverageValueHelper(Node node, ref int sum, ref int count)
            {
                if (node == null)
                {
                    return;
                }
                sum += node.Data;
                count++;
                GetAverageValueHelper(node.Left, ref sum, ref count);
                GetAverageValueHelper(node.Right, ref sum, ref count);
            }
        }

        
            public static void Method1()
            {
                BinaryTree tree = new BinaryTree();
                Console.WriteLine("Введите 7 значений");
                tree.Insert(Convert.ToInt32(Console.ReadLine()));
                tree.Insert(Convert.ToInt32(Console.ReadLine()));
                tree.Insert(Convert.ToInt32(Console.ReadLine()));
                tree.Insert(Convert.ToInt32(Console.ReadLine()));
                tree.Insert(Convert.ToInt32(Console.ReadLine()));
                tree.Insert(Convert.ToInt32(Console.ReadLine()));
                tree.Insert(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Среднее арифметическое значений информационных полей узлов дерева: {0}", tree.GetAverageValue());
            }
        
    }
    
}
