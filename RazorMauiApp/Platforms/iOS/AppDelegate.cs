using Foundation;
using MauiSharedLib;
using UIKit;

namespace RazorMauiApp
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();


        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);
            RazorPayService.Init("rzp_test_m9jmynsTPIHEDl");//Add your Razor Pay Api Key https://dashboard.razorpay.com/app/website-app-settings/api-keys 
            return result;
        }
    }
}
