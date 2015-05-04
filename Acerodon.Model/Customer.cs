﻿using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model
{
    public class Customer : ICompany
    {
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }
    }

}