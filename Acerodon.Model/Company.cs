﻿using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model
{
    public class Company : ICompany
    {
        public virtual ICollection<CompanyCustomer> CompanyCustomers { get; set; }
    }
}
