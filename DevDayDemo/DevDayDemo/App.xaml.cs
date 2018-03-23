using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DevDayDemo
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new DevDayDemo.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts
            AppCenter.Start("android=40747f32-dee6-4395-bf4c-22f56288d21e;" + "uwp=68a1f310-91ac-4ab4-bf96-59ca5c4c4703;" + "ios=a113d67a-d76c-4411-b00c-710b824d2523", typeof(Analytics), typeof(Crashes));
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
