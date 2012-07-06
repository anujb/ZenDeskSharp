using System.Collections.Generic;

namespace ZenDeskSharp.Model
{
    public class Entry
    {
        public int Id { get; set; }

        public int ForumId { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

        public int Hits { get; set; }

        public int PostsCount { get; set; }

        public bool IsLocked { get; set; }

        public bool IsPinned { get; set; }

        public bool IsPublic { get; set; }

        public int SubmitterId { get; set; }

        public List<Post> Posts { get; set; }

        public int VotesCount { get; set; }

        /// <summary>
        /// Used only on Post. Api does not return this on Get
        /// </summary>
        public string CurrentTags { get; set; }
    }
}
