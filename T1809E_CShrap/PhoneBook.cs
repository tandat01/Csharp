using System;
using System.Collections;
using System.Collections.Generic;

namespace T1809E_CShrap
{
    public delegate void ChangeValue(string s);
    public class PhoneBook : Phone
    {
        public event ChangeValue PhoneChange;
        
        public List<PhoneNumber> PhoneList=new List<PhoneNumber>();
        
        
        public override bool insertPhone(string name, string phone)
        {
            if (PhoneList ==null)
            {
                PhoneList=new List<PhoneNumber>();
            }
            
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    if (!p.Phone.Equals(phone))
                    {
                        p.Phone += ":" + phone;
                        return true;
                    }

                    return false;
                }
            } 
            PhoneList.Add(new PhoneNumber(name,phone));
            return true;
        }

        public override bool removePhone(string name)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    PhoneList.Remove(p);
                    return true;
                }
            }

            return false;
        }

        public override bool updatePhone(string name, string newphone)
        {
            foreach (PhoneNumber p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    p.Phone = newphone;
                    if (PhoneChange ==null)
                    {
                        PhoneChange += Notify;
                    }
                    PhoneChange("So dien thoai cua"+ name +" da bi thay doi");
                    return true;
                }
            }

            return false;
        }

        public static void Notify(string s)
        {
            Console.WriteLine(s);
        }

        public override PhoneNumber searchPhone(string name)
        {
            foreach (PhoneNumber p in  PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }

            return null;
        }
    }
}