using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.OldModels
{
    public partial class VideoComment
    {
        public VideoComment()
        {
            InverseParent = new HashSet<VideoComment>();
        }

        public int Id { get; set; }
        public int? VideoId { get; set; }
        public int? ParentId { get; set; }
        public int? AuthorId { get; set; }
        public string Text { get; set; }
        public string UpVotes { get; set; }
        public string DownVotes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual User Author { get; set; }
        public virtual VideoComment Parent { get; set; }
        public virtual Video Video { get; set; }
        public virtual ICollection<VideoComment> InverseParent { get; set; }
    }
}
