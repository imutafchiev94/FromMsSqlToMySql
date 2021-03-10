using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Games
    {
        public int Id { get; set; }
        public string ThumbnailPath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public string GamePath { get; set; }
        public int Rating { get; set; }
        public string Slug { get; set; }
        public int TimesPlayed { get; set; }
    }
}
