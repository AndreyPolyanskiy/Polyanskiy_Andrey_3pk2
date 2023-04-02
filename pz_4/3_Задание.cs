using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_4
{
    internal class _3_Задание
    {
        class TreeNode
        {
            public int Value;
            public TreeNode Left;
            public TreeNode Right;

            public TreeNode(int value)
            {
                Value = value;
            }
        }

        
        public static void Method3()
        {
            // Создаем дерево
            TreeNode root = new TreeNode(5);
            root.Left = new TreeNode(-2);
            root.Right = new TreeNode(7);
            root.Left.Left = new TreeNode(-3);
            root.Left.Right = new TreeNode(0);
            root.Right.Left = new TreeNode(6);
            root.Right.Right = new TreeNode(8);
        
            // Создаем список для хранения отрицательных значений информационных полей
            List<int> negativeValues = new List<int>();
        
            // Вызываем рекурсивную функцию обхода дерева
            TraverseTree(root, negativeValues);
        
            // Выводим отрицательные значения на консоль
            Console.WriteLine("Отрицательные значения:");
            foreach (int value in negativeValues)
            {
                Console.WriteLine(value);
            }
        }
        
        static void TraverseTree(TreeNode node, List<int> negativeValues)
        {
            if (node == null)
            {
                return;
            }
        
            if (node.Value < 0)
            {
                negativeValues.Add(node.Value);
            }
        
            TraverseTree(node.Left, negativeValues);
            TraverseTree(node.Right, negativeValues);
        }
        
    }
}
