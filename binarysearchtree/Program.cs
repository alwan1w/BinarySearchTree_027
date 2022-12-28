using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binarysearchtree
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        //Constructor for the node class

        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }

    /*A node class consists of three things, the information,
     * references to the right child, and refrences to the left child*/
    class Program
    {
        public Node ROOT;
        public Program()
        {
            ROOT = null;/*Initializing ROOT to null*/
        }
        public void search(string element, ref Node perent, ref Node currentNode)
        {
            /*This function searchs the currentNode of the specified Node as well as the current Node of its perents */
            currentNode = ROOT;
            perent = null;
            while((currentNode != null) && (currentNode.info != element))
            {
                perent = currentNode;
                if (string.Compare(element, currentNode.info) < 0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
