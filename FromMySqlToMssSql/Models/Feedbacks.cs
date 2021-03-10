using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Feedbacks
    {
        public int Id { get; set; }
        public string AuthorId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual AspNetUsers Author { get; set; }
    }
}
