using System;
using System.Collections.Generic;
using System.Text;

namespace OOPsConcepts
{
    class GenericCollectionsDemo
    {
        static void Main()
        {
            //ArrayList   > List
            List<int> list = new List<int>();
            list.Add(100);
            list.Add(200);

            Stack<string> stack = new Stack<string>();
            stack.Push("ajay");
            stack.Push("deepak");


            Queue<float> queue = new Queue<float>();
            queue.Enqueue(10.9f);

            //Dictionary<int, int> scores = new Dictionary<int, int>();
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores["ajay"] = 90;
            scores["deepak"] = 98;

        }
    }
}
