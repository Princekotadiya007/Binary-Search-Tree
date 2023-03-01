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
                Console.WriteLine("\n1.CreateBinaryTree");
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
                        flag = false;   
                        break;
                }
            }
        }
    }
}
