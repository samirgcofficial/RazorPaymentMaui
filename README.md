# Razor Payment Native Plugin for .NET MAUI

![RazorPay](https://raw.githubusercontent.com/samirgcofficial/RazorPaymentMaui/main/Images/razorpay.png)

![RazorPay](https://github.com/samirgcofficial/RazorPaymentMaui/assets/55045516/fc487275-90f4-4117-859d-6ee8ca586f8c)

Welcome to the Razor Payment Plugin for .NET MAUI repository! Our Plugin provides seamless integration with Razorpay's powerful payment gateway, enabling developers to quickly and securely accept payments in their .NET MAUI applications.

## Features

- **Easy Integration**: Integrate Razorpay's payment gateway into your .NET MAUI apps with just a few lines of code.
- **Secure Transactions**: Ensure secure and encrypted payment transactions for your users.

## Getting Started

To start using the Razor Payment Plugin in your .NET MAUI project, follow these simple steps:

 **Installation**: Install the Razor Payment Plugin NuGet package in your .NET MAUI project. (https://www.nuget.org/packages/Plugin.Maui.RazorPaymentMin/0.0.1)
   ```sh
   dotnet add package Plugin.Maui.RazorPaymentMin --version 0.0.1 
```

# Initialize Razor Payment Plugin inside MauiProgram.cs
```csharp
 .UseMauiRazorPay("rzp_test_xxxxxxxxxx") // https://dashboard.razorpay.com/app/website-app-settings/api-keys
```

# Maui Android Implementation MainActivity.cs
```csharp
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
```

# Dotnet MAUI Implementation 
```csharp
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

        private void OnSubscriptionPayButtonClicked(object sender, EventArgs e)
        {
            var subscriptionDetails = new SubscriptionDetails
            {
                Name = "Subscription Product",
                Description = "Subscription Description",
                Image = "https://example.com/image.png",
                SubscriptionId = "sub_OuAzvaFxlUpiLN", // Generate a subscription id from backend
                Currency = "INR",
                Amount = "10000", // amount in subunits

            };

            RazorPayment.SubscriptionPay(subscriptionDetails);
        }
    }

```
# ** How to add plugin on .net 8 project ???  **
https://drive.google.com/file/d/1aKybP5vjAinlnGG3IlRyQm4bQcOmT2sf/view?usp=sharing


# ** Alert! **
Please authenticate with your credentials before testing the sample app. To generate an order ID, please refer to this instructional video: [link](https://drive.google.com/file/d/1q16mLdK4ZdmLHQ-SVPm-cuDfPHkwuPlk/view?usp=sharing).

# ** Activate UPI Payment on your dashboard**
For instructions, visit: [Razorpay Documentation](https://razorpay.com/docs/payments/smart-collect/create/)


# ** Unlock the Full Version **
Gain access to the entire plugin, free from the evaluation limitations, by supporting our project with a small contribution. Your support acknowledges our hard work and dedication 🥰. We suggest trying the evaluation copy before purchasing. Plus, I've made it affordable for all customers.
[Support us](https://www.buymeacoffee.com/samirgc/e/222788)


**Unlock the Full Version**
Gain access to the entire plugin, free from the evaluation limitations, by supporting our project with a small contribution. Your support acknowledges our hard work and dedication 🥰. We suggest trying the evaluation copy before purchasing. Plus, I've made it affordable for all customers.
[Support us](https://www.buymeacoffee.com/samirgc/e/222788)
