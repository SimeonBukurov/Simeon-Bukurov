using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(1);
            box.Add(2);
            box.Add(3);
            box.Add(4);
            box.Add(5);
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Remove());
            Console.WriteLine(box.Count);
            box.Add(6);
            box.Add(7);
            box.Add(8);
            box.Add(9);
            Console.WriteLine(box.Count);
        }
    }
    class Box<T>
    {
        public List<T> data;
        public Box()
        {
            data = new List<T>();
        }
        public int Count => this.data.Count;

        public void Add(T item)
        {
            this.data.Add(item);
        }
        public T Remove()
        {
            var delete = this.data.Last();
            this.data.RemoveAt(this.data.Count - 1);
            return delete;
        }
    }
}
