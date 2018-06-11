using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Models
{
    public class Address
    {
        public Address(string address, string city, string state, string zip)
        {
            this.Address1 = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            
        }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }


        public override string ToString()
        {
            return $"{Address1} {City} {State} {Zip}";
        }


        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }


    }
}
