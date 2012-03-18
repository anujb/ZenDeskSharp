using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZenDeskSharp.Model
{
    public class Post
    {
        public int UserId { get; set; }
        
        public string CreatedAt { get; set; }
        
        public string UpdatedAt { get; set; }
        
        public string Body { get; set; }

        public int EntryId { get; set; }

        public int ForumId { get; set; }

		public int Id { get; set; }

        public bool IsInformative { get; set; }

		public User User { get; set; }
    }
}
