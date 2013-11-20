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

        public T Peak()
        {
            return myQueue.First();
        }

        public T Dequeue()
        {
            var myItem = myQueue.First();
            myQueue.RemoveAt(0);

            return myItem;
        }

        public void Enqueue(T item)
        {
            myQueue.Add(item);
        }
    }
}
