using Acerodon.App.ViewModel.Interface;
using Acerodon.Model;

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
