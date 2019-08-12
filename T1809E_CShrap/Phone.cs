using System.Collections.Generic;

namespace T1809E_CShrap
{
    public abstract class Phone
    {
            
        public abstract bool insertPhone(string name, string phone);
        public abstract bool removePhone(string name);
        public abstract bool updatePhone(string name,string oldphone, string newphone);
        public abstract PhoneNumber<List<string>> searchPhone(string name);   
    }
    
}