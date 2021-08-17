using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t This is Binary Search Tree");
            BTree<int> binarySearch = new BTree<int>(56);
            binarySearch.Insert(30);
            binarySearch.Insert(70);
            binarySearch.Display();
            binarySearch.GetSize();
        }
    }
}
