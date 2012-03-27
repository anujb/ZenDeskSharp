using System;
using MonoTouch.Dialog;

namespace ZenDeskSharp.MTSample
{
	public class TicketsViewController : DialogViewController
	{
		ZenDeskClient _client;
		
		public TicketsViewController()
			: base(new RootElement("Tickets"), true)
		{
			_client = new ZenDeskClient(AppDelegate.ZenConfig);
		}
		
		public override void LoadView ()
		{
			base.LoadView ();
			
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
		}
		
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
			_client.GetTicketAsync("1").ContinueWith(task => {
				var section = new Section("");
				
				section.Add(new StringElement(task.Result.RequesterName));
				
				
				this.Root.Add (section);
				
				BeginInvokeOnMainThread(() =>{
					this.ReloadData();
				});
			});
		}
		
		public override void ViewWillLayoutSubviews ()
		{
			base.ViewWillLayoutSubviews ();
		}
		
		
		
		
	}
}

