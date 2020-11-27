using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class UserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string Discriminator { get; set; }
    }
}
