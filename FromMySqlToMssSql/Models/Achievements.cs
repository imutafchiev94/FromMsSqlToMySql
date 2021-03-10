using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Achievements
    {
        public Achievements()
        {
            UserAchievements = new HashSet<UserAchievements>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int AchievementCategoryId { get; set; }
        public int Requirement { get; set; }
        public string Description { get; set; }
        public string PicturePath { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? BadgeId { get; set; }
        public int? CoinsCount { get; set; }
        public int? FrameId { get; set; }
        public int? XpCount { get; set; }
        public string RewardDescription { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AchievementCategories AchievementCategory { get; set; }
        public virtual Badges Badge { get; set; }
        public virtual Frames Frame { get; set; }
        public virtual ICollection<UserAchievements> UserAchievements { get; set; }
    }
}
