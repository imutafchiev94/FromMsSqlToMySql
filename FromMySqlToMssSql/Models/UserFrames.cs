using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class UserFrames
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? FrameId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string Note { get; set; }

        public virtual Frames Frame { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
