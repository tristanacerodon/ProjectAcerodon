using Acerodon.App.ViewModel.Interface;
using Acerodon.Model;

namespace Acerodon.App.ViewModel
{
    class CustomerGridViewModel : GridViewModel<Customer>
    {
        public CustomerGridViewModel()
        {
            EntryForm = new AddCompany();
        }    

    }
}
