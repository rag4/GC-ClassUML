using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___Class_UML
{
    class Person
    {
        public string name { get; set; }
        public string address { get; set; }

        public Person(string Name, string Address)
        {
            this.name = Name;
            this.address = Address;
        }

        public override string ToString()
        {
            string output = "Person[";
            output += $"name={this.name},";
            output += $"address={this.address}";
            output += "]";

            return output;
        }
    }
}
