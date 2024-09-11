using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudentList
{
    public class Cat : Bindable, IPet
    {
        public String Color { get; set; }

        public String Name { get; set; }
    }
}
