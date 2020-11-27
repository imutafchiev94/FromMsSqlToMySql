using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class VideoComments
    {
        public VideoComments()
        {
            InverseReplyTo = new HashSet<VideoComments>();
            VideoCommentRatings = new HashSet<VideoCommentRatings>();
        }

        public int Id { get; set; }
        public int? VideoId { get; set; }
        public string AuthorId { get; set; }
        public int? ReplyToId { get; set; }
        public string Comment { get; set; }
        public int? Rating { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
        public string CreatedByNavigationId { get; set; }
        public string UpdatedByNavigationId { get; set; }

        public virtual AspNetUsers Author { get; set; }
        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual VideoComments ReplyTo { get; set; }
        public virtual AspNetUsers UpdatedByNavigation { get; set; }
        public virtual Videos Video { get; set; }
        public virtual ICollection<VideoComments> InverseReplyTo { get; set; }
        public virtual ICollection<VideoCommentRatings> VideoCommentRatings { get; set; }
    }
}
