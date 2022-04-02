using System;

namespace ClassLibrary1
{
    public class Student
    {
        public Student(string fullname , string groupno , int age )
        {
            this.FullName = fullname;
            this.GroupNo = groupno;
            this.Age = age;
        }
        private string _fullname;
        public string FullName { get { return _fullname; } set { if (value.CheckFullname()) { _fullname = value; }  } }
        private string _groupno;
        public string GroupNo { get { return _groupno; }set { if (value.CheckGroupNo()) { _groupno = value; } } }
        public int Age { get; set; }


        public void GetInfo()
        {
            Console.WriteLine($"Ad ve soyad: {this.FullName}        Group No: {this.GroupNo}       Age: {this.Age}");
        }

    }
}
