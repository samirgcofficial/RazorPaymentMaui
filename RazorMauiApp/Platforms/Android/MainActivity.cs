using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Razorpay;
using MauiSharedLib;

namespace RazorMauiApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity,IPaymentResultWithDataListener
    {
        public void OnPaymentError(int p0, string? p1, PaymentData? p2)
        {
            App.Current.MainPage.DisplayAlert("Alert", p1.ToString(), "Ok");
        }

        public void OnPaymentSuccess(string? p0, PaymentData? p1)
        {
            if (p1.PaymentId!=null)
            {
                App.Current.MainPage.DisplayAlert("Alert", "Success " + p1.ToString(), "Ok");
            }
            else
            {

            }
        }

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RazorPayService.Init(this, "rzp_test_m9jmynsTPIHEDl"); //Add your Razor Pay Api Key https://dashboard.razorpay.com/app/website-app-settings/api-keys 
        }
    }
}
