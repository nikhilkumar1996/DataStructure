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
            linkedList.Add(48);
            linkedList.Add(90);
            linkedList.Add(55);
            linkedList.InsertionBetween(2, 30);
            linkedList.Search(55);
            linkedList.RemoveFirstNode();
            linkedList.RemoveLastNode();
            linkedList.Dislpay();
        }
    }
}
