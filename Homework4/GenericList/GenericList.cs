using System;
using System.Collections.Generic;

namespace Homework4
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public int length; 
        public GenericList()
        {
            tail = head = null;
            length = 0;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if(tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
            length++;
        }
        public void forEach(Action<T> action) {
            Node<T> temp = head;            
            while(temp != null)
            {
                action(temp.Data);
                temp = temp.Next;
            }
            Console.WriteLine();
        }
     
    }
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for(int i = 0; i < 10; i++)
            {
                list.Add(i);
            }

            Console.WriteLine("该范型list的值为：");
            list.forEach(x =>
            {
                Console.Write(x + "\t");
            });
            int sum = 0;
            list.forEach(x => { 
                sum += x;
            });
            Console.WriteLine("和：{0}", sum);
            int max = int.MinValue;
            list.forEach(x =>
            {
                max = max < x ? x : max;
            });
            Console.WriteLine("最大值：{0}", max);
            int min = int.MaxValue;
            list.forEach(x =>
            {
                min = min > x ? x : min;
            });
            Console.WriteLine("最小值：{0}", min);
        }
    }
}
