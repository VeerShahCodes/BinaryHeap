using System.Security.Cryptography;

namespace BinaryHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worldeeeee!");
            HeapTree<int> heap = new HeapTree<int>();

            List<int> list = new List<int>([5, 3, 7, 8, 1, 9, 10, 12, 11, 13, 6, 100, 76, 54]);
            list = HeapSort(list, heap);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


        }
        static List<int> HeapSort(List<int> list, HeapTree<int> heap)
        {
            List<int> vals = new List<int>();

            heap = new HeapTree<int>(list.ToArray());
            heap.WriteHeap();

            for (int i = 0; i < list.Count; i++)
            {
                vals.Add(heap.Pop());
            }
            return vals;
        }
    }
}
