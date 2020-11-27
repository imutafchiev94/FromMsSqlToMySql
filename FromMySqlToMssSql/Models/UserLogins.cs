using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class UserLogins
    {
        public string LoginProvider { get; set; }
        public string ProviderKey { get; set; }
        public string ProviderDisplayName { get; set; }
        public string UserId { get; set; }
        public string Discriminator { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
