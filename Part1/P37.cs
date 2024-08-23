using System;
using System.Diagnostics;

namespace A037
{
    class Program
    {
        enum E { A, B, C };
        static void Main(string[] args)
        {
            int a = default;
            string s = default;
            Console.WriteLine("a = " + a);
            Console.WriteLine("s = " + s);

            Console.WriteLine("E = " + default(E));
            Console.WriteLine("E = " + (E)0);

            TList<int> List = new TList<int>();
            Console.WriteLine("List : " + List.GetLast());

            TList<string> List2 = new TList<string>();
            Console.WriteLine("List : " + List2.GetLast());
        }
    }
    public class TList<T>
    {
        private class Node
        {
            public T data;
            public Node next;
        }
        private Node head = default;

        public void addNode(T t)
        {
            Node node = new Node();
            node.next = head;
            node.data = t;
            head = node;
        }
        public T GetLast()
        {
            T temp = default(T);

            Node current = head;
            while (current != null)
            {
                temp = current.data;
                current = current.next;
            }
            return temp;
        }
    }
}
