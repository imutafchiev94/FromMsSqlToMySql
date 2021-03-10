using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Tags
    {
        public Tags()
        {
            MemeTags = new HashSet<MemeTags>();
            VideoTags = new HashSet<VideoTags>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
        public string CreatedByNavigationId { get; set; }
        public string UpdatedByNavigationId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers UpdatedByNavigation { get; set; }
        public virtual ICollection<MemeTags> MemeTags { get; set; }
        public virtual ICollection<VideoTags> VideoTags { get; set; }
    }
}
