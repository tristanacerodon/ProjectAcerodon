
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model.Interface {
    public class IPerson : IEntity {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Guid GenderId { get; set; }
    }
}
