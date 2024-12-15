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

        public T[] arr;
        public int Count { get; private set; }
        
        public HeapTree()
        {
            Count = 0;
            arr = new T[1];
        }
        public HeapTree(T[] values)
        {
            arr = values;
            int depth = (int)Math.Log2(arr.Length);
            Count=arr.Length;
            for (int i = (int)Math.Pow(2,depth)-1; i < arr.Length; i++)
            {
                HeapifyUp(i);
            }
            ;
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



        public void HeapifyUp(int current)
        {
            while(true)
            {
                if (current==0) break;
                int parentIndex = GetParent(current);               
                if (arr[current].CompareTo(arr[parentIndex]) < 0)
                {
                    T ogArrOfCount = arr[current];
                    arr[current] = arr[parentIndex];
                    arr[parentIndex] = ogArrOfCount;
                    
                }
                current = parentIndex;
            }

        }

        public T Pop()
        {
            T root = arr[0];
            arr[0] = arr[Count - 1];
            Count--;
            HeapifyDown(0);

            return root;
        }

        public void HeapifyDown(int current)
        {
      
            while (true)
            {
                int leftChild = GetLeftChild(current);
                int rightChild = GetRightChild(current);
                if(leftChild > Count && rightChild > Count) //leaf position
                {
                    break;
                }
                if (arr[leftChild].CompareTo(arr[rightChild]) < 0)
                {
                    T ogArrOfCount = arr[current];
                    arr[current] = arr[leftChild];
                    arr[leftChild] = ogArrOfCount;
                    current = leftChild;
                }
                else
                {
                    T ogArrOfCount = arr[current];
                    arr[current] = arr[rightChild];
                    arr[rightChild] = ogArrOfCount;
                    current = rightChild;
                }
            }
        }

       

        public void WriteHeap()
        {
            for(int i = 0; i < Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        private int GetParent(int index)
        {
            return ((index -1) / 2);
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
