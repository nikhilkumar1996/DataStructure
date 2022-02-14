using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program");
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.InsertionBetween(2, 30);
            linkedList.Add(70);
            linkedList.RemoveFirstNode();
            linkedList.RemoveLastNode();
            linkedList.Dislpay();
            Stack stack = new Stack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.Peek();
            stack.Pop();
            stack.Display();
            stack.isEmpty();
            Queue queue = new Queue();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            queue.Dequeue();
            queue.Display();



        }
    }
}
