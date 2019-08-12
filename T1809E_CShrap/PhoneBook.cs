using System;
using System.Collections;
using System.Collections.Generic;

namespace T1809E_CShrap
{
    public delegate void ChangeValue(string s);
    public class PhoneBook : Phone
    {
        public event ChangeValue PhoneChange;
        
        public List<PhoneNumber<List<string>>> PhoneList=new List<PhoneNumber<List<string>>>();
        
        
        public override bool insertPhone(string name, string phone)
        {
            if (PhoneList ==null)
            {
                PhoneList=new List<PhoneNumber<List<string>>>();
            }
            
            foreach (PhoneNumber<List<string>> p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    /*if (!p.Phone.Equals(phone))
                    {
                        p.Phone += ":" + phone;
                        return true;
                    }*/
                    if (!p.Phone.Contains(phone))
                    {
                        p.Phone.Add(phone);
                        return true;
                    }

                    return false;
                }
            } 
            List<string> ls=new List<string>();
            ls.Add(phone);
            PhoneList.Add(new PhoneNumber<List<string>>(name,ls));
            return true;
        }

        public override bool removePhone(string name)
        {
            foreach (PhoneNumber<List<string>> p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    PhoneList.Remove(p);
                    return true;
                }
            }

            return false;
        }

        public override bool updatePhone(string name,string oldphone, string newphone)
        {
            foreach (PhoneNumber<List<string>> p in PhoneList)
            {
                if (p.Name.Equals(name))
                {
                    //p.Phone = newphone;
                    if (p.Phone.Contains(oldphone))
                    {
                        p.Phone.Remove(oldphone);
                    }
                    p.Phone.Add(newphone);
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

        public override PhoneNumber<List<string>> searchPhone(string name)
        {
            foreach (PhoneNumber<List<string>> p in  PhoneList)
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