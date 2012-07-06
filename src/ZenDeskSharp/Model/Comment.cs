using System.Collections.Generic;

namespace ZenDeskSharp.Model
{
    public class Comment
    {
        public int AuthorId { get; set; }

        public string CreatedAt { get; set; }

        public bool IsPublic { get; set; }

        public string CommentType { get; set; }

        public string Value { get; set; }

        public int ViaId { get; set; }

        public string AttachmentsToken { get; set; }

        public List<Attachment> Attachments { get; set; }

    } 
}
