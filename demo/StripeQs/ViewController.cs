using System;
using System.Collections.Generic;
using System.Net.Http;
using Foundation;
using ObjCRuntime;
using StripeSdk;
using UIKit;

namespace StripeQs
{
    public partial class ViewController : UIViewController, ISTPPaymentContextDelegate
    {
        STPPaymentContext paymentContext;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            var config = STPPaymentConfiguration.SharedConfiguration();
            config.ShippingType = STPShippingType.Shipping;
            config.RequiredShippingAddressFields = new NSSet(
                NSNumber.FromInt32((int)PassKit.PKAddressField.PostalAddress),
                NSNumber.FromInt32((int)PassKit.PKAddressField.Phone));

            paymentContext = new STPPaymentContext(new MyAPIClient(), config, STPTheme.DefaultTheme);

            paymentContext.PaymentCurrency = "USD";
            paymentContext.PaymentAmount = 1000;

            paymentContext.WeakDelegate = this;
            paymentContext.HostViewController = this;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton3_TouchUpInside(UIButton sender)
        {
            paymentContext.RequestPayment();
        }

        partial void DSecureButton_TouchUpInside(Foundation.NSObject sender)
        {
            this.NavigationController.PushViewController(new Card3DViewController(),true);
        }

        public void PaymentContext(STPPaymentContext paymentContext, NSError error)
        {
        }

        public void PaymentContextDidChange(STPPaymentContext paymentContext)
        {
        }

        public void PaymentContext(STPPaymentContext paymentContext, STPPaymentResult paymentResult, STPErrorBlock completion)
        {
        }

        public void PaymentContext(STPPaymentContext paymentContext, STPPaymentStatus status, NSError error)
        {
        }
    }

    public class MyAPIClient : NSObject, ISTPBackendAPIAdapter
    {
        static readonly string baseUrl = "https://naxam-stripe.herokuapp.com";
        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri(baseUrl)
        };

        [Export("attachSourceToCustomer:completion:")]
        public async void AttachSourceToCustomer(ISTPSourceProtocol source, STPErrorBlock completion)
        {
			var kv = new KeyValuePair<string, string>[] {
				new KeyValuePair<string, string>("source", source.StripeID )
			};
			var json = await client.PostAsync("/customer/sources", new FormUrlEncodedContent(kv));

			completion(null);
        }

        public async void RetrieveCustomer(STPCustomerCompletionBlock completion)
        {
            var json = await client.GetStringAsync("/customer");
            var data = NSData.FromString(json, NSStringEncoding.UTF8);
            var deserializer = new STPCustomerDeserializer(data, null, null);

            completion(deserializer.Customer, null);


            //var customer = STPCustomer.CustomerWithStripeID("cus_test", null, new STPSourceProtocol[0]);

            //completion(customer, null);
        }

        [Export("selectDefaultCustomerSource:completion:")]
        public async void SelectDefaultCustomerSource(ISTPSourceProtocol source, STPErrorBlock completion)
        {
            var kv = new KeyValuePair<string, string>[] {
                new KeyValuePair<string, string>("source", source.StripeID )
            };
            var json = await client.PostAsync("/customer/default_source", new FormUrlEncodedContent(kv));

            completion(null);
        }
    }
}
