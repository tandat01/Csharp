using System;
using System.Collections;
using System.Collections.Generic;

namespace T1809E_CShrap
{
    public class Product
    {
        public int ProductID;
        public string Name;
        public decimal Price;

        public Product()
        {
        }

        public Product(int productId, string name, decimal price)
        {
            ProductID = productId;
            Name = name;
            Price = price;
        }

        public int ProductId
        {
            get => ProductID;
            set => ProductID = value;
        }

        public string Name1
        {
            get => Name;
            set => Name = value;
        }

        public decimal Price1
        {
            get => Price;
            set => Price = value;
        }

        public void Display()
        {
            Console.WriteLine("Nhap id");
            ProductID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nhap Name");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap price");
            Price = Convert.ToDecimal(Console.ReadLine());
        }

        public void Show()
        {
            Console.WriteLine("Id la: "+ProductID);
            Console.WriteLine("Name la: "+Name);
            Console.WriteLine("Price la: "+Price);
        }

        public void Add(List<Product> list)
        {
            Console.WriteLine("Nhap id");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Nhap Name");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap price");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            
            Product n=new Product(id,name,price);
            
            list.Add(n);

        }

        public void Delete()
        {
            Console.WriteLine("Nhap id");
            bool b = false;
            
        }
    }
}