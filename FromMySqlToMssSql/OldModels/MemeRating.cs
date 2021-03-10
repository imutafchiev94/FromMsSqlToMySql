using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.OldModels
{
    public partial class MemeRating
    {
        public int Id { get; set; }
        public int? MemeId { get; set; }
        public int? AuthorId { get; set; }
        public int? Vote { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User Author { get; set; }
        public virtual Meme Meme { get; set; }
    }
}
