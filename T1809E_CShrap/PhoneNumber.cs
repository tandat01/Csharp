namespace T1809E_CShrap
{
    public class PhoneNumber
    {
        private string name;
        private string phone;

        public PhoneNumber()
        {
        }

        public PhoneNumber(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }
    }
    
}