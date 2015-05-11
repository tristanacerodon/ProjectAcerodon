using Acerodon.Model.Interface;
using System;

namespace Acerodon.Model {
    public class Task : IActivity
    {
        public Guid EmployeeId { get; set; }
        public Guid TaskStatusId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
    }
}
