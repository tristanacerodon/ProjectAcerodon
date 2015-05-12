using Acerodon.Model;
using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Repository
{

    public static class GenericEntity
    {
        public static GenericEntity<T> CreateInstance<T>(ProjectContext db)
            where T : IEntity, new()
        {
            return new GenericEntity<T>(db);
        }

        public static dynamic CreateInstanceDynamic(ProjectContext context, string TypeName)
        {
            Assembly a = Assembly.GetAssembly(typeof(IEntity));
            Type type = (from t in a.GetTypes()
                         where t.Name == TypeName
                         select t).First();

            MethodInfo method = typeof(GenericEntity).GetMethod("CreateInstance",
                              BindingFlags.Public | BindingFlags.Static);

            method = method.MakeGenericMethod(type);

            return method.Invoke(null, new object[] { context });
        }
    }

    public class GenericEntity<T>
        where T : IEntity, new()  
    {

        public ProjectContext db;

        public GenericEntity(ProjectContext db)
        {
            this.db = db;
        }

        public IEnumerable<T> Get(Query query)
        {
            return db.Set<T>().OrderBy(o => o.Id).Skip(query.Skip).Take(query.Rows);
        }

        public T GetById(Guid id) {
            return db.Set<T>().Find(id);
        }
        
    }
}
