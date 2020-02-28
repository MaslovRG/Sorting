using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public class TreeSort : ISort
    {
        public (int, int) Sort<T>(T[] array) where T : IComparable<T>
        {
            int compares = 0; 
            var treeNode = new TreeNode<T>(array[0]);

            for (int i = 1; i < array.Length; i++)
                compares += treeNode.Insert(new TreeNode<T>(array[i]));

            var sortedArray = treeNode.Transform();
            for (int i = 0; i < array.Length; i++)
                array[i] = sortedArray[i];               

            return (compares, -1); 
        }

        public string GetSortName()
        {
            return "СОРТИРОВКА ДВОИЧНЫМ ДЕРЕВОМ"; 
        }
    }

    public class TreeNode<T> where T : IComparable<T>
    {
        public TreeNode(T data)
        {
            Data = data;
        }

        public T Data { get; set; }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public int Insert(TreeNode<T> node)
        {
            int compares = 1; 
            if (node.Data.CompareTo(Data) < 0)
            {
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    compares += Left.Insert(node);
                }
            }
            else
            {
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    compares += Right.Insert(node);
                }
            }
            return compares; 
        }

        public T[] Transform(List<T> elements = null)
        {
            if (elements == null)
            {
                elements = new List<T>();
            }

            if (Left != null)
            {
                Left.Transform(elements);
            }

            elements.Add(Data);

            if (Right != null)
            {
                Right.Transform(elements);
            }

            return elements.ToArray();
        }
    }
}
