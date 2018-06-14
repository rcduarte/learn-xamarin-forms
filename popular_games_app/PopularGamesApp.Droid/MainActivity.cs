using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using PopularGames.Core;

namespace PopularGamesApp.Droid
{
    [Activity(Label = "PGA",
              Icon = "@mipmap/app_icon", 
              Theme = "@style/MyTheme", 
              MainLauncher = true, 
              ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }
    }
}

