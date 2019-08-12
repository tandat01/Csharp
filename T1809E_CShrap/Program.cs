using System;

namespace T1809E_CShrap
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("nhap so n");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n%2==0)
            {
                Console.WriteLine("la so chan: "+n);
            }
            else
            {
                Console.WriteLine("la so le: "+n);
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("nhap so x");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x%2!=0)
            {
                Console.WriteLine("so nguyen to: "+x);
            }
            else
            {
                Console.WriteLine("kh phai so nguyen to: "+x);
                
            }
            
        }
    }
}