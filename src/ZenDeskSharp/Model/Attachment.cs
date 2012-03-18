using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZenDeskSharp.Model
{
    public class Attachment
    {
        public string ContentType { get; set; }

        public string CreatedAt { get; set; }

        public string FileName { get; set; }

        public int Id { get; set; }

        public bool IsPublic { get; set; }

        public int Size { get; set; }

        public string Token { get; set; }

        public string Url { get; set; }
    }

    public class ZenFile
    {
        public string FileName {get; set;}
        public string ContentType {get; set;}
        public byte[] FileData { get; set; }
    }
}
