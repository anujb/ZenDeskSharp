using System.Collections.Generic;
using System.Linq;

namespace ZenDeskSharp.Model
{
    public class Group
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public bool IsActive { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

        public List<User> Users { get; set; }

        public List<int> UserIds { get; set; }

        public void CopyUsersToUserIds()
        {
            if (Users != null && Users.Count > 0)                
                UserIds = Users.Select(x => (int)x.Id).ToList();            
        }
    }
}
