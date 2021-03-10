using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class CopyrightReports
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string OwnerFullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public string Organization { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string LinksToCopyrightedWork { get; set; }
        public string DescriptionToCopyrightedWork { get; set; }
        public string LinksToInfringingMaterial { get; set; }
        public string DescriptionOfInfringing { get; set; }
        public int? MemeId { get; set; }
        public int? VideoId { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual Memes Meme { get; set; }
        public virtual Videos Video { get; set; }
    }
}
