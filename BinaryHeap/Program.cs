namespace BinaryHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worldeeeee!");
            HeapTree<int> heap = new HeapTree<int>();
            heap.Insert(5);
            heap.Insert(1);

            Console.WriteLine(heap.arr[0]);
            Console.WriteLine(heap.arr[1]);


        }
    }
}
