using System;
using System.Collections;

namespace Pr4S1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyList = new ArrayList();
            MyList.Add("First");
            MyList.Add("Second");
            MyList.Add("Third");
            MyList.Add("Fourth");

            foreach (string item in MyList)
            {
                Console.WriteLine("Unsorted: {0}", item);
            }

            MyList.Sort();

            foreach (string item in MyList)
            {
                Console.WriteLine("Sorted: {0}", item);
            }
        }
    }
}
