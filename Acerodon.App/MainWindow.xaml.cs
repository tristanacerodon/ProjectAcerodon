using Acerodon.App.Helper;
using Acerodon.Model;
using System.Windows;
using System.Linq;

namespace Acerodon.App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender , RoutedEventArgs e) {
          

        }
        private void Close_Click(object sender , RoutedEventArgs e) {
            

        }
        private void Save_Click(object sender , RoutedEventArgs e) {
          
        }
        private void User_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<User>();
            frm.Show();

        }
        private void Company_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<Company>();
            frm.Show();

        }
        private void Employee_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<Employee>();
            frm.Show();

        }
        private void Customer_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<Customer>();
            frm.Show();

        }
        private void CompanyPosition_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<CompanyPosition>();
            frm.Show();

        }
        private void CompanyCustomer_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<CompanyCustomer>();
            frm.Show();

        }
        private void Project_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<Project>();
            frm.Show();

        }

        private void EmployeeRole_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<EmployeeRole>();
            frm.Show();

        }
        private void Milestone_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<Milestone>();
            frm.Show();

        }
        private void Task_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<Task>();
            frm.Show();

        }
        private void TaskStatus_Click(object sender , RoutedEventArgs e) {
            var frm = new GenericListForm<TaskStatus>();
            frm.Show();

        }

      
    }
}
