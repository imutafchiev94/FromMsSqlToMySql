using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class AchievementCategories
    {
        public AchievementCategories()
        {
            Achievements = new HashSet<Achievements>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string PicturePath { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Achievements> Achievements { get; set; }
    }
}
