using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class VideoViews
    {
        public int Id { get; set; }
        public int? VideoId { get; set; }
        public string Ip { get; set; }
        public string BrowserAgent { get; set; }
        public bool? Counted { get; set; }
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
        public virtual Videos Video { get; set; }
    }
}
