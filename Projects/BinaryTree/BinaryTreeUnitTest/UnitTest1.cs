using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinaryTree;

namespace BinaryTreeUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BinaryTree_AddIncreasingValues()
        {
            binaryTree = new BinaryTree();
            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(3);
            binaryTree.Add(4);
            binaryTree.Add(5);
            binaryTree.Add(6);
        }
    }
}
