using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolForTesting.Tests
{
    [TestClass()]
    public class StudentsTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void StudentAddressNull()
        {
            Student student = new Student("Kaj",null,Person.Gender.Male,4);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentNameTooShort()
        {
            Student student = new Student("b", "klfg",Person.Gender.Female,4);
        }

        [TestMethod]
        public void StudentNameTest()
        {
            Student student = new Student("billie","dkf",Person.Gender.Female, 3);
            Assert.AreEqual("billie", student.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentSemester0()
        {
            Student student = new Student("klavs","sdjlf",Person.Gender.Male,0);
        }
      [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void StudentSemester9()
        {
            Student student = new Student("klavs", "sdjlf", Person.Gender.Male, 0);
        }
      [TestMethod]
        public void StudentSemester7()
        {
            Student student = new Student("klavs", "sdjlf", Person.Gender.Male, 7);
            Assert.AreEqual(7, student.Semester);
        }
      [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TeacherSalaryMinus1()
        {
            Teacher teacher = new Teacher("klavs", "sdjlf", Person.Gender.Male, -1);

        }[TestMethod]
        public void TeacherSalary0()
        {
            Teacher teacher = new Teacher("klavs", "sdjlf", Person.Gender.Male, 0);
            Assert.AreEqual(0,teacher.Salary);
        }
      [TestMethod]
        public void TeacherSalaryPlus1()
        {
            Teacher teacher = new Teacher("klavs", "sdjlf", Person.Gender.Male, 1);
            Assert.AreEqual(1,teacher.Salary);
        }
     [TestMethod]
        public void TeacherAddress()
        {
            Teacher teacher = new Teacher("klavs", "Roskilde", Person.Gender.Male, 1);
            Assert.AreEqual("Roskilde",teacher.Address);
        }
    [TestMethod]
        public void TeacherAddressFail()
        {
            Teacher teacher = new Teacher("klavs", "Roskilde", Person.Gender.Male, 1);
            Assert.AreNotEqual("Koege",teacher.Address);
        }


    [TestMethod]
        public void TeacherGender()
        {
            Teacher teacher = new Teacher("klavs", "Roskilde", Person.Gender.Male, 1);
            Assert.AreEqual(Person.Gender.Male,teacher.GenderValue);
        }
 [TestMethod]
        public void TeacherGenderFail()
        {
            Teacher teacher = new Teacher("klavs", "Roskilde", Person.Gender.Male, 1);
            Assert.AreNotEqual(Person.Gender.Female,teacher.GenderValue);
        }



    }
}