using Acerodon.Model.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Acerodon.GenericDataContract.Types
{
    [DataContract]
    [KnownType("GetKnownTypes")]
    public class AcerodonDataContract
    {

        [DataMember]
        private List<object> _ItemList;
        [DataMember]
        public string TypeName;
        [DataMember]
        public string TypeNamespace;


        private static Type[] GetKnownTypes()
        {

            Assembly a = Assembly.GetAssembly(typeof(IEntity));
            return a.GetTypes().ToArray();

        }

        public static AcerodonDataContract Create<T>()
        {
            var dc = new AcerodonDataContract();
            Type t = typeof(T);

            dc.TypeName = t.Name;
            dc.TypeNamespace = t.Namespace;

            return dc;
        }

        public List<object> ItemList
        {
            get {return _ItemList;}
            set { _ItemList = value; } 
        }

        public T[] GetList<T>()
        {
            return ItemList.Cast<T>().ToArray();
        }

    }

}