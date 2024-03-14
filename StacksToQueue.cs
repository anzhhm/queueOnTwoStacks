using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _120324
{
    public class StacksToQueue<T>
    {
        private Stack <T> inbox = new Stack <T> ();
        private Stack <T> outbox = new Stack <T> ();
        public StacksToQueue(){  }

        public void AddToQueue(T elem)
        {
            inbox.Push(elem);
        }
        public void Dequeue()
        {
            if (inbox.Count == 0&& outbox.Count==0) {
                throw new Exception("The queue is empty");
            }
            if (outbox.Count == 0)
            {
                while (inbox.Count > 0) {
                    T element = inbox.Pop();
                    outbox.Push(element);
                }
                outbox.Pop();
            }
            else
            {
                outbox.Pop ();
            }
        }
    }
}
