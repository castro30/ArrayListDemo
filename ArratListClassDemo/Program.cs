using System;
using System.Collections;


namespace ArratListClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates and initializes a new array list
            ArrayList newal = new ArrayList();
            newal.Add("Alice");
            newal.Add("in");
            newal.Add("Wonderland");
            newal.Add("Walks in DreamLand");
            newal.Add("For the first time");


            // Display the properties and values of an ArrayList
            Console.WriteLine("New ArrayList");
            Console.WriteLine("Count {0}", newal.Count);
            Console.WriteLine("Capacity {0}", newal.Capacity);

            Console.WriteLine(" - Elements -");
            PrintElements(newal);
            Console.WriteLine();

            //Display the Foreach Example
            ForEachClass numbs = new ForEachClass();
            ForEachClass people = new ForEachClass();
            numbs.PrintNumbers();
            people.SayHi();
            Console.WriteLine();

            //Creates and initializes a new Sorted List
            SortedList newsl = new SortedList();
            newsl.Add("First", "Alice");
            newsl.Add("Second", "Wonderland");
            newsl.Add("Third", "Dreamland");

            //Displays the properties and values of the Sorted List
            Console.WriteLine("newsl");
            Console.WriteLine("Count: {0}", newsl.Count);
            Console.WriteLine("Capacity: {0}", newsl.Capacity);

            PrintElementsSL(newsl);
            Console.WriteLine();
            PrintElementDiff(newal);

            Console.ReadLine();

        }
        public static void PrintElements(ArrayList mylist)
        {
            foreach(string item in mylist)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintElementsSL(SortedList mylist)
        {
            Console.WriteLine("Keys and Values:");
            for (int i=0; i<mylist.Count;i++)
            {
                Console.WriteLine("\t{0}:\t{1}",mylist.GetKey(i),mylist.GetByIndex(i));

            }
            Console.WriteLine();
        }

        public static void PrintElementDiff(IEnumerable mylist)
        {
            System.Collections.IEnumerator myEnumberator = mylist.GetEnumerator();
            while (myEnumberator.MoveNext())
            {
                Console.WriteLine("\t{0}", myEnumberator.Current);
            }
        }
    }
}
