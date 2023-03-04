using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSample
{
    internal class ThreadSample1
    {
        object o;
        Thread trd1;
        Thread trd2;

        int val1 = 0;
        int val2 = 0;
        public ThreadSample1()
        {
            o = new();

            trd1 = new(() => { val1 = DoWorkX(); });
            trd2 = new(() => { val2 = DoWorkY(); });

            trd1.Start();
            trd2.Start();

            

            Console.Read();

        }

        private int DoWorkX()
        {
            lock (o)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("X : " + i);
                }
            }
            return 0; // 0 return value means finish
        }
        private int DoWorkY()
        {
            lock (o)
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine("Y : " + i);
                }
            }
            return 0; // 0 return value means finish
        }
      

    }
}
