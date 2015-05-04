using Acerodon.App.ViewModel.Interface;
using System.Windows;

namespace Acerodon.App.ViewModel
{
    public static class Extensions
    {
              
        public static void Refresh(this Window window)
        {
            object temp = window.DataContext;
            ((IGridViewModel)temp).Refresh();
          
            window.DataContext = null;
            window.DataContext = temp;
        }
    }
}
