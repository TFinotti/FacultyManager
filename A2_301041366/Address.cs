using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_301041366
{
    [Serializable]
    public struct Address
    {
        private string streetAddress;
        private string city;
        private string province;

        public Address(string street, string city, string province)
        {
            streetAddress = street;
            this.city = city;
            this.province = province;

        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Province
        {
            get { return province; }
            set { province = value; }
        }
    }
}
