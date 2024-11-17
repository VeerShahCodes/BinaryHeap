using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    public class HeapTree<T>
        where T : IComparable<T>
    {

        T[] arr = new T[10];
        public int Count { get; private set; }
        
        public HeapTree()
        {

        }

        public void Insert(T val)
        {
            arr[Count] = val;
            if(Count >= arr.Length)
            {
                T[] newArr = new T[arr.Length * 2];
                arr = newArr;
                arr[Count] = val;
            }
            HeapifyUp(arr, Count);
            Count++;
        }

        public void HeapifyUp(T[] arr, int Count)
        {

        }

        public void Pop()
        {

        }

        public void HeapifyDown()
        {

        }

        private int GetParent(int index)
        {
            return index / 2;
        }


        private int GetLeftChild(int index)
        {
            return index * 2 + 1;
        }

        private int GetRightChild(int index)
        {
            return index * 2 + 2;
        }
    }
}
