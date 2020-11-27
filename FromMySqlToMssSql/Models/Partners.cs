using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class Partners
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public bool? Deleted { get; set; }
    }
}
