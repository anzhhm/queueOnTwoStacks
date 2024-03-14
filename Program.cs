using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StacksToQueue<int> stackIsTheNewQueue = new StacksToQueue<int>();
           // stackIsTheNewQueue.Dequeue();

            stackIsTheNewQueue.AddToQueue(1);
            stackIsTheNewQueue.AddToQueue(2);
            stackIsTheNewQueue.AddToQueue(3);

            stackIsTheNewQueue.Dequeue();
            stackIsTheNewQueue.Dequeue();

            stackIsTheNewQueue.AddToQueue(4); ;

        }
        
        
    }
}
