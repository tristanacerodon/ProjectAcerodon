using Acerodon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace Acerodon.Repository.Mapping
{
    class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            this.HasOptional(o => o.CreatedBy).WithMany().HasForeignKey(o => o.CreatedById);
            this.HasOptional(o => o.ModifiedBy).WithMany().HasForeignKey(o => o.ModifiedById);
        }
    }
}
