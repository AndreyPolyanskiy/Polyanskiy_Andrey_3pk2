using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz3
{
    internal class _2_Задание
    {
        class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }

        class BalancedTree
        {
            public Node root;

            public BalancedTree(int[] values)
            {
                root = CreateBalancedTree(values, 0, values.Length - 1);
            }

            private Node CreateBalancedTree(int[] values, int start, int end)
            {
                if (start > end)
                {
                    return null;
                }

                int mid = (start + end) / 2;
                Node node = new Node(values[mid]);
                node.left = CreateBalancedTree(values, start, mid - 1);
                node.right = CreateBalancedTree(values, mid + 1, end);
                return node;
            }

            public int CountNodesWithPositiveValues()
            {
                return CountNodesWithPositiveValues(root);
            }

            private int CountNodesWithPositiveValues(Node node)
            {
                if (node == null)
                {
                    return 0;
                }

                int count = 0;
                if (node.value > 0)
                {
                    count++;
                }

                count += CountNodesWithPositiveValues(node.left);
                count += CountNodesWithPositiveValues(node.right);

                return count;
            }

            public int CountNodesWithNegativeValues()
            {
                return CountNodesWithNegativeValues(root);
            }

            private int CountNodesWithNegativeValues(Node node)
            {
                if (node == null)
                {
                    return 0;
                }

                int count = 0;
                if (node.value < 0)
                {
                    count++;
                }

                count += CountNodesWithNegativeValues(node.left);
                count += CountNodesWithNegativeValues(node.right);

                return count;
            }
        }

        
        public static void Method2()
        {
            int[] values = new int[] { -10, 2, 5, -3, 7, 11, 1, -8 };
            BalancedTree tree = new BalancedTree(values);

            int positiveCount = tree.CountNodesWithPositiveValues();
            int negativeCount = tree.CountNodesWithNegativeValues();
            int totalCount = positiveCount + negativeCount;
            double average = (double)CalculateSumOfValues(tree.root) / totalCount;

            Console.WriteLine("Количество узлов с положительными значениями: {0}", positiveCount);
            Console.WriteLine("Количество узлов с отрицательными значениями: {0}", negativeCount);
            Console.WriteLine("Среднее арифметическое значений информационных полей узлов дерева: {0:F2}", average);
        }

        static int CalculateSumOfValues(Node node)
        {
            if (node == null)
            {
                return 0;
            }

            int sum = node.value;
            sum += CalculateSumOfValues(node.left);
            sum += CalculateSumOfValues(node.right);
            return sum;
        }
        
    }
}
