using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model {
    public class EmployeeRole : IEntity {

        public Guid EmployeeId { get; set; }
        public Guid CompanyPositionId { get; set; }
        public Guid ProjectId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual CompanyPosition CompanyPosition { get; set; }
        public virtual Project Project { get; set; }
    }
}
