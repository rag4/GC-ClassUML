using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12___Class_UML
{
    class Student : Person
    {
        private string program { get; set; }
        private int year { get; set; }
        private double fee { get; set; }

        public Student(string Name, string Address, string Program, int Year, double Fee) : base(Name, Address)
        {

            this.program = Program;
            this.year = Year;
            this.fee = Fee;
        }

        public override string ToString()
        {
            string output = "Student[";
            output += $"name={this.name},";
            output += $"address={this.address},";
            output += $"program={this.program},";
            output += $"year={this.year},";
            output += $"fee={this.fee}";
            output += "]";

            return output;
        }
    }
}
