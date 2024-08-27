using System;

namespace P101
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
    public class Queue
    {
        private Node<float> _head;
        private Node<float> _tail;
        private int _count;

        public Queue()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
        public void Enqueue(float value)
        {
            Node<float> newNode = new Node<float>(value);
            if (_tail == null)
            {
                _head = newNode;
                _tail = newNode;
            }
            else
            {
                _tail.Next = newNode;
                _tail = newNode;
            }
            _count++;
        }
        public float Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            float value = _head.Data;
            _head = _head.Next;
            if (_head == null)
            {
                _tail = null;
            }
            _count--;
            return value;
        }
        public bool IsEmpty()
        {
            return _head == null;
        }
        public int Count
        {
            get { return _count; }
        }
        public void Print()
        {
            Node<float> current = _head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            Random r = new Random();
            Queue queue = new Queue();

            for (int i = 0; i < 5; i++)
            {
                queue.Enqueue(r.Next(100) / 100.0f);
            }
            queue.Print();

            for (int i = 0; i < 5; i++)
            {
                queue.Dequeue();
                queue.Print();
            }
        }
    }
}
