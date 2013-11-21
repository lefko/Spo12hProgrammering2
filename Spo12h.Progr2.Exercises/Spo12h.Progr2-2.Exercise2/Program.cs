using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spo12h.Progr2_2.Exercise2.Classes;

namespace Spo12h.Progr2_2.Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            // CODE FOR cUSTOMsTACK class
            CustomStack<int> intStack = new CustomStack<int>();
            CustomStack<string> strStack = new CustomStack<string>();

            //intStack.Push(5);
            //intStack.Push(10);

            //strStack.Push("Hej");
            //strStack.Push("Laban");

            try
            {

                // CODE FOR cUSTOMqUEUE CLASS

                //CustomQueue<int> intQueue = new CustomQueue<int>();
                //CustomQueue<string> strQueue = new CustomQueue<string>();

                //// Add items to int queue
                //intQueue.EnqueueBack(5);
                //intQueue.EnqueueBack(10);
                //intQueue.EnqueueBack(15);

                //// Add items to string queue
                //strQueue.EnqueueBack("Hello");
                //strQueue.EnqueueBack("Why");
                //strQueue.EnqueueBack("Fine then");
                //strQueue.EnqueueFront("Front Enque");

                ////See if the int queue is working
                //Console.Write("Peek the int Quee: ");
                //Console.WriteLine(intQueue.Front());

                //Console.Write("Deque first from int Queue: ");
                //Console.WriteLine(intQueue.DequeueFront());

                //// See if string qeue is working
                //Console.Write("Peek the int Quee: ");
                //Console.WriteLine(intQueue.Front());

                //Console.Write("Peek the str Quee: ");
                //Console.WriteLine(strQueue.Front());

                //Console.Write("Deque first from str Queue: ");
                //Console.WriteLine(strQueue.DequeueFront());


                //Console.Write("Peek the str Quee: ");
                //Console.WriteLine(strQueue.Front());


               

                

                Console.WriteLine("Peek the int Stack");
                Console.WriteLine(intStack.Peek());

                Console.WriteLine("Peek the string Stack");
                Console.WriteLine(strStack.Peek());

                Console.WriteLine("Int Pop");
                var intPop = intStack.Pop();
                Console.WriteLine(intPop);
                Console.WriteLine("Peek the int Stack");
                Console.WriteLine(intStack.Peek());

                Console.WriteLine("String Pop");
                var strPop = strStack.Pop();
                Console.WriteLine(strPop);
                Console.WriteLine("Peek the string Stack");
                Console.WriteLine(strStack.Peek());
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Oopps..expression was thrown");
            }

            Console.ReadLine();

        }
    }
}
