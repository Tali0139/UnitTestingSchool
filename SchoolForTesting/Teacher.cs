using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolForTesting
{
   public class Teacher:Person
    {
        private int _salary;

        public Teacher(string name, string address, Gender genderValue, int salary) : base(name, address, genderValue)
        {
            Name = name;
            Address = address;
            GenderValue = genderValue;
            Salary = salary;

        }

        public int Salary
        {
            get => _salary;
            set
            {
                if (value <0) throw new ArgumentOutOfRangeException();
                _salary = value;
            }
        }
    }
}
