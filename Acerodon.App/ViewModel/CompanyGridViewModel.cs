﻿using Acerodon.App.ViewModel.Interface;
using Acerodon.Model;

namespace Acerodon.App.ViewModel
{
    class CustomerGridViewModel : GridViewModel<Company>
    {
        public CustomerGridViewModel()
        {
            EntryForm = new AddCompany();
        }    

    }
}
