using System;
using System.Linq;
using NUnit.Framework;

namespace ZenDeskSharp.Mobile.Tests
{
	[TestFixture]
	public class describe_zendeskclient_user
	{
		ZenDeskConfig _config;
		
		[SetUp]
		public void setup()
		{
			_config = new ZenDeskConfig() {
				Url = "http://cutepuppy.zendesk.com",
				Email = "anuj.bhatia@xamarin.com",
				Password = "Xam_z3ndesk",
				AdminEmail = "anuj.bhatia@xamarin.com",
			};
		}
		
		[Test]
		public void should_initialize_get_users()
		{
			var client = new ZenDeskClient(_config);
			var users = client.GetUsers();
			Assert.True(users.Any());
		}
		
		[Test]
		public void should_initialize_get_user()
		{
			var client = new ZenDeskClient(_config);
			var user = client.GetUser("20168852");
			Assert.NotNull(user);
		}
		
		[Test]
		public void should_initialize_get_currentuser()
		{
			var client = new ZenDeskClient(_config);
			var user = client.GetCurrentUser();
			
			Assert.NotNull(user);
		}
		
	}
}

