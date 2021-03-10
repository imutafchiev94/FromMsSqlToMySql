using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.OldModels
{
    public partial class User
    {
        public User()
        {
            CopyrightReport = new HashSet<CopyrightReport>();
            Feedback = new HashSet<Feedback>();
            Meme = new HashSet<Meme>();
            MemeComment = new HashSet<MemeComment>();
            MemeRating = new HashSet<MemeRating>();
            ReportActionTakenBy = new HashSet<Report>();
            ReportAuthor = new HashSet<Report>();
            Video = new HashSet<Video>();
            VideoComment = new HashSet<VideoComment>();
            VideoRating = new HashSet<VideoRating>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Country { get; set; }
        public string Avatar { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string FullName { get; set; }
        public string ResetToken { get; set; }
        public int? ResetTokenExpiresAt { get; set; }
        public int MemesLimitPerDay { get; set; }
        public int VideosLimitPerDay { get; set; }
        public string Gender { get; set; }
        public string Bio { get; set; }

        public virtual ICollection<CopyrightReport> CopyrightReport { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual ICollection<Meme> Meme { get; set; }
        public virtual ICollection<MemeComment> MemeComment { get; set; }
        public virtual ICollection<MemeRating> MemeRating { get; set; }
        public virtual ICollection<Report> ReportActionTakenBy { get; set; }
        public virtual ICollection<Report> ReportAuthor { get; set; }
        public virtual ICollection<Video> Video { get; set; }
        public virtual ICollection<VideoComment> VideoComment { get; set; }
        public virtual ICollection<VideoRating> VideoRating { get; set; }
    }
}
