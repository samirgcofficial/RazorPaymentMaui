# Razor Payment SDK for .NET MAUI

![Razor Payment SDK Logo](https://example.com/razor-payment-sdk-logo.png)

Welcome to the Razor Payment SDK for .NET MAUI repository! Our SDK provides seamless integration with Razorpay's powerful payment gateway, enabling developers to quickly and securely accept payments in their .NET MAUI applications.

## Features

- **Easy Integration**: Integrate Razorpay's payment gateway into your .NET MAUI apps with just a few lines of code.
- **Secure Transactions**: Ensure secure and encrypted payment transactions for your users.
- **Customizable UI**: Customize the payment UI to match the look and feel of your app.
- **Supports Multiple Payment Methods**: Accept payments via credit/debit cards, net banking, UPI, wallets, and more.
- **Comprehensive Documentation**: Detailed documentation and code examples to help you get started quickly.

## Getting Started

To start using the Razor Payment SDK in your .NET MAUI project, follow these simple steps:

1. **Installation**: Install the Razor Payment SDK NuGet package in your .NET MAUI project.
   ```sh
   nuget install RazorPaymentMin.Sdk (https://www.nuget.org/packages/Plugin.Maui.RazorPaymentMin)

Usage: Initialize the Razor Payment SDK with your Razorpay API key and integrate the payment UI into your app.

using Plugin.Maui.RazorPaymentMin;

// Initialize Razor Payment SDK
RazorPaymentMin.Initialize("YOUR_API_KEY");

// Create payment details
var paymentDetails = new PaymentDetails
{
    // Set payment details such as amount, currency, order ID, etc.
};

// Open payment UI
RazorPaymentMin.OpenPaymentUI(paymentDetails);


**Full Version**
For the full version of the SDK without the evaluation copy, consider supporting the project by buying us a coffee.
https://www.buymeacoffee.com/samirgc/e/222788