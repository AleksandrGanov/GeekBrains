using System;

namespace LinkedList
{
    class LinkedList
    {
        static void Main()
        {
            LinkedList L = new LinkedList();
            L.addAtFront(new Node(1));
            L.addAtFront(new Node(2));
            L.addAtFront(new Node(4));
            L.addAtEnd(new Node(8));
            L.print();
            Console.ReadLine();
        }

        private Node first = null;
        void addAtFront(Node node)
        {
            node.next = first;
            first = node;
        }
        void addAtEnd(Node node)
        {
            if (first == null)
                first = node;
            else
            {
                Node ptr = first;
                while (ptr.next != null)
                    ptr = ptr.next;
                ptr.next = node;
            }
        }
        void removeFront()
        {
            first = first.next;
        }
        void print()
        {
            Node ptr = first;
            while (ptr != null)
            {
                Console.Write(ptr.value + " -> ");
                ptr = ptr.next;
            }
        }

        class Node
        {
            public int value;
            public Node next;
            public Node(int value)
            {
                this.value = value;
            }
        }
    }
}