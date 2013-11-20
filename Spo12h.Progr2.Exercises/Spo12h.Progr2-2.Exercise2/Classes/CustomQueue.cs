using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2_2.Exercise2.Classes
{
    public class CustomQueue<T>
    {
        public List<T> myQueue;

        public CustomQueue()
        {
            myQueue = new List<T>();
        }

        public T Front()
        {
            return myQueue.First();
        }

        public T Back()
        {
            return myQueue.Last();
        }

        public T DequeueFront()
        {
            var myItem = myQueue.First();
            myQueue.RemoveAt(0);

            return myItem;
        }

        public T DequeueBack()
        {
            var myItem = myQueue.Last();
            myQueue.Remove(myItem);

            return myItem;
        }

        public void EnqueueBack(T item)
        {
            myQueue.Add(item);
        }

        public void EnqueueFront(T item)
        {
            myQueue.Insert(0, item);
        }
    }
}
