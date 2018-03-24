using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

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
            AppCenter.Start("ios=a99c1462-989e-4036-873f-4c6cd1648ec6;" + "uwp=0a2c3083-8525-4821-a6fc-147569f2ae67;" + "android=2270b668-7da3-452b-8b6d-2c990fa92f9b", typeof(Analytics), typeof(Crashes));



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
