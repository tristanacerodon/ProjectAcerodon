using Acerodon.Model;
using Acerodon.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Acerodon.Service
{
    [ServiceContract]
    public class DataService
    {

        ProjectContext db = new ProjectContext();
        
        [OperationContract]
        public IEnumerable<Company> GetCompanies(Query query)
        {

            GenericEntity<Company> Companies = new GenericEntity<Company>(db);
            return Companies.GetAll();

        }
        [OperationContract]
        public Company GetCompanyById(int Id)
        {

            GenericEntity<Company> Companies = new GenericEntity<Company>(db);
            return Companies.Get(Id);

        }
    }
}
