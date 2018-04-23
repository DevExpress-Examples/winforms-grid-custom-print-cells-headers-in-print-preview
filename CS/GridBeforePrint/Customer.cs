using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GridBeforePrint
{
    class Customer
    {
        private string firstName;
        private string lastName;
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public Customer() { }

        public Customer(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
    }
}
