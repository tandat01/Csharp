using  System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {
            /*List<Student> stList = new List<Student>();
            for (int i = 0; i < 3; i++)
            {
                stList.Add(new Student());
            }

            foreach (Student student in stList)
            {
                student.ShowInfo();
            }
            Student st = new Student();*/
            // st.name = Console.ReadLine();
            //  st.age = Convert.ToInt32(Console.ReadLine());
            //st.ShowInfo(5);
            
            // Chua bai tap ve nha
             int n;
             n = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("So Fibonaci thu "+n+" la: "+Fibo(n));
        }

        static int Fibo(int n)
        {
            if (n == 1 || n == 2) return 1;
            if (n == 3) return 2;
            int x1 = 1, x2 = 1, x3 = 2;
            for (int i = 4; i <= n; i++)
            {
                x1 = x2;
                x2 = x3;
                x3 = x1 + x2;
            }
            return x3;
        }
    }
}
