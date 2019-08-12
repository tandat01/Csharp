using System;
using System.Collections.Generic;

namespace T1809E_CShrap
{
    public class LabSecsion8<E>
    {
        public E val_1;
        public E val_2;
    }

    public class PhoneNumer<K, V>
    {
        public K name;
        public V phone;
        /*
         K: key
         V: value
         E: element
         N:number
        */

        public void ShowParam<T>(T x)  where T:Human
        {
            Console.WriteLine(x);
        }

    }

    public class Human
    {
        public int age;
    }

    public class Asia : Human
    {
        
    }

    public class Generic<E> where E:Human
    {
        public E hm;

        public void ShowInfo()
        {
            Console.WriteLine(hm.age);
        }
        
    }
    

    public class Secssion8Main
    {
        public static void Main()
        {
            LabSecsion8<int> ss8=new LabSecsion8<int>();
            LabSecsion8<string> ss7=new LabSecsion8<string>();

            ss8.val_1 = 007;
            ss8.val_2 = 12;

            ss7.val_1 = "what sup";
            ss7.val_2 = "hello";
            PhoneNumer<string,string>p1=new PhoneNumer<string, string>();
            PhoneNumer<string,List<string>>p2=new PhoneNumer<string, List<string>>();
            
            /*p2.ShowParam(6);
            p2.ShowParam("abc xyz");*/
            List<int> arr=new List<int>();
            
            Generic<Human> g1=new Generic<Human>();
            Generic<Asia> g2=new Generic<Asia>();
            
        }
    }
}