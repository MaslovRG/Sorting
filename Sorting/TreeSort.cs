using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting
{
    public enum Direction
    {
        Left = 0,
        Right = 1
    }


    public class TreeSort : ISort
    {
        public (int, int) Sort<T>(T[] array) where T : IComparable<T>
        {
            int compares = 0, swaps = 0; 
            var treeNode = new TreeNode<T>(array[0]);
            int nCompares, nSwaps; 

            for (int i = 1; i < array.Length; i++)
            {
                (nCompares, nSwaps) = treeNode.Insert(new TreeNode<T>(array[i]), Direction.Left);
                compares += nCompares;
                swaps += nSwaps; 
            }

            var sortedArray = treeNode.Transform();
            for (int i = 0; i < array.Length; i++)
                array[i] = sortedArray[i];               

            return (compares, swaps); 
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

        public (int, int) Insert(TreeNode<T> node, Direction direction)
        {
            int compares = 1, swaps = 0;
            int nCompares, nSwaps; 
            if (node.Data.CompareTo(Data) < 0)
            {
                if (direction != Direction.Left)
                {
                    swaps = 1; 
                }
                if (Left == null)
                {
                    Left = node;
                }
                else
                {
                    (nCompares, nSwaps) = Left.Insert(node, Direction.Left);
                    compares += nCompares;
                    swaps += nSwaps; 
                }
            }
            else
            {
                if (direction != Direction.Right)
                {
                    swaps = 1; 
                }
                if (Right == null)
                {
                    Right = node;
                }
                else
                {
                    (nCompares, nSwaps) = Right.Insert(node, Direction.Right);
                    compares += nCompares;
                    swaps += nSwaps; 
                }
            }
            return (compares, swaps); 
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
