using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node=new Node(data);
            if(this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp=this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next= node;
            }
            Console.WriteLine("{0} is inserted into Linked List",node.data);
        }
        public void Dislpay()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data +" ");
                    temp= temp.next;
                }
            }
        }
        public void InsertionBetween(int pos, int new_data)
        {
            Node newNode=new Node(new_data);
            if (pos == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            if (pos <= 0)
            {
                Console.WriteLine("Invalid Position");
            }
            if (pos > 0)
            {
                Node temp =this.head;
                while (pos != 0)
                {
                    if (pos == 2)
                    {
                        Console.WriteLine("Insertion b/w Two Nodes");
                        newNode.next = temp.next;
                        temp.next= newNode;
                        break;
                    }
                    temp = temp.next;
                    Console.WriteLine(pos);
                    pos--;
                }
            }
        }
        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.next;
            return this.head;
        }
        public Node RemoveLastNode()
        {
            if (this.head == null)
            {
                return null;
            }
            if (this.head.next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode=newNode.next;
            }
            newNode.next = null;
            return head;
        }
        public Node Search(int value)
        {
            while (this.head != null)
            {
                if(this.head.data == value)
                {
                    return this.head;
                }
                this.head=this.head.next;
            }
            return null;
        }
    }
}
