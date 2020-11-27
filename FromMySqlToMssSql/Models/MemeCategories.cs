﻿using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class MemeCategories
    {
        public MemeCategories()
        {
            Memes = new HashSet<Memes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }
        public string CreatedByNavigationId { get; set; }
        public string UpdatedByNavigationId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers CreatedByNavigation { get; set; }
        public virtual AspNetUsers UpdatedByNavigation { get; set; }
        public virtual ICollection<Memes> Memes { get; set; }
    }
}
