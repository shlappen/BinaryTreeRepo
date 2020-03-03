using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(3);
            binaryTree.Add(4);
            binaryTree.Add(5);
            binaryTree.Add(6);


            Console.WriteLine(binaryTree.Search(7).ToString());

            Console.ReadLine();

            BinaryTree binaryTree1 = new BinaryTree();
            binaryTree1.Add(6);
            binaryTree1.Add(5);
            binaryTree1.Add(4);
            binaryTree1.Add(3);
            binaryTree1.Add(2);
            binaryTree1.Add(1);

            Console.WriteLine(binaryTree1.Search(1).ToString());
            Console.ReadLine();

            BinaryTree binaryTree2 = new BinaryTree();
            binaryTree2.Add(5);
            binaryTree2.Add(4);
            binaryTree2.Add(6);
            binaryTree2.Add(10);

            Console.WriteLine(binaryTree2.Search(10).ToString());
            Console.ReadLine();


        }
    }
}
