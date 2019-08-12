using System;
using System.Collections.Generic;


namespace T1809E_CShrap
{
    public class Chay:Product
    {
        public static void Main(string[] args)
        {
            Product p=new Product();
            bool cont = true;
            
            do {
                Console.WriteLine("Chọn chức năng : [1. Add product records : " +
                                  "2.Display product records : " +
                                  "3.Delete product by ID :  " +
                                  "4.  Thoát]");
                int chon = Convert.ToInt16(Console.ReadLine());
                switch (chon) {
                    case 1:
                        Console.WriteLine("Thực hiện chức năng 1");
                        p.Add(null);
                        p.Show();
                        break;
                    case 2:
                        Console.WriteLine("Thực hiện chức năng 2");
                        p.Display();
                        p.Show();
                        break;
                    case 3:
                        Console.WriteLine("Thực hiện 3");
                        p.Delete();
                        break;
                    default:
                        Console.WriteLine("Tạm biệt");
                        cont = false;
                        break;
                }
            } while (cont);    
        }
    }
}