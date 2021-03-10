using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.OldModels
{
    public partial class Video
    {
        public Video()
        {
            CopyrightReport = new HashSet<CopyrightReport>();
            Report = new HashSet<Report>();
            VideoComment = new HashSet<VideoComment>();
            VideoRating = new HashSet<VideoRating>();
            VideoTag = new HashSet<VideoTag>();
        }

        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public int? AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ThumbnailPath { get; set; }
        public string VideoPath { get; set; }
        public string VideoType { get; set; }
        public int? Views { get; set; }
        public int? Rating { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaFacebookTitle { get; set; }
        public string MetaFacebookDescription { get; set; }
        public string MetaTwitterTitle { get; set; }
        public string MetaTwitterDescription { get; set; }
        public bool IsHidden { get; set; }
        public int? SectionId { get; set; }
        public DateTime? ChangedSectionAt { get; set; }
        public int? FeaturedIndex { get; set; }

        public virtual User Author { get; set; }
        public virtual VideoCategory Category { get; set; }
        public virtual Section Section { get; set; }
        public virtual ICollection<CopyrightReport> CopyrightReport { get; set; }
        public virtual ICollection<Report> Report { get; set; }
        public virtual ICollection<VideoComment> VideoComment { get; set; }
        public virtual ICollection<VideoRating> VideoRating { get; set; }
        public virtual ICollection<VideoTag> VideoTag { get; set; }
    }
}
