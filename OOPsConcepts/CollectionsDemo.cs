using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOPsConcepts
{
    class CollectionsDemo
    {
        static void Main()
        {
            //int[] num = new int[10];
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add("ajay");
            list.Add(90.0f);
            

            //for (int i = 0; i < list.Count; i++)
            //    Console.WriteLine(list[i]);
            foreach (var temp in list)
                Console.WriteLine(temp);

            list.Insert(1, 1000);
            Console.WriteLine("After inserting elememn");
            foreach (var temp in list)
                Console.WriteLine(temp);

            list.Remove(1);
            Console.WriteLine("After deleting elememn");
            foreach (var temp in list)
                Console.WriteLine(temp);


            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Push("ajay");
            foreach (var temp in stack)
                Console.WriteLine(temp);

            //stack.Pop();
            //Console.WriteLine("After deleting elememn");
            //foreach (int temp in stack)
            //    Console.WriteLine(temp);


            //Queue queue = new Queue();
            //queue.Enqueue(1000);
            //queue.Enqueue(2000);
            //queue.Enqueue(3000);
            //foreach (int temp in queue)
            //    Console.WriteLine(temp);
            //queue.Dequeue();
            //Console.WriteLine("After deleting elememn");
            //foreach (int temp in queue)
            //    Console.WriteLine(temp);

            // IN these collecions can do we dynamic searching ? NO
            Hashtable ht = new Hashtable();
            ht[1] = 90;
            ht[22] = 87;
            ht[13] = 78;

            Console.WriteLine(ht[22]);
            foreach(int key in ht.Keys)
                Console.WriteLine($"Marks of Rn {key} are {ht[key]}");
            ht.Remove(22);
            Console.WriteLine("After deleting elememn");

            foreach (int key in ht.Keys)
                Console.WriteLine($"Marks of Rn {key} are {ht[key]}");



        }
    }
}
