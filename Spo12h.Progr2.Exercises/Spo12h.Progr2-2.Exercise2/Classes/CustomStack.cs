using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spo12h.Progr2_2.Exercise2.Classes
{
    public class CustomStack<T>
    {
        public List<T> myList;

        public CustomStack()
        {
            myList = new List<T>();
        }
    
        public T Peek()
        {
            return myList.Last();
        }

        public T Pop()
        {
            var toReturn = myList.Last();
            myList.Remove(myList.Last());

            return toReturn;

        }

        public void Push(T item)
        {
            myList.Add(item);
        }
    }
}
