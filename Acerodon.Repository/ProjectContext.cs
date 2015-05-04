using Acerodon.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Acerodon.Repository
{
   
    public class ProjectContext : DbContext
    {

        public DbSet<Company> Companies { get; set; }
   
        public ProjectContext()
            : base("name=ProjectContext")
        {
        }

       
    }

   
}