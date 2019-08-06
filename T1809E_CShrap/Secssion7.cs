using System;
using System.Threading;
using Console = System.Console;

namespace T1809E_CShrap
{
    public class Secssion7
    {
        public static void Main(string[] args)
        {
            Numberic n = new Numberic();
            Thread t1 = new Thread(delegate() {
                for (int i = 0; i < 100; i++)
                {
                    lock (n)
                    {
                        Console.WriteLine("t1 - "+n.age);
                        n.age++; 
                    }
                    Thread.Sleep(300);
                }
            });
            
            Thread t2 = new Thread(delegate() {
                for (int i = 0; i < 100; i++)
                {
                    lock (n)
                    {
                        Console.WriteLine("t2 - "+n.age);
                        n.age++;
                    }
                    Thread.Sleep(300);
                }
            });
            t1.Start();
            // t1.Join();
            t2.Start();
        }
    }

    public class Numberic
    {
        public int age = 0;
    }
}
