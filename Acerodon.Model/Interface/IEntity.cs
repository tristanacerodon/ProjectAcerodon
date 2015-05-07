using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model.Interface
{
    public abstract class IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid CreatedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid ModifiedById { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual User ModifiedBy { get; set; }
        public override string ToString() {
            return Name;
        }
        
    }
}
