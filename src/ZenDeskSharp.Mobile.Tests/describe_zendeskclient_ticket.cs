using System;
using NUnit.Framework;

namespace ZenDeskSharp.Mobile.Tests
{
	[TestFixture]
	public class describe_zendeskclient_ticket
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
		public void should_get_tickets()
		{
			var client = new ZenDeskClient(_config);
			var result = client.GetTicket("1");
			Assert.NotNull(result);
			
		}
	}
}

