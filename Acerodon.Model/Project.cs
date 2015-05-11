using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;

namespace Acerodon.Model
{
    public class Project : IActivity
    {
        public Guid CompanyCustomerId { get; set; }
        public virtual ICollection<Milestone> Milestones { get; set; }
    }
}
