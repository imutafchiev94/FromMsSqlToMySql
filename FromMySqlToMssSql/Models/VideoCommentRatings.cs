using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class VideoCommentRatings
    {
        public int Id { get; set; }
        public int? VideoCommentId { get; set; }
        public string UserId { get; set; }
        public int? Rate { get; set; }
        public bool? Calculated { get; set; }
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
        public virtual AspNetUsers User { get; set; }
        public virtual VideoComments VideoComment { get; set; }
    }
}
