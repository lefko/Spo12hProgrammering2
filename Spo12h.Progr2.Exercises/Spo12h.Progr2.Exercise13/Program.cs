using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace Spo12h.Progr2.Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            ArrayList myArrayList = new ArrayList();
            List<int> myIntList = new List<int>();

            stopwatch.Start();

            for (int i = 0; i < 10000000; i++)
            {
                myArrayList.Add(i);
            }

            stopwatch.Stop();

            Console.WriteLine("arrayList - Elapsed milliseconds: " + stopwatch.ElapsedMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();

            for (int i = 0; i < 10000000; i++)
            {
                myIntList.Add(i);
            }

            stopwatch.Stop();

            Console.WriteLine("List - Elapsed milliseconds: " + stopwatch.ElapsedMilliseconds);


        }
    }
}
