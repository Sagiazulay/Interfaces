using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Human
    {
        private int _age;
        string Name { get; set; }
        public int GetAge()
        {
            return _age;
        }
        public Human(string name, int age)
        {
            Name = name;
            this._age = age;
        }

        public override string ToString()
        {
            return $"Name : {Name}, Age : {_age}";
        }
    }
}
