using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model {
    public class CompanyPosition : IEntity {
        public string JobTitle { get; set; }
        public string Description { get; set; }
    }
}
