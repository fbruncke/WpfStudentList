using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudentList
{
    public class Dog : Bindable, IPet
    {
        public String Breed { get; set; }

        public String Name { get; set; }
    }
}
