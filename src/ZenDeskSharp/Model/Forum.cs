namespace ZenDeskSharp.Model
{
    public class Forum
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int EntriesCount { get; set; }

        public int PostsCount { get; set; }

        public bool IsLocked { get; set; }

        public bool IsPublic { get; set; }
    }
}
