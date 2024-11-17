namespace BinaryHeap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Worldeeeee!");
            HeapTree<int> heap = new HeapTree<int>();
            heap.Insert(1);
            heap.Insert(5);
            Console.WriteLine(heap.GetParent(1));




        }
    }
}
