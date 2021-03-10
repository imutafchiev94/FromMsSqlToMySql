using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Memes
    {
        public Memes()
        {
            CopyrightReports = new HashSet<CopyrightReports>();
            GameRatings = new HashSet<GameRatings>();
            MemeComments = new HashSet<MemeComments>();
            MemeRatings = new HashSet<MemeRatings>();
            MemeTags = new HashSet<MemeTags>();
            MemeViews = new HashSet<MemeViews>();
            Notifications = new HashSet<Notifications>();
            Reports = new HashSet<Reports>();
        }

        public int Id { get; set; }
        public int? MemeCategoryId { get; set; }
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string MemePath { get; set; }
        public int? Views { get; set; }
        public int? Rating { get; set; }
        public string Slug { get; set; }
        public bool? Visible { get; set; }
        public bool? Deleted { get; set; }
        public int? MemeSectionId { get; set; }
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

        public virtual AspNetUsers Author { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual MemeCategories MemeCategory { get; set; }
        public virtual MemeSections MemeSection { get; set; }
        public virtual AspNetUsers UpdatedByNavigation { get; set; }
        public virtual ICollection<CopyrightReports> CopyrightReports { get; set; }
        public virtual ICollection<GameRatings> GameRatings { get; set; }
        public virtual ICollection<MemeComments> MemeComments { get; set; }
        public virtual ICollection<MemeRatings> MemeRatings { get; set; }
        public virtual ICollection<MemeTags> MemeTags { get; set; }
        public virtual ICollection<MemeViews> MemeViews { get; set; }
        public virtual ICollection<Notifications> Notifications { get; set; }
        public virtual ICollection<Reports> Reports { get; set; }
    }
}
