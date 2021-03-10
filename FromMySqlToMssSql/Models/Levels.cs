using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Levels
    {
        public int Id { get; set; }
        public int LevelNumber { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int RequiredXp { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public int? BadgeId { get; set; }
        public int? CoinsCount { get; set; }
        public int? FrameId { get; set; }
        public bool? IsDeleted { get; set; }
        public string RewardDescription { get; set; }
    }
}
