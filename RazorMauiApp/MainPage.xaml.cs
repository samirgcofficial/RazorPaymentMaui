using MauiSharedLib;

namespace RazorMauiApp
{
    public partial class MainPage : ContentPage
    {
        private readonly IRazorPayServices razorPayService;
        public MainPage()
        {
            InitializeComponent();
            razorPayService = (IRazorPayServices)(new RazorPayService());
            razorPayService.PaymentSuccess += OnPaymentSuccess;
            razorPayService.PaymentError += OnPaymentError;
        }

        private void OnPaymentError(object sender, (string, IDictionary<string, string>) e)
        {
            App.Current.MainPage.DisplayAlert("Alert", e.Item1.ToString(), "Ok");
        }

        private void OnPaymentSuccess(object sender, IDictionary<string, object> e)
        {
            if (e.ContainsKey("razorpay_payment_id"))
            {
                string paymentId = e["razorpay_payment_id"].ToString();
                App.Current.MainPage.DisplayAlert("Payment Success", $"Payment ID: {paymentId}", "Ok");
            }
            else
            {
                App.Current.MainPage.DisplayAlert("Error", "Payment ID not found", "Ok");
            }
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string OrderID = "order_NdDnVM8wfkHMMV";
            //In order for Razor Payment to function properly,
            //a new order ID must be generated for each successful payment made.
            //You can find more information about this process at the following link:
            //[RazorPay Public Workspace](https://www.postman.com/razorpaydev/workspace/razorpay-public-workspace/folder/12492020-91450029-1c52-4375-8033-39ca4c2d0a8c).

            PaymentDetails paymentDetails = new PaymentDetails
            {
                Amount = "20000",
                Currency = "INR",
                Description = "This is just a test",
                OrderId = OrderID,
                Name = "Samir GC",
                Prefill = new PaymentDetails.PrefillDetails
                {
                    Contact = "+97798482345567",
                    Email = "abc@gmail.com"
                }
            };
            razorPayService.Pay(paymentDetails);

        }
    }

}
