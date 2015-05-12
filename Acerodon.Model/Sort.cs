using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Acerodon.Model
{
    public class Sort
    {
        public enum SortOrder
        {
            Ascending,
            Descending
        }

        public string Field { get; set; }
        public SortOrder Order { get; set; }
    }
}
