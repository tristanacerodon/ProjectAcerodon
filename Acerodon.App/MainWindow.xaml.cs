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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           var frmGender = new GenericListForm<Company>();
           



           frmGender.Show();
          
        }
    }
}
