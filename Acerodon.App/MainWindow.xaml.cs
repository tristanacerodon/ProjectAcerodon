using Acerodon.App.Helper;
using Acerodon.Model;
using System.Windows;
using System.Linq;
using System;

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

        private void Open_Click(object sender, RoutedEventArgs e)
        {


        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {


        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }
        private void User_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<User>(o => new { o.Name });
            frm.ShowDialog();

        }
        private void Company_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<Company>(o => new { o.Name });
            frm.ShowDialog();

        }
        private void Employee_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<Employee>(o => new { o.Name });
            frm.ShowDialog();

        }
        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<Customer>(o => new { o.Name });
            frm.ShowDialog();

        }
        private void CompanyPosition_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<CompanyPosition>();
            frm.ShowDialog();

        }
        private void CompanyCustomer_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<CompanyCustomer>();
            frm.ShowDialog();

        }
        private void Project_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<Project>();
            frm.ShowDialog();

        }

        private void EmployeeRole_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<EmployeeRole>();
            frm.ShowDialog();

        }
        private void Milestone_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<Milestone>();
            frm.ShowDialog();

        }
        private void Task_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<Task>(o => new { o.Name, o.Description });
            frm.ShowDialog();

        }
        private void TaskStatus_Click(object sender, RoutedEventArgs e)
        {
            var frm = new GenericListForm<TaskStatus>();
            frm.ShowDialog();

        }


    }
}
