using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.OldModels
{
    public partial class Section
    {
        public Section()
        {
            Meme = new HashSet<Meme>();
            Video = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Rating { get; set; }
        public int? Time { get; set; }
        public int? Priority { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual ICollection<Meme> Meme { get; set; }
        public virtual ICollection<Video> Video { get; set; }
    }
}
