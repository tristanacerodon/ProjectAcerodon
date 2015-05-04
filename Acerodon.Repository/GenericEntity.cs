using Acerodon.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Repository
{
    public class GenericEntity<T>   
        where T : BaseClass, new()  
    {

        public ProjectContext db;

        public GenericEntity(ProjectContext db)
        {
            this.db = db;
        }


        public DbSet<T> GetAll()
        {
            return db.Set<T>();
        }


        public T Get(int Id)
        {
            return db.Set<T>().Find(Id);
        }
    }
}
