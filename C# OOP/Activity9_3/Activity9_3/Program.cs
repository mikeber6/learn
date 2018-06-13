using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack<string> moveStack = new Stack<string>();
            //Console.WriteLine("Loading Stack");
            //for (int i = 1; i<=5; i++)
            //{
            //    moveStack.Push("Move " + i.ToString());
            //    Console.WriteLine(moveStack.Peek().ToString());
            //}

            //Console.WriteLine("Press the enter key to unload the stack");
            //Console.ReadLine();

            //for (int i = 1; i <= 5; i++)
            //{                
            //    Console.WriteLine(moveStack.Pop().ToString());
            //}
            //Console.ReadLine();

            Queue<string> requestQueue = new Queue<string>();
            Console.WriteLine("Loading Queue");
            for (int i = 1; i <= 5; i++)
            {
                requestQueue.Enqueue("Request " + i.ToString());
                Console.WriteLine(requestQueue.Peek().ToString());
            }

            Console.WriteLine("Press the enter key to unload the queue");
            Console.ReadLine();

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(requestQueue.Dequeue().ToString());
            }
            Console.ReadLine();



        }
    }
}
