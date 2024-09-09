using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Razorpay;
using MauiSharedLib;

namespace RazorMauiApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity, IPaymentResultWithDataListener
    {
        public void OnPaymentSuccess(string p0, PaymentData p1)
        {
            RazorPayment.DroidPaymentSuccess(p0, p1);
        }
        public void OnPaymentError(int p0, string p1, PaymentData p2)
        {
            RazorPayment.DroidPaymentError(p0, p1, p2);
        }

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }
    }
}

