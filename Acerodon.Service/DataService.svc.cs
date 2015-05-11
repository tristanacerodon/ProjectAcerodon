using Acerodon.GenericDataContract.Types;
using Acerodon.Repository;
using Acerodon.Repository.Helper;
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

        [OperationContract]
        public bool Add(IEntity entry)     
        {

            return entry.Save(context);
                      
            
        }
        
        private void Fill(AcerodonDataContract contract, Query query)
        {

            dynamic obj = GenericEntity.CreateInstanceDynamic(context, contract.TypeName);
            contract.ItemList = new List<object>(obj.Get(query));
       }
    }

}
