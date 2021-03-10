using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Reports
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string AuthorId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int? MemeId { get; set; }
        public int? VideoId { get; set; }

        public virtual AspNetUsers Author { get; set; }
        public virtual Memes Meme { get; set; }
        public virtual Videos Video { get; set; }
    }
}
