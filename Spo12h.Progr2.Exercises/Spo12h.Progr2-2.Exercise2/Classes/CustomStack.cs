using System;
using System.Collections.Generic;
using System.Data;
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
            // return myList.Last(); //also works
            EnsureNotEmpty();
            return myList[End()];
        }

        public T Pop()
        {
            EnsureNotEmpty();

            var toReturn = myList.Last();
            myList.RemoveAt(End());
            // myList.Remove(myList.Last()); //This will not work because Remove searches the list fr the start. .Last() dont work in this context

            return toReturn;

        }

        public void Push(T item)
        {
            myList.Add(item);
        }

        private int End()
        {
            return myList.Count - 1;
        }

        private void EnsureNotEmpty()
        {
            if (myList.Count == 0)
                throw new InvalidOperationException("Stack Empty");
        }
    }
}
