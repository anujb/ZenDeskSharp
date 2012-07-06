﻿using System.Collections.Generic;

namespace ZenDeskSharp.Model
{
    public class Organization
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsShared { get; set; }

        public string Default { get; set; }

        public List<User> Users { get; set; }
    }
}
