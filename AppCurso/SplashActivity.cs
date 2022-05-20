using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppCurso
{
    [Activity(Label = "SplashActivity", Theme ="@style/SplashTheme",MainLauncher =true, NoHistory =true,
        ConfigurationChanges = ConfigChanges.ScreenSize)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            System.Threading.Thread.Sleep(600);
            StartActivity(new Intent(Application.Context, typeof(ActivityListarModulos)));

            // Create your application here
        }
    }
}