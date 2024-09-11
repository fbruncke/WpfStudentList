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
using System.Windows.Shapes;

namespace WpfStudentList
{
    /// <summary>
    /// Interaction logic for StudentList.xaml
    /// </summary>
    public partial class StudentListView : Window
    {
        private int i = 0;
        private ObservableCollection<Student> studentList = new ObservableCollection<Student>();

        public ObservableCollection<Student> StudentList { get { return studentList; } }


        private ObservableCollection<IPet> petList = new ObservableCollection<IPet>();

        public ObservableCollection<IPet> PetList { get { return petList; } }


        public StudentListView()
        {
            InitializeComponent();

            this.DataContext = this;

            this.StudentList.Add(new Student { Id = i++, Grade = 10, Name = "Hugo" });
            this.StudentList.Add(new Student { Id = i++, Grade = 12, Name = "Franco" });
            this.StudentList.Add(new Student { Id = i++, Grade = 8, Name = "Tomaso" });

            this.PetList.Add( new Dog { Name="Fido", Breed="Labrador"} );
            this.PetList.Add(new Cat { Name = "Garfield", Color="Orange" });

        }

        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            this.StudentList.Add(new Student { Grade = 10, Name="Disney",Id=i++ }) ;
            
        }

    }
}
