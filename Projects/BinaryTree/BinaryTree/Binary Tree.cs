using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.info = data;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {

                    parent = current;

                    if (data < parent.info)
                    {
                        parent = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = new Node(data);
                            break;
                        }
                    }
                    else
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.rightChild = new Node(data);
                            break;
                        }
                    }
                    
                }
            }
        }


        public void Search(int data)
        {
            Node node = root;
            if (node == null)
            {
                Console.WriteLine("Nothing in tree!");
            }
            while (node != null)
            {
                if (node.info == data)
                {
                    Console.WriteLine("Found a match!");
                }
            }
            Console.WriteLine("Not in tree!");
        }






    }
}
