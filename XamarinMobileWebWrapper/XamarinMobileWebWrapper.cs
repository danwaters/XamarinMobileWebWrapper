using System;

using Xamarin.Forms;

namespace XamarinMobileWebWrapper
{
	public class App : Application
	{
		public WebView View { get; private set; }
		public string CurrentUrl { get; private set; }

		public App ()
		{
			View = new WebView { StyleId = "webView", VerticalOptions = LayoutOptions.FillAndExpand, HorizontalOptions = LayoutOptions.FillAndExpand };
			// The root page of your application
			MainPage = new ContentPage {
				Content = View,
			};
				
			View.Navigated += (object sender, WebNavigatedEventArgs e) => { CurrentUrl = e.Url; };
		}

		public void SetUrl(string url)
		{
			View.Source = url;
		}

		protected override void OnStart ()
		{
			// Handle when your ap starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

