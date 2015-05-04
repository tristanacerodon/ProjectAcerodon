using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acerodon.Service
{
    public class Query
    {
        public int Row { get; set; }
        public int Page { get; set; }
        public List<Filter> Filters { get; set; }
        public List<Sort> Sorts { get; set; }
    }
}