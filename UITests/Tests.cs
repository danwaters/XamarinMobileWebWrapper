using NUnit.Framework;
using Xamarin.UITest;

namespace XamarinMobileWebWrapper.UITests
{
	[TestFixture (Platform.Android)]
	[TestFixture (Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		[Test]
		public void LoadGoogle ()
		{
			app.Repl ();
			app.Screenshot ("App is loading");

			app.GoToUrl ("http://www.google.com");

			app.Screenshot ("Loading the Googs");

			app.WaitForElement (e => e.WebView ());
			app.WaitForElement (e => e.Css ("img"));
			app.Screenshot ("Typical Google with your image.");

			app.EnterText (e => e.Css ("input"), "Xamarin");
			app.Tap (e => e.Css ("button"));
		}
	}
}

