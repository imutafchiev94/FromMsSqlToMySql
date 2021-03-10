using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Videos
    {
        public Videos()
        {
            CopyrightReports = new HashSet<CopyrightReports>();
            NotificationsVideo = new HashSet<Notifications>();
            NotificationsVideoComment = new HashSet<Notifications>();
            Reports = new HashSet<Reports>();
            VideoComments = new HashSet<VideoComments>();
            VideoRatings = new HashSet<VideoRatings>();
            VideoTags = new HashSet<VideoTags>();
            VideoViews = new HashSet<VideoViews>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Thumbnail { get; set; }
        public string VideoPath { get; set; }
        public int? Views { get; set; }
        public int? Rating { get; set; }
        public string Slug { get; set; }
        public bool? Visible { get; set; }
        public bool? Deleted { get; set; }
        public int? VideoSectionId { get; set; }
        public DateTime? LastSectionChangeAt { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
        public string CreatedByNavigationId { get; set; }
        public string UpdatedByNavigationId { get; set; }
        public int? FeatureIndex { get; set; }
        public bool? IsXpcalculated { get; set; }

        public virtual VideoCategories Category { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers UpdatedByNavigation { get; set; }
        public virtual AspNetUsers User { get; set; }
        public virtual VideoSections VideoSection { get; set; }
        public virtual ICollection<CopyrightReports> CopyrightReports { get; set; }
        public virtual ICollection<Notifications> NotificationsVideo { get; set; }
        public virtual ICollection<Notifications> NotificationsVideoComment { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
        public virtual ICollection<VideoComments> VideoComments { get; set; }
        public virtual ICollection<VideoRatings> VideoRatings { get; set; }
        public virtual ICollection<VideoTags> VideoTags { get; set; }
        public virtual ICollection<VideoViews> VideoViews { get; set; }
    }
}
