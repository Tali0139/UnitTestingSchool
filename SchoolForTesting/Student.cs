using System;
using System.Collections.Generic;

namespace SchoolForTesting
{
    public class Student:Person
    {
        private int _semester;
     
        /// <summary>
        /// constructor takes 4 parameters
        /// </summary>
        /// <param name="semester"></param>
        //
        public Student(string name, string address, Gender genderValue, int semester) : base(name, address, genderValue)
        {
            Name = name;
            Address = address;
            GenderValue = genderValue;
            Semester = semester;
        }
        /// <summary>
        /// Semester prop cannot be out of range
        /// </summary>
        public int Semester
        {
            get => _semester;
            set
            {
                if (value<1 || value>8 ) throw new ArgumentOutOfRangeException();
                _semester = value;
            }
        }
        
    }
}
