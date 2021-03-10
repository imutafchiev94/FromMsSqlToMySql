using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.OldModels
{
    public partial class CopyrightReport
    {
        public int Id { get; set; }
        public int? MemeId { get; set; }
        public int? VideoId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Organization { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string OwnerFullName { get; set; }
        public string Links { get; set; }
        public string DescriptionCopyrightWork { get; set; }
        public string PostLink { get; set; }
        public string DescriptionInfringement { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool? IsSolved { get; set; }
        public int? AuthorId { get; set; }

        public virtual User Author { get; set; }
        public virtual Meme Meme { get; set; }
        public virtual Video Video { get; set; }
    }
}
