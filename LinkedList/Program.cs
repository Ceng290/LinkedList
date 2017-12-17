using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public int data;
        public Node next;

        public Node (int i)
        {
            data = i;
            next = null;
        }
        public void print()
        {
            Console.Write("|" + data + "|->");
            if (next != null)
            {
                next.print();
            }
        }

        public void AddToSorted(int data)
        {
            if (next == null)
            {
                next = new Node(data);
            }
            else if (data < next.data)
            {
                Node temp = new Node(data);
                temp.next = this.next;
                this.next = temp;

            }
            else
            {
                next.AddToSorted(data);
            }
        }
        public void AddToEnd(int data) {
            if (next == null)
            {
                next = new Node(data);
            }
            else
            {
                next.AddToEnd(data);
            }
        }
    }

    public class myList {
        public Node headNode;

        public myList() {
            headNode = null;
        }

        public void AddToEnd(int data) {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else {
                headNode.AddToEnd(data);
            }
        }
        public void AddToSorted(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else if (data < headNode.data)
            {
                AddToBeginning(data);
            }
            else
            {
                headNode.AddToSorted(data);
            }
        }
        public void AddToBeginning(int data)
        {
            if (headNode == null)
            {
                headNode = new Node(data);
            }
            else {
                Node temp = new Node(data);
                temp.next = headNode;
                headNode = temp;
            }
        }
        public void Print()
        {
            if (headNode != null) {
                headNode.print();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node myNode = new Node(7);
            //myNode.AddToEnd(5);
            //myNode.AddToEnd(11);
            //myNode.AddToEnd(4);
            //myNode.print();

            myList list = new myList();
            //list.AddToEnd(9);
            //list.AddToEnd(9);
            //list.AddToEnd(9);
            //list.AddToEnd(9);

            //list.AddToBeginning(8);
            //list.AddToBeginning(7);
            //list.AddToBeginning(6);
            //list.AddToBeginning(5);

            list.AddToSorted(8);
            list.AddToSorted(7);
            list.AddToSorted(6);
            list.AddToSorted(5);
            list.Print();

            Console.ReadLine();
        }
    }
}
