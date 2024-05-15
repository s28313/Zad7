using System;
using System.Xml.XPath;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args) {
            int[] arr = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };
            
            var t = LinqTasks.Task16();

            //Console.WriteLine(t);
            

            foreach (var emp  in t)
            {
                Console.WriteLine(emp);
            }
            
        }

    }
}
