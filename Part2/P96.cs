using System;
namespace P96
{
    class Node
    {
        internal int data;
        internal Node next;
        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }
    class LinkedList
    {
        Node head;
        internal void InsertFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }
        internal void InsertBack(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
                return;
            }
            Node last = GetLastNode();
            last.next = node;
        }

        internal Node GetLastNode()
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void InsertAfter(int prev, int data)
        {
            Node prevNode = null;

            for (Node temp = head; temp != null; temp = temp.next)
            {
                if (temp.data == prev)
                    prevNode = temp;
                Node node = new Node(data);
                node.next = prevNode.next;
                prevNode.next = node;
            }
        }

        //등등....
    }
}
