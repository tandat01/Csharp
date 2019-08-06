using System;
using System.Threading;

namespace T1809E_CShrap
{
    public class Session6
    {
        public static void Main(string[] args)
        {
            Thread t1=new Thread(SayHello2);
            t1.Start("abc xyz");
            /*Session6 s=new Session6();
            Thread t2=new Thread(s.SayHello3);*/
            Thread t2=new Thread(new Session6().SayHello3);
            t2.Start();
            SayHello();
            
            Thread t3=new Thread(delegate()
            {
                Console.WriteLine("Thread t3 ...");
            });
            t3.Start();
            int aaa = 28383;
            Thread t4=new Thread(delegate(object o)
            {
                Console.WriteLine("thread t4...");
            });
            t4.Start("Tham so can truyen ");
            
            SayHello();
        }
        
        

        public static void SayHello()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+"- hello world");
                Thread.Sleep(100);
            }
        }
        public static void SayHello2(object o)
        {
            string s=(string) o;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i+"- hello world 2");
                Thread.Sleep(100);
            }
        }
         public void SayHello3()
                {
                    for (int i = 0; i < 100; i++)
                    {
                        Console.WriteLine(i+"- hello world 3");
                        Thread.Sleep(100);
                    }
                }
    }
}