using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;


namespace ZenDeskSharp.MTSample
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow _window;
		
		public static ZenDeskConfig ZenConfig {
			get {
				return new ZenDeskConfig() {
					Url = "http://cutepuppy.zendesk.com",
					Email = "anuj.bhatia@xamarin.com",
					Password = "Xam_z3ndesk",
					AdminEmail = "anuj.bhatia@xamarin.com",
				};
			}
		}
		
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			_window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			var rootController = new UINavigationController(new TicketsViewController());
			_window.RootViewController = rootController;
			
			_window.MakeKeyAndVisible ();
			return true;
		}
	}
}

