using System;
using System.Collections.Generic;

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
