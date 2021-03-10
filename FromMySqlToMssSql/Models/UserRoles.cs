﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class UserRoles
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string Discriminator { get; set; }
    }
}
