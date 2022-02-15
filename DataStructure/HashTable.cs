using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    //Value type Data type KeyValue
    public struct KeyValue<K, V>
    {
        public K Key { get; set; }
        public V Value { get; set; }
    };
    public class HashTable<K, V>
    {
        int size;
        public LinkedList<KeyValue<K, V>>[] items;
        public HashTable(int size)
        {
            this.size = size;
            this.items=new LinkedList<KeyValue<K, V>>[size];
        }
        
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K,V>> LinkedListOfPosition = GetLinkedListOfPosition(position);
            KeyValue<K, V> keyvalue = new KeyValue<K, V>()
            {
                Key = key,
                Value = value
            };
            LinkedListOfPosition.AddLast(keyvalue);
        }
        //Step 1: Get array position
        public int GetArrayPosition(K key)
        {
            int hashcode = key.GetHashCode();
            int position = hashcode % size;
            return Math.Abs(position);
        }
        //Step 2: Create linkedlist for a particular position
        public LinkedList<KeyValue<K,V>> GetLinkedListOfPosition( int position)
        {
            if (items[position] == null)
            {
                items[position] = new LinkedList<KeyValue<K, V>>();
            }
            return items[position];
        }
        // Check if element is already Present
        public int CheckHash(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedListOfPosition = GetLinkedListOfPosition(position);
            int count = 1;
            bool found = false;
            KeyValue<K, V> founditem = default(KeyValue<K, V>);

            foreach (KeyValue<K, V> items in LinkedListOfPosition)
            {
                if (items.Key.Equals(key))
                {
                    count= Convert.ToInt32(items.Value) + 1;
                    found = true;
                    founditem = items;

                }

            }
            if (found)
            {
                LinkedListOfPosition.Remove(founditem);
                return count;

            }
            else
            {
                return 1;
            }
        }
        //Remove an iteam within a array
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedListOfPosition = GetLinkedListOfPosition(position);
            bool itemFound = false;
            KeyValue<K, V> founditem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> keyValue in LinkedListOfPosition)
            {
                if (keyValue.Key.Equals(key))
                {
                    itemFound = true;
                    founditem = keyValue;
                }
            }
            if (itemFound)
            {
                LinkedListOfPosition.Remove(founditem);

            }
        }
        //Display Linkedlist elements for particular key
        public void Display(K key)
        {
             int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> LinkedListOfPosition = GetLinkedListOfPosition(position);
            foreach (KeyValue<K, V> keyvalue in LinkedListOfPosition)
            {
                if (keyvalue.Key.Equals(key))
                {
                    Console.WriteLine("Key:"+ keyvalue.Key + "\t Value:" + keyvalue.Value);
                }
            }
                
        }
            
                
            
        
    }
}
