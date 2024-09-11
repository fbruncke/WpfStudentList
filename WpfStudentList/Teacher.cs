using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudentList
{
    public class Teacher:Bindable
    {
        private string course;
        
        public string Course
        {
            get { return course;   }
            set { course = value; /*this.propertyIsChanged(); */}
        }

        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

       






























        public override string ToString()
        {
            return base.ToString() + " tostring: " + Course + " Height: " + this.height;
        }
    }
}
