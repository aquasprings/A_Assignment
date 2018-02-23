using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBO
{
    public class Customerbo
    {
        int id;
        string name;
        string gender;
        DateTime dob;
        long contact;
        string city;

        public Customerbo(int id, string name, string gender, DateTime dob, long contact, string city)
        {
            this.Id = id;
            this.Name = name;
            this.Gender = gender;
            this.Dob = dob;
            this.Contact = contact;
            this.City = city;
        }
        

        public Customerbo(string name, string gender, DateTime dob, long contact, string city)
        {
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.contact = contact;
            this.city = city;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public long Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        
    }
}
