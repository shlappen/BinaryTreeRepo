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

        public void BinarySearchTree()
        {
            root = null;
        }

        public void Add(int i)
        {
            Node newNode = new Node(i);
            newNode.info = i;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                while (true)
                {
                    temp = current;
                    
                    if (i < current.info)
                    {
                        current = current.leftChild;
                    }

                }
            }

        }

    }
}
