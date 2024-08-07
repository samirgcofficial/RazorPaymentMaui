# Razor Payment Native Plugin for .NET MAUI

<img width="1098" alt="Screenshot 2024-02-19 at 19 20 32" src="https://github.com/samirgcofficial/RazorPaymentMaui/assets/55045516/a0336a74-182d-46f2-81d4-de14855d33ef">


![RazorPay](https://github.com/samirgcofficial/RazorPaymentMaui/assets/55045516/fc487275-90f4-4117-859d-6ee8ca586f8c)

Welcome to the Razor Payment Plugin for .NET MAUI repository! Our Plugin provides seamless integration with Razorpay's powerful payment gateway, enabling developers to quickly and securely accept payments in their .NET MAUI applications.

## Features

- **Easy Integration**: Integrate Razorpay's payment gateway into your .NET MAUI apps with just a few lines of code.
- **Secure Transactions**: Ensure secure and encrypted payment transactions for your users.

## Getting Started

To start using the Razor Payment Plugin in your .NET MAUI project, follow these simple steps:

 **Installation**: Install the Razor Payment Plugin NuGet package in your .NET MAUI project.
   ```sh
  dotnet add package Plugin.Maui.RazorPaymentMin --version 1.1.1
```

# Maui Android Implementation MainActivity.cs
```csharp
   protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RazorPayService.Init(this, "rzp_test_xxxxxxxxx"); //Add your Razor Pay Api Key https://dashboard.razorpay.com/app/website-app-settings/api-keys 
        }
```

# Maui iOS Create payment details AppDelegate.cs

```csharp
 public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);
            RazorPayService.Init("rzp_test_xxxxxxxx");//Add your Razor Pay Api Key https://dashboard.razorpay.com/app/website-app-settings/api-keys 
            return result;
        }
```

# Dotnet MAUI Implementation 
```csharp
string OrderID = "order_NcnXXXXXX";
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

```
** How to add plugin on .net 8 project ??? **
https://drive.google.com/file/d/1aKybP5vjAinlnGG3IlRyQm4bQcOmT2sf/view?usp=sharing

# ** Alert! **
Please authenticate with your credentials before testing the sample app. To generate an order ID, please refer to this instructional video: [link](https://drive.google.com/file/d/1q16mLdK4ZdmLHQ-SVPm-cuDfPHkwuPlk/view?usp=sharing).

**Activate UPI Payment on your dashboard**
For instructions, visit: [Razorpay Documentation](https://razorpay.com/docs/payments/smart-collect/create/)


**Unlock the Full Version**
Gain access to the entire plugin, free from the evaluation limitations, by supporting our project with a small contribution. Your support acknowledges our hard work and dedication 🥰. We suggest trying the evaluation copy before purchasing. Plus, I've made it affordable for all customers.
[Support us](https://www.buymeacoffee.com/samirgc/e/222788)
