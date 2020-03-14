using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualBarBackend.Models
{
    public class UserModel
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private int Age { get; set; }

        public UserModel(int id, string name, int age)
        {
            this.Id = id;
            Name = name;
            Age = age;
        }


        public override string ToString()
        {
            return this.Name + this.Id + this.Age;
        }
    }
}
