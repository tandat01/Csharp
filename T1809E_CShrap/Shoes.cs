using System;

namespace T1809E_CSharp
{
    public class Shoes : Product,IProducts
    {
        public void KiemTraGiaTien()
        {
            
        }
                
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("Day la san pham giay dep");
        }

        public override void TinhTien()
        {
            
        }
        
        public new bool CheckQty()
        {
            if (qty > 1)
            {
                return true;
            }
            return false;
        }
    }
}