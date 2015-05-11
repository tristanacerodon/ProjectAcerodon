using Acerodon.App.AcerodonService;
using Acerodon.App.Helper;
using System;
using System.Windows;
using System.Windows.Input;
namespace Acerodon.App.Interfaces
{
    interface IGridViewModel
    {
        ICommand AddCommand { get; }
        ICommand BackCommand { get; }
        ICommand DeleteCommand { get; }
        ICommand EditCommand { get; }        
        ICommand FirstCommand { get; }
        ICommand LastCommand { get; }
        ICommand NextCommand { get; }
        int Page { get; set; }
        int Pages { get; }
        ICommand RefreshCommand { get; }
        int Rows { get; set; }
        DataServiceClient Service { get; }
        ListForm ListForm { get; set; }
    }
}
