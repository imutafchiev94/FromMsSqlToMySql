using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Badges
    {
        public Badges()
        {
            Achievements = new HashSet<Achievements>();
            UserBadges = new HashSet<UserBadges>();
        }

        public int Id { get; set; }
        public string Path { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string AspNetUsersId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers AspNetUsers { get; set; }
        public virtual ICollection<Achievements> Achievements { get; set; }
        public virtual ICollection<UserBadges> UserBadges { get; set; }
    }
}
