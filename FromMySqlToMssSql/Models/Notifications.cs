using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class Notifications
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsOpened { get; set; }
        public bool? IsDeleted { get; set; }
        public string RecieverId { get; set; }
        public int? MemeCommentId { get; set; }
        public int? MemeId { get; set; }
        public int? VideoCommentId { get; set; }
        public int? VideoId { get; set; }
        public string SenderId { get; set; }

        public virtual Memes Meme { get; set; }
        public virtual MemeComments MemeComment { get; set; }
        public virtual AspNetUsers Reciever { get; set; }
        public virtual AspNetUsers Sender { get; set; }
        public virtual Videos Video { get; set; }
        public virtual Videos VideoComment { get; set; }
    }
}
