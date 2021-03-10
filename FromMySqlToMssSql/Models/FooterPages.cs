using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class FooterPages
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
