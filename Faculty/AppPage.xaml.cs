using System;
using System.Collections.Generic;
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

namespace Faculty
{
    /// <summary>
    /// Interaction logic for AppPage.xaml
    /// </summary>
    public partial class AppPage : Page
    {
        FacultyEntities db = new FacultyEntities();

        public AppPage()
        {
            InitializeComponent();
            DG.ItemsSource = db.Students.ToList();

        }


        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            FacultyEntities db = new FacultyEntities();
            Student ST = new Student();

            ST.Name = Name_textbox.Text;
            ST.Address = Address_textbox.Text;
            ST.Age = int.Parse(Age_textbox.Text);
            ST.Department = Department_textbox.Text;

            db.Students.Add(ST);
            db.SaveChanges();

            MessageBox.Show("Inforamtion added successfully");
        }

        private void Data_button_Click(object sender, RoutedEventArgs e)
        {
            FacultyEntities db = new FacultyEntities();
            Data data = new Data();

            // Retrieve the student based on the specified conditions

            var student = db.Students.First(x => x.Name == Name_textbox.Text);
            DG.ItemsSource = new List<Student> { student };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = db.Students.ToList();
        }
    }
}
