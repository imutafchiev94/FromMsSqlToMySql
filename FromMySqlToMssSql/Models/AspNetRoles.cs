using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class AspNetRoles
    {
        public AspNetRoles()
        {
            RoleClaims = new HashSet<RoleClaims>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<RoleClaims> RoleClaims { get; set; }
    }
}
