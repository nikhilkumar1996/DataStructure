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
            Console.WriteLine("1.\n LinkedList \n" +
                              "2.\n Stack \n" +
                              "3.\n Queue \n" +
                              "4.\n HashTable for frequency of Words \n" +
                              "5.\n HashTable for frequnecy of paragraph \n" +
                              "6.\n HashTable for Removing a word \n" +
                              "7.\n BinarySearchTree Insertion \n" +
                              "8.\n BinarySearchTree Other Elements Insertion \n" +
                              "9.\n BinarySearchTree Search \n" +
                              "10.\n Exit \n ");
            Console.WriteLine("Choose Program");
            bool flag=true;
            while (flag)
            {
                int choose=Convert.ToInt32(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        LinkedList linkedList = new LinkedList();
                        linkedList.Add(56);
                        linkedList.InsertionBetween(2, 30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        linkedList.RemoveLastNode();
                        linkedList.Dislpay();
                        break;

                    case 2:
                        Stack stack = new Stack();
                        stack.push(70);
                        stack.push(30);
                        stack.push(56);
                        stack.Peek();
                        stack.Pop();
                        stack.Display();
                        stack.isEmpty();
                        break;

                    case 3:
                        Queue queue = new Queue();
                        queue.Enqueue(56);
                        queue.Enqueue(30);
                        queue.Enqueue(70);
                        queue.Dequeue();
                        queue.Display();
                        break;

                    case 4:
                        HashTable<string, int> hashtable = new HashTable<string, int>(6);
                        string[] words = { "to", "be", "or", "not", "to", "be" };
                        int count = 1;
                        foreach (string word in words)
                        {
                            count = hashtable.CheckHash(word);
                            if (count > 1)
                            {
                                hashtable.Add(word, count++);
                            }
                            else
                            {
                                hashtable.Add(word, 1);
                            }
                        }
                        IEnumerable<string> uniqueItems = words.Distinct<string>();
                        foreach (var i in uniqueItems)
                        {
                            hashtable.Display(i);
                        }
                        break;

                    case 5:
                        HashTable<string, int> hashtable1 = new HashTable<string, int>(10);
                        string[] paragraph;

                        string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        paragraph =input.Split(' '); //Given String Input
                        
                        int counts = 1;
                        foreach (string word in paragraph)
                        {
                            count = hashtable1.CheckHash(word);
                            if (counts > 1)
                            {
                                hashtable1.Add(word, counts++);
                            }
                            else
                            {
                                hashtable1.Add(word, 1);
                            }
                        }
                        IEnumerable<string> distinctItems = paragraph.Distinct<string>();
                        foreach (var i in distinctItems)
                        {
                            hashtable1.Display(i);
                        }
                        break;

                    case 6:
                        HashTable<string, int> myMap1 = new HashTable<string, int>(10);
                        string[] paragraph1;
                        string input1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        paragraph1 = input1.Split(' ');

                        int count1 = 1;
                        foreach (string i in paragraph1)
                        {
                            counts = myMap1.CheckHash(i);
                            if (count1 > 1)
                            {
                                myMap1.Add(i, counts++);
                            }
                            else
                            {
                                myMap1.Add(i, 1);
                            }
                        }
                        IEnumerable<string> unique = paragraph1.Distinct<string>();
                        Console.WriteLine("\nEnter the word which you want to remove in paragraph");
                        string removeWord = Console.ReadLine();
                        myMap1.Remove(removeWord);
                        foreach (var i in unique)
                        {
                            myMap1.Display(i);
                        }
                        break;

                    case 7:
                        BinarySearchTree<int> BST = new BinarySearchTree<int>(10);
                        BST.Insert(30);
                        BST.Insert(70);
                        BST.Display();
                        break;

                    case 8:
                        BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>(40);
                        binarySearchTree.Insert(30);
                        binarySearchTree.Insert(70);
                        binarySearchTree.Insert(22);
                        binarySearchTree.Insert(40);
                        binarySearchTree.Insert(11);
                        binarySearchTree.Insert(3);
                        binarySearchTree.Insert(16);
                        binarySearchTree.Insert(60);
                        binarySearchTree.Insert(95);
                        binarySearchTree.Insert(65);
                        binarySearchTree.Insert(63);
                        binarySearchTree.Insert(67);
                        binarySearchTree.Display();
                        binarySearchTree.GetSize();
                        break;

                    case 9:
                        BinarySearchTree<int> binarySearchTree1 = new BinarySearchTree<int>(40);
                        binarySearchTree1.Insert(30);
                        binarySearchTree1.Insert(70);
                        binarySearchTree1.Insert(22);
                        binarySearchTree1.Insert(40);
                        binarySearchTree1.Insert(11);
                        binarySearchTree1.Insert(3);
                        binarySearchTree1.Insert(16);
                        binarySearchTree1.Insert(60);
                        binarySearchTree1.Insert(95);
                        binarySearchTree1.Insert(65);
                        binarySearchTree1.Insert(63);
                        binarySearchTree1.Insert(67);
                        binarySearchTree1.Display();
                        bool result = binarySearchTree1.Search(63, binarySearchTree1);
                        Console.WriteLine(result);
                        break;

                    case 10:
                        flag = false;
                        break;


                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
                Console.ReadKey();
            }
            
           
            



        }
    }
}
