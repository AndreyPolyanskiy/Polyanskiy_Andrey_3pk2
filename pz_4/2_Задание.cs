using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_4
{
    internal class _2_Задание
    {
        //Для подсчета количества внутренних узлов дерева поиска, нужно обойти каждый узел и проверить, имеет ли узел потомков.
        //Делаем почти также как и в 1 задании, но немного по-другому
        class TreeNode
        {
            public int value;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int value)
            {
                this.value = value;
                left = null;
                right = null;
            }
        }

        class BinarySearchTree
        {
            private TreeNode root;

            public BinarySearchTree()
            {
                root = null;
            }

            public void Insert(int value)
            {
                if (root == null)
                {
                    root = new TreeNode(value);
                    return;
                }

                TreeNode currentNode = root;

                while (currentNode != null)
                {
                    if (value < currentNode.value)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = new TreeNode(value);
                            return;
                        }
                        currentNode = currentNode.left;
                    }
                    else
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = new TreeNode(value);
                            return;
                        }
                        currentNode = currentNode.right;
                    }
                }
            }

            public int CountInternalNodes()
            {
                return CountInternalNodesRecursive(root);
            }

            private int CountInternalNodesRecursive(TreeNode node)
            {
                if (node == null)
                {
                    return 0;
                }

                if (node.left == null && node.right == null)
                {
                    return 0;
                }

                return 1 + CountInternalNodesRecursive(node.left) + CountInternalNodesRecursive(node.right);
            }
        }

        
        public static void Method2()
        {
            BinarySearchTree tree = new BinarySearchTree();

            // генерация значений дерева с помощью рандома
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                tree.Insert(rand.Next(10, 1000));
            }

            int internalNodesCount = tree.CountInternalNodes();

            Console.WriteLine($"Количество внутренних узлов: {internalNodesCount}");
        }
        
    }
}
