using System;
using System.Collections.Generic;

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
