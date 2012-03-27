using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ZenDeskSharp.Model
{
    [DataContract]
    public class Ticket
    {                
        [DataMember(Name = "assigned_at")]
        public string AssignedAt { get; set; }

        [DataMember(Name = "assignee_id")]
        public string AssigneeId { get; set; }

        [DataMember(Name = "assignee_updated_at")]
        public string AssigneeUpdatedAt { get; set; }

        [DataMember(Name = "created_at")]
        public string CreatedAt { get; set; }

        [DataMember(Name = "subject")]
        public string Subject { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "external_id")]
        public int? ExternalId { get; set; }

        [DataMember(Name = "group_id")]
        public int? GroupId { get; set; }

        [DataMember(Name = "id")]
        public int NiceId { get; set; }

        [DataMember(Name = "linked_id")]
        public int? LinkedId { get; set; }

        [DataMember(Name = "priority_id")]
        public int PriorityId { get; set; }

        [DataMember(Name = "submitter_id")]
        public int SubmitterId { get; set; }

        [DataMember(Name = "status_id")]
        public int StatusId { get; set; }

        [DataMember(Name = "status_updated_at")]
        public string StatusUpdatedAt { get; set; }

        [DataMember(Name = "requester_id")]
        public int RequesterId { get; set; }

        [DataMember(Name = "requester_updated_at")]
        public string RequesterUpdatedAt { get; set; }

        [DataMember(Name = "ticket_type_id")]
        public int TicketTypeId { get; set; }

        [DataMember(Name = "updated_at")]
        public string UpdatedAt { get; set; }

        [DataMember(Name = "via_id")]
        public int ViaId { get; set; }

        [DataMember(Name="set_tags")]
        public string SetTags { get; set; }

        [DataMember(Name = "current_tags")]
        public string CurrentTags { get; set; }

        [DataMember(Name = "score")]
        public int Score { get; set; }

        [DataMember(Name = "comments")]
        public List<Comment> Comments { get; set; }

        [DataMember(Name = "ticket_field_entries")]
        public List<TicketFieldEntry> TicketFieldEntries { get; set; }

        /// <summary>
        /// Note: This is only used for Creating tickets and this field is not returned for getting tickets
        /// </summary>
        [DataMember(Name = "requester_name")]        
        public string RequesterName { get; set; }

        /// <summary>
        /// Note: This is only used for Creating tickets and this field is not returned for getting tickets
        /// </summary>
        [DataMember(Name = "requester_email")]        
        public string RequesterEmail { get; set; }

        /// <summary>
        /// Note: This is only used for Updating tickets and this field is not returned for getting tickets
        /// </summary>
        [DataMember(Name = "additional_tags")]        
        public string AdditionalTags { get; set; }

        [DataMember(Name = "uploads")]
        public string AttachmentsToken { get; set; }

    }

    [DataContract]
    public class TicketFieldEntry
    {
        [DataMember(Name = "ticket_field_id")]
        public int TicketFieldId { get; set; }

        [DataMember(Name = "value")]
        public string Value { get; set; }
    }

    public enum TicketStatus
    {
        New,
        Open,
        Pending,
        Solved,
        Closed
    }

    public enum TicketType
    {
        NoTypeSet,
        Question,
        Incident,
        Problem,
        Task
    }

    public enum TicketPriorities
    {
        NoPrioritySet,
        Low,
        Normal,
        High,
        Urgent

    }

    public enum TicketViaType
    {
        WebForm = 0,
        Mail = 4,
        WebServiceOrApi = 5,
        GetSatisfaction = 16,
        Dropbox = 17,
        TicketMerge = 19,
        RecoveredFromSuspendedTickets = 21,
        TwitterFavorite = 23,
        ForumTopic = 24,
        TwitterDirectMessage = 26,
        ClosedTicket = 27,
        Chat = 29,
        TwitterPublicMention = 30

    }
}
