using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Acerodon.GenericDataContract.Types {

    [DataContract]
    [KnownType("GetKnownTypes")]
    public class ItemDataContract {

        [DataMember]
        private object _Item;
        [DataMember]
        public string TypeName;
        [DataMember]
        public string TypeNamespace;


        private static Type[] GetKnownTypes() {

            Assembly a = Assembly.GetAssembly(typeof(IEntity));
            return a.GetTypes().ToArray();

        }

        public static ItemDataContract Create(Type type) {
            var dc = new ItemDataContract();
            Type t = type;

            dc.TypeName = t.Name;
            dc.TypeNamespace = t.Namespace;

            return dc;
        }

        public static ItemDataContract Create<T>() {
            var dc = new ItemDataContract();
            Type t = typeof(T);

            dc.TypeName = t.Name;
            dc.TypeNamespace = t.Namespace;

            return dc;
        }

        public object Item {
            get { return _Item; }
            set { _Item = value; }
        }

        public T Get<T>() {
            return (T)Item;
        }

        public dynamic Get() {
            return (dynamic)Item;
        }

    }
}
