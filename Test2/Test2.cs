using System;

using Xamarin.Forms;

namespace Test2
{
	public class App : Application
	{
		public App ()
		{
			var mainView = new MainView ();
			MainPage = new NavigationPage(mainView);
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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

