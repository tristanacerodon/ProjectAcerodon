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

namespace Acerodon.Service {
    [ServiceContract]
    public class DataService {
        ProjectContext context = new ProjectContext();

        [OperationContract]
        public ListDataContract GetList(ListDataContract contract , Query query) {
            Fill(contract , query);
            return contract;
        }

        [OperationContract]
        public ItemDataContract GetItem(ItemDataContract contract , Guid id) {
            Fill(contract , id);
            return contract;
        }

        [OperationContract]
        public bool Add(IEntity entry) {

            return entry.Save(context);


        }

        private void Fill(ListDataContract contract , Query query) {

            dynamic obj = GenericEntity.CreateInstanceDynamic(context , contract.TypeName);
            contract.ItemList = new List<object>(obj.Get(query));
        }

        private void Fill(ItemDataContract contract , Guid id) {

            dynamic obj = GenericEntity.CreateInstanceDynamic(context , contract.TypeName);
            contract.Item = (object)obj.GetById(id);
        }
    }

}
