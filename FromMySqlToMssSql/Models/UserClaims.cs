using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class UserClaims
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
        public string Discriminator { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
