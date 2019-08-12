using System;
using T1809E_CShar;

namespace T1809E_CSharp
{
    public class Pro : Product
    {
        public static void Main(String[] args)
        {
            Product p=new Product();
            boolean cont = true;
            
            do {
                Console.WriteLine("Chọn chức năng : [1. Add product records : " +
                                   "2.Display product records : " +
                                   "3.Delete product by ID :  " +
                                   "4.  Thoát]");
                int chon = input.nextInt();
                switch (chon) {
                    case 1:
                        Console.WriteLine("Thực hiện chức năng 1");
                        p.
                        break;
                    case 2:
                        System.out.println("Thực hiện chức năng 2");
                        break;
                    case 3:

                        break;
                    default:
                        System.out.println("Tạm biệt");
                        cont = false;
                        break;
                }
            } while (cont);    
        }
        
    }
}