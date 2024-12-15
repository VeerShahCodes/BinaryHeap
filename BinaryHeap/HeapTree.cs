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
        //min heap

        public T[] arr = new T[1];
        public int Count { get; private set; }
        
        public HeapTree()
        {

        }
        private void ResizeArr()
        {
            T[] newArr = new T[arr.Length * 2];
            for(int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }
            arr = newArr;
        }

        public void Insert(T val)
        {
            if(Count >= arr.Length)
            {
                ResizeArr();
            }
            arr[Count] = val;

            HeapifyUp(Count);
            Count++;
        }

        public void HeapifyUp(int Count)
        {
            while(true)
            {
                int parentIndex = ((Count + 1) / 2) - 1;
                if (parentIndex < 0) break;
                if (arr[Count].CompareTo(arr[parentIndex]) < 0)
                {
                    T ogArrOfCount = arr[Count];
                    arr[Count] = arr[parentIndex];
                    arr[parentIndex] = ogArrOfCount;
                }
                else
                {
                    break;
                }
            }

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
