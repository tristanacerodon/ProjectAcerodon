using Acerodon.GenericDataContract.Types;
using Acerodon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Acerodon.Model;
using Acerodon.Model.Interface;
using System.ServiceModel;

namespace Acerodon.Service
{
    [ServiceContract]
    public class DataService
    {
        ProjectContext context = new ProjectContext();

        [OperationContract]
        public AcerodonDataContract Get(AcerodonDataContract contract, Query query)
        {
            Fill(contract, query);
            return contract;
        }

        private void Fill(AcerodonDataContract contract, Query query)
        {
            Assembly a = Assembly.GetAssembly(typeof(IEntity));
            Type type = (from t in a.GetTypes()
                         where t.Name == contract.TypeName
                         select t).First();

            MethodInfo method = typeof(GenericEntity).GetMethod("CreateInstance",
                              BindingFlags.Public | BindingFlags.Static);

            method = method.MakeGenericMethod(type);

            dynamic obj = method.Invoke(null, new object[] { context });

            contract.ItemList = new List<object>(obj.Get(query));


        }
    }

}
