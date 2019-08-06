using System;
using System.Threading;

namespace T1809E_CShrap
{
    public class Boom
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int phut = 10;
           
            for (int i = (phut-1); i >=0; i--)
            {
                for (int j = 59; j >=0 ; j--)
                {
                    Console.WriteLine(i.ToString("D2")+ ":"+j.ToString("D2"));
                    Thread.Sleep(100);
                }
                
            }
            Console.WriteLine("Boom do chay di...!!!!!");
        }
    }
}