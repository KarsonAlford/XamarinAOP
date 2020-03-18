using System;
using System.Diagnostics;
using Xamarin.Forms;
using XamerinAOP.Attributes;

namespace XamarinAOP
{
    [ErrorLogging]
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine("Before Error");

            throw new Exception("Error during OnStart");
            
            Debug.WriteLine("After Error"); // Even continuing in ErrorLogging should not allow this line to execute.
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
