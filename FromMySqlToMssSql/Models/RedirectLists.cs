using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class RedirectLists
    {
        public int Id { get; set; }
        public string FromUrl { get; set; }
        public string ToUrl { get; set; }
        public string RedirectType { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
        public string CreatedByNavigationId { get; set; }
        public string UpdatedByNavigationId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers UpdatedByNavigation { get; set; }
    }
}
