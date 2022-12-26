using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //A Node Class Consi

    class node
    {
        public string info;
        public node lchild;
        public node rchild;

        //Constructor for the node class

        public node(string i, node l, node r)
        {
            info = i;
            lchild = l;
            rchild = r;
        }
    }

    class Binarytree
    {
        public node ROOT;
        public Binarytree()
        {
            ROOT = null; // Initializing root to null
        }
        public void insert(string element) //Insert a node in the binary search trr
        {
            node tmp, parent = null, currentnode = null;
            find(element, ref parent, ref currentnode);
            if (currentnode != null)
            {
                Console.WriteLine("Duplicate words not allowed");
                return;
            }
            else // if the specified node is not present
            {
                tmp = new node (element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(element, parent.info) < 0)
                {
                    if (string.Compare(element, parent.info) < 0)
                        parent.lchild = tmp;
                }
                else
                {
                    parent.rchild = tmp;
                }
            }
        }
        public void find(string element, ref node parent, ref node currentnode)
        {
            currentnode = ROOT;
            parent = null;
            while ((currentnode != null) && (currentnode.info != element))
            {
                parent = currentnode;
                if (string.Compare(element, currentnode.info) < 0)
                    currentnode = currentnode.lchild;
                else
                    currentnode = currentnode.rchild;
            }
        }

        public void indorder(node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                indorder(ptr.lchild);
                Console.WriteLine(ptr.info + "");
                indorder(ptr.rchild);
            }
        }

        public void preorder(node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tress is empty");
                return;
            }
            if (ptr != null)
            {
                Console.WriteLine(ptr.info + "");
                preorder(ptr.lchild);
                preorder(ptr.rchild);
            }
        }

        public void postorder(node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if (ptr != null)
            {
                postorder(ptr.lchild);
                postorder(ptr.rchild);
                Console.Write(ptr.info + "");
            }
        }



        static void Main(string[] args)
        {
            Binarytree x = new Binarytree();
            while (true)
            {
                Console.WriteLine("\nMenu");
                Console.WriteLine("1. Implement insert operation");
                Console.WriteLine("2. Perform inorder traversal");
                Console.WriteLine("3. Perform preorder traversal");
                Console.WriteLine("4. Perform postorder traversal");
                Console.WriteLine("5. Exit");
                Console.WriteLine("\nEnter your choice (1-5) : ");
                char ch = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();
                switch (ch)
            }
        }
    }


   
}
