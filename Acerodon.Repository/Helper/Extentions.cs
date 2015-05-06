using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.Repository.Helper
{
    public static class Extentions
    {
        public static bool Save(this IEntity entry, ProjectContext context)
        {
            try
            {
                var set = context.Set(entry.GetType());
                set.Add(entry);
               
                context.SaveChanges();
                
                return true;
            
            }
            catch
            {
                return false;
            }
            
        }
    }
}
