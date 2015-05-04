using Acerodon.App.AcerodonService;
using Acerodon.App.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Acerodon.App.ViewModel
{
    class CompanyGridViewModel : GridViewModel<Company>
    {

        public CompanyGridViewModel()
        {

        }

        public override Company[] Get(int page, int row)
        {
            return service.GetCompanies(new Query());
        }

        public ICommand Next
        {
            get{
                 return null;
            }
           
        }
    }
}
