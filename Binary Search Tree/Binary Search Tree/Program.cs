using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating BSTree1");
            BSTree<int> myTree1 = new BSTree<int>();
            myTree1.InsertItem(1);
            myTree1.InsertItem(5);
            myTree1.InsertItem(2);
            myTree1.InsertItem(4);
            myTree1.InsertItem(6);
            myTree1.InsertItem(12);
            myTree1.InsertItem(9);
            myTree1.InsertItem(13);
            Console.WriteLine("Done\n");

            Console.WriteLine("Creating BSTree2");
            BSTree<int> myTree2 = new BSTree<int>();
            Console.WriteLine("Done\n");

            Console.WriteLine("Height() test");
            Console.WriteLine("BSTree1 height: {0}", myTree1.Height());
            Console.WriteLine("BSTree2 height: {0}", myTree2.Height());

            Console.WriteLine();

            Console.WriteLine("Contains() test");
            Console.WriteLine("BSTree1 contains 4: {0}", myTree1.Contains(4));
            Console.WriteLine("BSTree1 contains 10: {0}", myTree1.Contains(10));

            Console.WriteLine();

            Console.WriteLine("RemoveItem() test");
            Console.WriteLine("Removing 4 from BSTree1");
            myTree1.RemoveItem(4);
            Console.WriteLine("BSTree1 contains 4: {0}", myTree1.Contains(4));

            Console.ReadKey();
        }
    }
}
