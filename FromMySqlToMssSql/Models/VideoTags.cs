﻿using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class VideoTags
    {
        public int Id { get; set; }
        public int? VideoId { get; set; }
        public int? TagId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
        public string CreatedByNavigationId { get; set; }
        public string UpdatedByNavigationId { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual Tags Tag { get; set; }
        public virtual AspNetUsers UpdatedByNavigation { get; set; }
        public virtual Videos Video { get; set; }
    }
}
