using Acerodon.App.ViewModel;
using Acerodon.App.ViewModel.Interface;
using System.Windows;

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
            ((IGridViewModel)DataContext).Window = this;
        }

    }
}
