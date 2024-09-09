using MauiSharedLib;

namespace RazorMauiApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            RazorPayment.PaymentSuccess += OnPaymentSuccess;
            RazorPayment.PaymentError += OnPaymentError;
        }

        private void OnPaymentError(object sender, (string, IDictionary<string, string>) e)
        {
            string errorMessage = e.Item1;
            IDictionary<string, string> errorDetails = e.Item2;

            MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await App.Current.MainPage.DisplayAlert("Alert", errorMessage, "Ok");
            });
        }

        private void OnPaymentSuccess(object sender, IDictionary<string, object> e)
        {
            if (e.ContainsKey("PaymentId"))
            {
                string paymentId = e["PaymentId"].ToString();

                MainThread.InvokeOnMainThreadAsync(async () =>
                {
                    App.Current.MainPage.DisplayAlert("Payment Success", $"Payment ID: {paymentId}", "Ok");
                });
            }
            else
            {
                MainThread.InvokeOnMainThreadAsync(async () =>
                {
                    App.Current.MainPage.DisplayAlert("Error", "Payment ID not found", "Ok");
                });
            }
        }

        private void OnPayButtonClicked(object sender, EventArgs e)
        {
            var paymentDetails = new PaymentDetails
            {
                Name = "Test Product",
                Description = "Product Description",
                Image = "https://example.com/image.png",
                OrderId = "order_Ov33HouGAqUzQr",
                Currency = "INR",
                Amount = "10000", // amount in subunits
                Prefill = new PaymentDetails.PrefillDetails
                {
                    Email = "user@example.com",
                    Contact = "1234567890"
                }
            };
            RazorPayment.Pay(paymentDetails);
        }

        private void OnSubscriptionPayButtonClicked(object sender, EventArgs e)
        {
            var subscriptionDetails = new SubscriptionDetails
            {
                Name = "Subscription Product",
                Description = "Subscription Description",
                Image = "https://example.com/image.png",
                SubscriptionId = "sub_Ov4MlMC7bWYU29", // Generate a subscription id from backend
                Currency = "INR",
                Amount = "10000", // amount in subunits

            };

            RazorPayment.SubscriptionPay(subscriptionDetails);
        }
    }
}
