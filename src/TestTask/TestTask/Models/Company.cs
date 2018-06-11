using System;
using System.Collections.Generic;
using System.Text;

namespace TestTask.Models
{
    public class Company : BaseModel
    {
        public Company(string name, Address address) : base()
        {
            this.Name = name;
            this.Address = address;
        }
        public string Name { get; set; }



        public void Save()
        {
            Save(this);
        }

        public void Delete()
        {
            Delete(this);
        }

        public static Company Find(string id)
        {
            return Find<Company>(id);
        }


        public override string ToString()
        {
            return $"{Name} Address:{Address}";
        }
    }
}
