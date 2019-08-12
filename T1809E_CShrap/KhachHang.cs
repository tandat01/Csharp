using System;

namespace T1809E_CShrap
{
    public class KhachHang
    {
        public int id;
        public string name;
        public DateTime date;
        public string doituong;
        public int soluong;
        public decimal dongia;
        public int dinhmuc;

        public KhachHang()
        {
        }

        public KhachHang(int id, string name, DateTime date, string doituong, int soluong, decimal dongia, int dinhmuc)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.doituong = doituong;
            this.soluong = soluong;
            this.dongia = dongia;
            this.dinhmuc = dinhmuc;
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

        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        public string Doituong
        {
            get => doituong;
            set => doituong = value;
        }

        public int Soluong
        {
            get => soluong;
            set => soluong = value;
        }

        public decimal Dongia
        {
            get => dongia;
            set => dongia = value;
        }

        public int Dinhmuc
        {
            get => dinhmuc;
            set => dinhmuc = value;
        }


        public void Nhap()
        {
            Console.WriteLine("Nhap id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap ten ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Nhap ngay ");
            date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap doi tuong khach hang ");
            doituong = Convert.ToString(Console.ReadLine());
            Console.WriteLine("NHap so luong ");
            soluong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap don gia ");
            dongia = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Nhap dinh muc ");
            dinhmuc = Convert.ToInt32(Console.ReadLine());
        }

        public void Xuat()
        {
            Console.WriteLine("Id la: "+id);
            Console.WriteLine("Ten la: "+name);
            Console.WriteLine("Ngay la: "+date);
            Console.WriteLine("Doi tuong la: "+doituong);
            Console.WriteLine("So luong la: "+soluong);
            Console.WriteLine("Don gia la: "+dongia);
            Console.WriteLine("Dinh muc la: "+dinhmuc);
        }

        public void Thanhtien(decimal thanhtien)
        {
            if (soluong<=dinhmuc)
            {
                thanhtien = soluong * dongia;
            }
            else
            {
                thanhtien = soluong * dongia;
            }
        }

        public static void Main(string[] args)
        {
            KhachHang n=new KhachHang();
            n.Nhap();
            n.Xuat();
        }
        
    }
}