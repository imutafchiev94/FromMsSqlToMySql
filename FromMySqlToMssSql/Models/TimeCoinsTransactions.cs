using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FromMySqlToMssSql.Models
{
    public partial class TimeCoinsTransactions
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int UserId { get; set; }
        public int? UserRewardId { get; set; }
        public int? AdminId { get; set; }
        public string Reason { get; set; }
        public int? TransactionId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
