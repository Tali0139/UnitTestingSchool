using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolForTesting
{
    public class Person
    {
        private string _name;
        private string _address;
        private Gender _genderValue;

        public Person()
        {
        }

        public Person(string name, string address, Gender genderValue)
        {
            Name = name;
            Address = address;
            GenderValue = genderValue;
        }
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }
        /// <summary>
        /// property Address cannot be null
        /// </summary>
        public string Address
        {
            get => _address;
            set
            {
                if (value == null) throw new ArgumentNullException();
                _address = value;
            }
        }
        public Gender GenderValue
        {
            get => _genderValue;
            set => _genderValue = value;
        }
        /// <summary>
        /// Enummeration, Gender, 2 choices
        /// </summary>
        public enum Gender
        {
            Male, Female
        }


    }
}
