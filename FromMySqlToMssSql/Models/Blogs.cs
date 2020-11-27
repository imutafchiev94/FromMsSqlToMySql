using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class Blogs
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Slug { get; set; }
        public string ImagePath { get; set; }
        public bool IsOnTop { get; set; }
        public string AuthorId { get; set; }
        public string CreatedByNavigationId { get; set; }
        public string UpdatedByNavigationId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        public virtual AspNetUsers Author { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers UpdatedByNavigation { get; set; }
    }
}
