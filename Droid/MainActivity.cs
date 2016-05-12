using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.ComponentModel.Composition;

namespace XamarinMobileWebWrapper.Droid
{
	[Activity (Label = "XamarinMobileWebWrapper.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		private App sharedApp; 

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			sharedApp = new App ();
			LoadApplication (sharedApp);
		}

		[Java.Interop.Export("SetWebviewUrl")]
		public String SetWebviewUrl(String webviewUrl)
		{
			sharedApp.SetUrl (webviewUrl);
			return "URL set to " + webviewUrl;
		}

		[Java.Interop.Export("GetCurrentUrl")]
		public String GetCurrentUrl(String args = "")
		{
			return sharedApp.CurrentUrl;
		}
	}
}

