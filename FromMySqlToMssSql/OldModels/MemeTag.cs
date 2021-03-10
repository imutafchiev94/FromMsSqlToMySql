using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.OldModels
{
    public partial class MemeTag
    {
        public int MemeId { get; set; }
        public int TagId { get; set; }

        public virtual Meme Meme { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
