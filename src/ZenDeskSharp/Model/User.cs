using System.Collections.Generic;

namespace ZenDeskSharp.Model
{
    public class User
    {
        public string Name { get; set; }

        public string LocaleId { get; set; }

		public string PhotoUrl { get; set; }

        public string OpenidUrl { get; set; }

        public string CreatedAt { get; set; }

        public string LastLogin { get; set; }

        public string Details { get; set; }

        public string UpdatedAt { get; set; }

		public string Notes { get; set; }

        public string Email { get; set; }

        public string ExternalId { get; set; }

        public int? RestrictionId { get; set; }

		public int? Id { get; set; }

		public string Phone { get; set; }

        public bool IsActive { get; set; }

        public bool IsVerified { get; set; }

        public string TimeZone { get; set; }

        public int? Role { get; set; }

        public int? OrganizationId { get; set; }

        public List<Group> Groups { get; set; }

        public bool? Uses12HourClock { get; set; }

        public string Password { get; set; }

        public List<int> GroupIds { get; set; }       
    }

    public enum Role
    {
        EndUser = 0,
        Administrator = 2,
        Agent = 4
    }

    public enum RestrictedTo
    {
        AllTickets,
        TicketsInMemberGroup,
        TicketsInMemberOrganization,
        AssignedTickets,
        TicketsRequestedByUser
    }
}
