using System;
using Xamarin.UITest;

namespace XamarinMobileWebWrapper.UITests
{
	public static class AppExtensions
	{
		public static string GoToUrl(this IApp app, string url)
		{
			return app.Invoke ("SetWebviewUrl", url).ToString();
		}

		public static string GetCurrentUrl(this IApp app)
		{
			return app.Invoke ("GetCurrentUrl", "").ToString();
		}
	}
}

