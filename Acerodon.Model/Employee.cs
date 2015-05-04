
using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model {
    public class Employee : IPerson {

        public Guid EmploymentStatusId { get; set; }
        public EmploymentStatus EmploymentStatus {get; set;}
    }
}
