using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class RoleClaims
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string Discriminator { get; set; }

        public virtual AspNetRoles Role { get; set; }
    }
}
