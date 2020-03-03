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

        public Node Root
        {
            get
            {
                return root;
            }
        }

        public BinaryTree()
        {
            root = null;
        }

        public void Add(int data)
        {
            Node parent = new Node(data);
            parent.info = data;
            if (root == null)
            {
                root = parent;
            }
            else
            {
                Node current = root;
                while (true)
                {
                    parent = current;
                    if (data < parent.info)
                    {
                        current = parent.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = new Node(data);
                            break;
                        }

                    }
                    else
                    {
                        current = parent.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = new Node(data);
                            break;
                        }
                    }
                }
            }
        }


        public bool Search(int data)
        {
            while (root != null)
            {
                if (data > root.info)
                {
                    root = root.rightChild;
                }
                else if (data < root.info)
                    root = root.leftChild;
                else
                    return true;
            }
            return false;

        }








    }
}
