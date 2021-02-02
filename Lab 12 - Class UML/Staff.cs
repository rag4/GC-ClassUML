using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___Class_UML
{
    class Staff : Person
    {
        private string school { get; set; }
        private double pay { get; set; }

        public Staff(string Name, string Address, string School, double Pay) : base(Name, Address)
        {

            this.school = School;
            this.pay = Pay;
        }

        public override string ToString()
        {
            string output = "Staff[";
            output += $"name={this.name},";
            output += $"address={this.address},";
            output += $"school={this.school},";
            output += $"pay={this.pay},";
            output += "]";

            return output;
        }
    }
}
