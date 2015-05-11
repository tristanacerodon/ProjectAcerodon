using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;

namespace Acerodon.Model
{
    public class Milestone : IActivity
    {
        public Guid ProjectId { get; set; }
        public Guid? MilestoneId { get; set; }
        public virtual ICollection<Milestone> Milestones { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

    }
}
