using System;
using System.Collections.Generic;

namespace T1809E_CSharp
{
    public delegate void Showdeget(string s);
    public  class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery;

        public Product()
        {
            this.gallery = new List<string>();
        }

        public Product(int id, string name, decimal price, int qty, 
            string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = new List<string>();
        }

        public string this[int index]
        {
            get
            {
                return "aaaa"+gallery[index];
            }
            set
            {
                if (value.Length > 10)
                {
                    gallery[index] = value;
                }
            }
        }
            
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => price;
            set
            {
                price = value;
            }
        }

        public int Qty
        {
            get => qty;
            set
            {
                qty = value;
            }
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public virtual void TinhTien()
        {
            Product p = new Product();
            p.gallery.Add("hello world");
            p.gallery.Add("good morning");
            
            Console.WriteLine(p.gallery[0]);
            Console.WriteLine(p[0]);
            p.gallery[1] = "ahihi đồ ngốc";
            p[1] = "abc xyz";
        }

        public virtual void GetInfo()
        {
            
            Console.WriteLine("id: "+id);
            Console.WriteLine("name: "+name);
            Console.WriteLine("price: "+price);
            Console.WriteLine("qty: "+qty);
            Console.WriteLine("image: "+ this.Image);
            Console.WriteLine("desc: "+desc);
            this.Image = "abc efj";
            foreach (string s in gallery)
            {
                Console.WriteLine(s);
            }
        }

        public bool CheckQty()
        {
            if (qty > 0)
            {
                return true;
            }
            return false;
        }

        public bool AddGallery(string img)
        {
            if (gallery.Count < 10)
            {
                gallery.Add(img);
                return true;
            }
            Console.WriteLine("Vượt quá số ảnh cho phép");
            return false;
        }

        public void AddGallery2()
        {
            if (gallery.Count < 10)
            {
                string img = Console.ReadLine();
                gallery.Add(img);
                return;
            }
            Console.WriteLine("Vượt quá số ảnh cho phép");
        }

        public void RemoveGallery()
        {
            int i = 0;
            foreach (string s in gallery)
            {
                Console.WriteLine(i+". "+ s);
                i++;
            }
            Console.WriteLine("Nhập vị trí ảnh muốn xóa:");
            int n = Convert.ToInt16(Console.ReadLine());
            gallery.RemoveAt(n);
        }

        public bool RemoveGallery(int n)
        {
            if (n < gallery.Count)
            {
                gallery.RemoveAt(n);
                //gallery.Remove("afafaafa");
                return true;
            }
            Console.WriteLine("không tìm thấy hoặc không thể xóa ");
            return false;
            
        }
        
    }

}
