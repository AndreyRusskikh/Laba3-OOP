﻿namespace NodeDef
{
    public class ListNode<T>
    {
        public T Data { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class NodeWork<T>
    {
        private ListNode<T> head;
        private int count;

        internal int Count
        {
            get { return count; }
            private set { count = value; }
        }

        public NodeWork()
        {
            head = null;
            Count = 0;
        }

        public void Add(T data)
        {
            ListNode<T> newNode = new ListNode<T>(data);
            var current = head;
            if (head == null)
            {
                head = newNode;
                newNode.Next = null;
                Count++;
            }
            else
            {
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                newNode.Next = null;
                Count++;
            }
        }

        // Функція додавання елементу в початок списку
        public void AddToFront(T data)
        {
            
            ListNode<T> newNode = new ListNode<T>(data);
            newNode.Next = head;
            head = newNode;
            Count++;
        }
        public void SwapFirstAndEndEl()
        {
            if (Count == 0 || Count == null)
            {
                Console.WriteLine("В списке нет элементов");
                return;
            }

            var current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            var temp = head.Data;
            head.Data = current.Data;
            current.Data = temp;
        }
        public T RemoveWithReturn()
        {
            if (head.Next == null)
                throw new Exception("Stack is empty");

            T tmp = head.Data;
            head = head.Next;
            Count--;
            return tmp;
        }
        public bool Equal(T Data)
        {
            var current = head;
            if (Count != 0)
            {
                while (current.Next != null)
                {
                    if (EqualityComparer<T>.Default.Equals(current.Data, Data))
                    {
                        return true;
                    }
                    current = current.Next;
                }
                return false;

            }
            return false;
        }
        public void RemoveFromFront() 
        {

            if (Count == 0 || Count == null)
            {
                Console.WriteLine("В списке нет элементов");
                return;
            }

            head = head.Next;
            Count--;
        }
        public void Reverse()
        {
            if (Count == 0 || Count == null)
            {
                return;
            }

            NodeWork<T> queue = new NodeWork<T>();

            ListNode<T> current = head;
            ListNode<T> previous = null;

            while (current != null)
            {
                ListNode<T> next = current.Next; // Сохраняем ссылку на следующий элемент
                current.Next = previous; // Инвертируем указатель на следующий элемент
                previous = current;
                current = next;
            }

            // Теперь previous указывает на новую голову инвертированного списка
            head = previous;
        }

        public void ClearStack()
        {
            while (Count != 0)
            {
                RemoveFromFront();
            }
            head = null;
        }

        // Функція для виведення списку
        public void Display()
        {
            ListNode<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

}