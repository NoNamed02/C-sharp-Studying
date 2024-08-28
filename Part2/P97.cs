using System;
namespace P97
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
		internal void InsertLast(int data)
		{
			Node node = new Node(data);
			if (head == null)
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
			while (temp.next != null)
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
		internal void Print()
		{
			for(Node temp = head; temp != null; temp=temp.next)
				Console.Write(temp.data + " ");
			Console.WriteLine();
		}
		//등등....
	}
	class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Random r= new Random();

            for (int i = 0; i < 5; i++)
            {
                list.InsertLast(r.Next(100));
            }
			list.Print();

			list.InsertFront(1);
			list.InsertLast(30);
			list.Print();
        }
    }
}
