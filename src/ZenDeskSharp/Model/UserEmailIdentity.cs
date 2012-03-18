﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestSharp.Serializers;

namespace ZenDeskSharp.Model
{        
    public class UserEmailIdentity
    {        
        public int AccountId { get; set; }        
        public string CreatedAt { get; set; }        
        public int Id { get; set; }        
        public bool IsVerified { get; set; }        
        public string UpdatedAt { get; set; }        
        public int UserId { get; set; }        
        public string Value { get; set; }
        public string IdentityType { get; set; }
        public string ScreenName { get; set; }
    }
}
