using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model
{
    public class Project : IEntity
    {
        public Guid CompanyCustomerId { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual CompanyCustomer CompanyCustomer { get; set; }
    }
}
