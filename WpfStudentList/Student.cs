using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudentList
{
    public class Student:Bindable
    {

        public Student()
        {

        }

        public Student(Student student)
        {
            this.Id = student.Id;
            this.Name = student.Name;
            this.Grade = student.grade;
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; propertyIsChanged(); }
        }
               
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; propertyIsChanged(); }
        }


        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; propertyIsChanged(); }
        }

    }
}
