using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace F24Week12CodeFirstApproach
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchoolContext db = new SchoolContext();

        public MainWindow()
        {
            InitializeComponent();
            LoadStandardsInCombobox();
        }

        private void LoadStandardsInCombobox()
        {
            cmbStandard.ItemsSource = db.Standards.ToList();
            cmbStandard.DisplayMemberPath = "StandardName";
            cmbStandard.SelectedValuePath = "StandardId";
        }

        private void LoadStudentsInDataGrid()
        {
            grdStudents.ItemsSource = db.Students.ToList();
        }

        private void btnLoadStudents_Click(object sender, RoutedEventArgs e)
        {
            LoadStudentsInDataGrid();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            Student std = new Student();
            std.StudentName = txtName.Text;
            std.StandardId = (int)cmbStandard.SelectedValue;

            db.Students.Add(std);
            db.SaveChanges();

            LoadStudentsInDataGrid();
        }
    }
}