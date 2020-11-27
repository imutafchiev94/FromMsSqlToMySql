using System;
using System.Collections.Generic;

namespace FromMySqlToMssSql.Models
{
    public partial class MetaData
    {
        public int Id { get; set; }
        public string NameOfPage { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string FacebookUrl { get; set; }
        public string FacebookTitle { get; set; }
        public string FacebookDescription { get; set; }
        public string FacebookImage { get; set; }
        public string TwitterUrl { get; set; }
        public string TwitterTitle { get; set; }
        public string TwitterDescription { get; set; }
        public string TwitterImage { get; set; }
        public string FacebookSiteName { get; set; }
        public string TwitterSiteName { get; set; }
    }
}
