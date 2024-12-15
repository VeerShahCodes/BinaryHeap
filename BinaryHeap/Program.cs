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
            heap.Insert(3);
            heap.Insert(6);
            heap.Pop();
            heap.Insert(2);
            heap.Insert(7);
            heap.Pop();
            heap.WriteHeap();


        }
    }
}
