using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proj22
{
    public partial class App : Application
    {
        public static string DatabaseLocation = string.Empty;
        public App()

        {
            InitializeComponent();

        //navigation page + seeting up the rout of the page
            MainPage = new NavigationPage(new MainPage());
        }

        //setting up database
        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DatabaseLocation = databaseLocation;
        }


        //handle when your app starts
        protected override void OnStart()
        {
        }


        //handle when your app sleeps
        protected override void OnSleep()
        {
        }


        //handle when your app resumes
        protected override void OnResume()
        {
        }
    }
}
