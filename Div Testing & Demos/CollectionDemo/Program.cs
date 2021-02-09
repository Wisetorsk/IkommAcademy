using System;
using System.Collections.Generic;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "Oslo",
                "Amsterdam",
                "Stockholm",
                "Madrid"
            };

            var moreCities = new string[] {"London", "Burkina Faso"};
            list.AddRange(moreCities);
            Console.WriteLine(list.Count);

            list.ForEach(Console.WriteLine);

            var queueInt = new Queue<int>(); // Has a "guaranteed ordering" FiFo - system. First in, first out. 
            queueInt.Enqueue(9);
            queueInt.Enqueue(8);
            queueInt.Enqueue(7);
            queueInt.Enqueue(6);
            queueInt.Enqueue(5);
            queueInt.Enqueue(4);
            queueInt.Enqueue(3);
            queueInt.Enqueue(2);
            queueInt.Enqueue(1);
            queueInt.Enqueue(0);

            for (int i = 0; i < 5; i++) Console.Write(queueInt.Dequeue() + ", "); //Dequeue five numbers. Output should be 9, 8, 7, 6, 5


            var lifoString = new Stack<string>(); //LiFo Object, Last in, first out. 
            lifoString.Push("First Added");
            lifoString.Push("Second Added");
            lifoString.Push("Third Added");
            lifoString.Push("Fourth Added");

            while (lifoString.Count > 0)
            {
                Console.WriteLine(lifoString.Pop());
            }

        }
    }
}
