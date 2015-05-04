using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acerodon.Repository
{
    public class Query
    {
        public int Rows { get; set; }
        public int Page { get; set; }
        public int Skip { get { return (Page - 1) * Rows; } }
        public List<Filter> Filters { get; set; }
        public List<Sort> Sorts { get; set; }
    }
}