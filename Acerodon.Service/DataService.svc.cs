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
        
        #region Company

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

        #endregion


        #region Customer
        [OperationContract]
        public bool AddCustomer(Customer customer)
        {

            GenericEntity<Customer> Customers = new GenericEntity<Customer>(db);
            return Customers.Add(customer);

        }
        #endregion
    }
}
