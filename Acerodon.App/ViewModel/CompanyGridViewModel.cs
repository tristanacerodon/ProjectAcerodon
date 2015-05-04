using Acerodon.App.AcerodonService;
using Acerodon.App.Helper;
using Acerodon.App.ViewModel.Interface;
using Acerodon.GenericDataContract.Types;
using Acerodon.Model;
using System.Windows;
using System.Windows.Input;

namespace Acerodon.App.ViewModel
{
    class CompanyGridViewModel : GridViewModel<Company>
    {
        public CompanyGridViewModel()
        {
            EntryForm = new AddCompany();
        }    

    }
}
