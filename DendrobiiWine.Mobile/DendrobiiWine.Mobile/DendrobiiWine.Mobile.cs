using DendrobiiWine.Mobile.Views;
using DendrobiiWine.Mobile.Views.Customer;
using System;

using Xamarin.Forms;

namespace DendrobiiWine.Mobile
{
	public class App : Application
	{
		public App ()
		{
            MainPage =  new LoginPage();
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

