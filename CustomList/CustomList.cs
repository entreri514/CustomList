using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        public T[] items;
        public int capacity;
        public int count;
        public T[] temp;

        
        //Constructor
        public CustomList()
        {
            capacity = 4;
            count = 0;
            items = new T[capacity];
        }

        //Member Methods (CAN DO)
        public void Add(T item)
        {
            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
            items[count] = item;
            count++;
            if (count == capacity)
            {
                temp = new T[capacity + 5];
                for (int i = 0; i < capacity; i++)
                {
                    temp[i] = items[i];
                }
                capacity = capacity + 5;
                items = new T[capacity];
                for (int i = 0; i < capacity; i++)
                {
                    items[i] = temp[i];
                    
                }
            }        
        }
        public bool Remove(T item)
        {
            if (items.Contains(item))
            {                
                
                
                temp = new T[capacity];
                for (int i=0;i<count;i++)
                {
                    temp[i] = items[i+1];
                }
                for (int i=0;i<count;i++)
                {
                    items[i] = temp[i]; 
                }
                count--;
                return true;
            }
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            return false;
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            return "";
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
