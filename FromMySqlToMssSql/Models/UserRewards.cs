using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class UserRewards
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? LevelId { get; set; }
        public int? AchievementId { get; set; }
        public int? CoinsAmount { get; set; }
        public int? BadgeId { get; set; }
        public int? FrameId { get; set; }
        public int? XpCount { get; set; }
        public string Title { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
