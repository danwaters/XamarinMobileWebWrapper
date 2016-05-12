using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace XamarinMobileWebWrapper.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		private XamarinMobileWebWrapper.App sharedApp;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			sharedApp = new XamarinMobileWebWrapper.App ();
			LoadApplication (sharedApp);

			return base.FinishedLaunching (app, options);
		}

		[Export("SetWebviewUrl:")]
		public NSString SetWebviewUrl(NSString webviewUrl)
		{
			sharedApp.SetUrl (webviewUrl);
			return new NSString("Set URL to " + webviewUrl);
		}

		[Export("GetCurrentUrl:")]
		public string GetCurrentUrl(String args = "")
		{
			return sharedApp.CurrentUrl;
		}
	}
}

