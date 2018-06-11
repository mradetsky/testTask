using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Models
{
    public class Customer : BaseModel
    {
        public Customer(string firstName, string lastName, Address address) : base()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public void Save(){
            Save(this);
        }

        public void Delete()
        {
            Delete(this);
        }


        public static Customer Find(string id){
            return Find<Customer>(id);
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} Address:{Address}";
        }

        

    }
}
