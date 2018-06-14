using Foundation;
using PopularGames.Core;
using UIKit;
using Xamarin.Forms.Platform.iOS;

namespace PopularGamesApp.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
