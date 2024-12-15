using System.Security.Cryptography;

namespace BinaryHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worldeeeee!");
            HeapTree<int> heap = new HeapTree<int>();

            List<int> list = new List<int>([5, 687, 34, 7, 4, 7, 4, 5, 3, 5, 7,]);
            list = HeapSort(list, heap);
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


        }
        static  List<int> HeapSort(List<int> list,HeapTree<int> heap)
        {
            List<int> vals = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                heap.Insert(list[i]);
            }

            for(int i = 0; i < list.Count; i++)
            {
                vals.Add(heap.Pop());
            }
            return vals;
        }
    }
}
