using System;
using ZenDeskSharp.Model;
using RestSharp;
using ServiceStack.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using ZenDeskSharp.Properties;

namespace ZenDeskSharp
{
    public partial class ZenDeskClient
    {
        private static RestClient _client;

        public ZenDeskClient()
            : base(Settings.Default.ZendeskUrl, Settings.Default.ZendeskEMail, Settings.Default.ZendeskPassword)
        { }

        public ZenDeskClient(ZenDeskConfig config)
            : base(config.Url, config.Email, config.Password)
        { }

        public ZenDeskClient(string url, string email, string password)
            : base(new RestClient(url) { Authenticator = new HttpBasicAuthenticator(email, password) })
        { }

        public ZenDeskClient(RestClient client)
        {
            _client = client;
        }

        public string GetSearchRecords(string searchQuery, Type entityType = null, SearchSortType sortType = null)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                throw new ArgumentNullException(Resources.Exception_Null_Parameter_searchQuery);
            }

            var req = new RestRequest(
                string.Format("search.json?query={0}",
                searchQuery));
            var resp = _client.Execute(req);

            return resp.Content;
        }

        public Task<string> SearchAsync(string searchQuery, Type entityType = null, SearchSortType sortType = null)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                throw new ArgumentNullException(Resources.Exception_Invalid_Parameter_searchQuery);
            }

            return Task.Factory.StartNew<string>(() =>
            {
                return GetSearchRecords(searchQuery);
            });
        }

        public IEnumerable<TagScore> GetTags()
        {
            var req = new RestRequest("tags.json");
            var resp = _client.Execute(req);

            return DeserializeTags(resp.Content);
        }

        public Task<IEnumerable<TagScore>> GetTagsAsync()
        {
            return Task.Factory.StartNew<IEnumerable<TagScore>>(() =>
            {
                return GetTags();
            });
        }

        public IEnumerable<Group> GetGroups()
        {
            var req = new RestRequest("groups.json");
            var resp = _client.Execute(req);

            return DeserializeGroups(resp.Content);
        }

        public Task<IEnumerable<Organization>> GetOrganizationsAsync()
        {
            return Task.Factory.StartNew<IEnumerable<Organization>>(() =>
            {
                return GetOrganizations();
            });
        }

        public Task<Organization> GetOrganizationAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException(Resources.Exception_Invalid_parameter_id);
            }

            return Task.Factory.StartNew<Organization>(() =>
            {
                return GetOrganization(id);
            });
        }

        public Ticket GetTicket(string id)
        {
            var uri = string.Format(@"tickets/{0}.json", id);
            var req = new RestRequest(uri);
            var resp = _client.Execute(req);

            return DeserializeTicket(resp.Content);
        }

        public Task<Ticket> GetTicketAsync(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentNullException(Resources.Exception_Invalid_parameter_id);
            }

            return Task.Factory.StartNew<Ticket>(() =>
            {
                return GetTicket(id);
            });
        }

        public IEnumerable<User> GetUsers()
        {
            var req = new RestRequest("users.json");
            var resp = _client.Execute(req);

            return DeserializeUsers(resp.Content);
        }

        public User GetCurrentUser()
        {
            var uri = string.Format("users/current.json");
            var req = new RestRequest(uri);
            var resp = _client.Execute(req);

            return DeserializeUser(resp.Content);
        }

        public User GetUser(string id)
        {
            var uri = string.Format("users/{0}.json", id);
            var req = new RestRequest(uri);
            var resp = _client.Execute(req);

            return DeserializeUser(resp.Content);
        }

        public Task<IEnumerable<User>> GetUsersAsync()
        {
            return Task.Factory.StartNew<IEnumerable<User>>(() =>
            {
                return GetUsers();
            });
        }

        #region "Private Methods"

        private IEnumerable<Group> DeserializeGroups(string json)
        {
            return JsonArrayObjects.Parse(json).ConvertAll(x => new Group
            {
                Id = x.Get<int>("id"),
                CreatedAt = x.Get("created_at"),
                UpdatedAt = x.Get("updated_at"),
                IsActive = x.Get<bool>("is_active"),
                Name = x.Get("name"),
            });
        }

        private IEnumerable<TagScore> DeserializeTags(string json)
        {
            return JsonArrayObjects.Parse(json).ConvertAll(x => new TagScore
            {
                Id = x.Get<int>("id"),
                Count = x.Get<int>("count"),
                Name = x.Get("name"),
            });
        }

        private IEnumerable<Organization> GetOrganizations()
        {
            var req = new RestRequest("organizations.json");
            var resp = _client.Execute(req);

            return DeserializeOrganizations(resp.Content);
        }

        private Organization GetOrganization(string id)
        {
            var uri = string.Format("organizations/{0}.json", id);
            var req = new RestRequest(uri);
            var resp = _client.Execute(req);

            return DeserializeOrganization(resp.Content);
        }

        private Organization DeserializeOrganization(string json)
        {
            return JsonObject.Parse(json).ConvertTo(DeserializeOrganizationObject);
        }

        private IEnumerable<Organization> DeserializeOrganizations(string json)
        {
            return JsonArrayObjects.Parse(json).ConvertAll(DeserializeOrganizationObject);
        }

        private Organization DeserializeOrganizationObject(JsonObject jsonObject)
        {
            return jsonObject.ConvertTo(x => new Organization
            {
                Id = x.Get<int>("id"),
                Name = x.Get("name"),
                IsShared = x.Get<bool>("is_shared"),
                Default = x.Get("default"),
            });
        }

        private Ticket DeserializeTicket(string json)
        {
            return JsonObject.Parse(json).ConvertTo(x => new Ticket
            {
                AssignedAt = x.Get("assigned_at"),
                AssigneeId = x.Get("assignee_id"),
                AssigneeUpdatedAt = x.Get("assignee_update_at"),
                CreatedAt = x.Get("created_at"),
                Description = x.Get("description"),
                Subject = x.Get("subject"),
                PriorityId = x.Get<int>("priority_id"),
                SubmitterId = x.Get<int>("submitter_id"),
                StatusId = x.Get<int>("status_id"),
                StatusUpdatedAt = x.Get("status_updated_at"),
                RequesterId = x.Get<int>("requester_id"),
                RequesterUpdatedAt = x.Get("requester_updated_at"),
                TicketTypeId = x.Get<int>("ticket_type_id"),
                UpdatedAt = x.Get("updated_at"),
                ViaId = x.Get<int>("via_id"),
                CurrentTags = x.Get("current_tags"),
                Score = x.Get<int>("score"),
            });
        }

        private User DeserializeUser(string json)
        {
            var jsonObject = JsonObject.Parse(json);
            return DeserializeUserObject(jsonObject);
        }

        private IEnumerable<User> DeserializeUsers(string json)
        {
            return JsonArrayObjects.Parse(json).ConvertAll(DeserializeUserObject);
        }

        private User DeserializeUserObject(JsonObject jsonObject)
        {
            return jsonObject.ConvertTo(x => new User
            {
                Id = x.Get<int?>("id"),
                CreatedAt = x.Get("created_at"),
                Email = x.Get("email"),
                IsActive = x.Get<bool>("is_active"),
                IsVerified = x.Get<bool>("is_verified"),
            });
        }

        #endregion

    }
}

