using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearch<int> binary = new BinarySearch<int>(56);
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Binary Search");
                Console.WriteLine("\n1.CreateBinaryTree,\n2.SizeOfBinaryTree,\n3.Search 63 in the Binary Search Tree");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Creating BST to insert and display node value");
                        binary.Insert(30);
                        binary.Insert(70);
                        binary.Display();
                        break;
                    case 2:
                        Console.WriteLine("Inserting more node and get size of binary tree ");
                        binary.Insert(30);
                        binary.Insert(70);
                        binary.Insert(22);
                        binary.Insert(40);
                        binary.Insert(60);
                        binary.Insert(95);
                        binary.Insert(11);
                        binary.Insert(65);
                        binary.Insert(3);
                        binary.Insert(16);
                        binary.Insert(63);
                        binary.Insert(67);
                        binary.Display();
                        binary.GetSize();
                        break;
                    case 3:
                        binary.Insert(30);
                        binary.Insert(70);
                        binary.Insert(22);
                        binary.Insert(40);
                        binary.Insert(60);
                        binary.Insert(95);
                        binary.Insert(11);
                        binary.Insert(65);
                        binary.Insert(3);
                        binary.Insert(16);
                        binary.Insert(63);
                        binary.Insert(67);
                        Console.WriteLine("Binary Search Tree (in inorder traversal) is :");
                        binary.Display();
                        binary.GetSize();
                        bool result = binary.IfExists(63, binary);
                        Console.WriteLine(result);
                        break;
                    case 4:
                        flag = false;   
                        break;
                }
            }
        }
    }
}
