using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model {
    public class MilestoneTask : IEntity {

        public Guid ProjectId { get; set; }
        public Guid MilestoneId { get; set; }
        public Guid TaskId { get; set; }
        public Guid EmployeeId { get; set; }
        public Guid CompanyPositionId { get; set; }
        public Guid TaskStatusId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual Project Project { get; set; }
        public virtual Milestone Milestone { get; set; }
        public virtual Task Task { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual CompanyPosition CompanyPosition { get; set; }
        public virtual TaskStatus TaskStatus { get; set; }
    }
}
