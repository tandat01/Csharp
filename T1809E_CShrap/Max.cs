using System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    public class Max
    {
        public static void Main(String[] args)
        {
            Student st=new Student();
           // st.name = "Nguyen Tan Dat";
           // st.age = 20;
            st.ShowInfo(5);
            
            
            List<int> intArr=new List<int>();
            
            Console.WriteLine("Nhap 10 so :");
            for (int i = 0; (i) < 10; (i)++)
            {
                int x = Convert.ToInt32(Console.ReadLine());/*ham chuyen chuoi thanh so*/
                intArr.Add(x);
            }

            int max = intArr[0];

            foreach (int i in intArr)
            {
                if (max<i)
                {
                    max = i;
                }
            }
            Console.WriteLine("Max ="+max);
        }
    }
}