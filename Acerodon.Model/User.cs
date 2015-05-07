using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Model {
    public class User : IEntity {
        public string Password { get; set; }
    }
}
