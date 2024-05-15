using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task11();
            
            //Console.WriteLine(t);

            foreach (var emp  in t)
            { 
                Console.WriteLine(emp);
            }
            

        }
        
    }
}
