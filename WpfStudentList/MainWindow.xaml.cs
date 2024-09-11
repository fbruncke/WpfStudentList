using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudentList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Student> studentList = new ObservableCollection<Student>();

        public ObservableCollection<Student> StudentList { get { return studentList; } }

        public Student newStudent;

        public Student NewStudent
        {
            get { return newStudent; }
            set { newStudent = value; }
        }

        
        private Teacher teacher;

        public Teacher MyTeacher
        {
            get { return teacher; }
            set { teacher = value; }
        }


        public MainWindow()
        {
            NewStudent = new Student();
            MyTeacher = new Teacher { Course = "Math", Height=200 };

            InitializeComponent();

            //this.DataContext = this;

            
        }

       
    }
}
