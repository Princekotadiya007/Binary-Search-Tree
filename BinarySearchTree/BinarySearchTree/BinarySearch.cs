using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Creating BST using generics and IComparable to use CompareTo method in program
    class BinarySearch<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearch<T> leftTree { get; set; }
        public BinarySearch<T> rightTree { get; set; }

        public BinarySearch(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;

        }

        int leftCount = 0, rightCount = 0;
        bool result = false;

        //Method to check node and add node value to either left or right by comparing
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearch<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearch<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }

        //Displaying the data in the binary tree
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
        //Method to Get Size of the binary tree
        public void GetSize()
        {
            Console.WriteLine("Size of Binary Tree " + " " + (1 + this.leftCount + this.rightCount));
        }
        public bool IfExists(T element, BinarySearch<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
            }
            else
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            if (element.CompareTo(node.NodeData) < 0)
                IfExists(element, node.leftTree);
            if (element.CompareTo(node.NodeData) > 0)
                IfExists(element, node.rightTree);
            return result;
        }
    }
}
