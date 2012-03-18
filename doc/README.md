# ZenDeskAsharp

##Overview

ZenDeskSharp is a C# Client for the ZenDesk JSON REST API with support for MonoTouch and Mono for Android clients.

## Installation

Build the .NET 4 or Xamarin Mobile project, then `Add Reference...` to the binary in the appropriate project type.

##Usage

	_config = new ZenDeskConfig() {
		Url = "http://{YOUR_URL}.zendesk.com",
		Email = "{YOUR_EMAIL}",
		Password = "{YOUR_PASSWORD}",
	};

	var client = new ZenDeskClient(_config);
	client.GetGroupsAsync()
		.ContinueWith(t => {
			foreach(var group in t.Result) {
				Debug.WriteLine("Group Name: {0}", group.Name);
			}
		});