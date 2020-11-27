using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class UserTokens
    {
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Discriminator { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
