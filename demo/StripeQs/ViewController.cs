using System;
using System.Net.Http;
using Foundation;
using ObjCRuntime;
using StripeSdk;
using UIKit;

namespace StripeQs
{
    public partial class ViewController : UIViewController
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

            paymentContext = new STPPaymentContext(new MyAPIClient(), config, STPTheme.DefaultTheme);

            paymentContext.PaymentCurrency = "USD";
            paymentContext.PaymentAmount = 1000;

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
    }

    public class MyAPIClient : NSObject, ISTPBackendAPIAdapter
    {
        static readonly string baseUrl = "https://naxam-stripe.herokuapp.com";
        HttpClient client = new HttpClient {
            BaseAddress = new Uri(baseUrl)
        } ;

        public void AttachSourceToCustomer(ISTPSourceProtocol source, STPErrorBlock completion)
        {
            
        }

        public async void RetrieveCustomer(STPCustomerCompletionBlock completion)
        {
            //var json = await client.GetStringAsync("/customer");
            //var data = NSData.FromString(json, NSStringEncoding.UTF8);
            //var deserializer = new STPCustomerDeserializer(data, null, null);

            //completion(deserializer.Customer, null);


            var customer = STPCustomer.CustomerWithStripeID("cus_test", null, new STPSourceProtocol[0]);

            completion(customer, null);
        }

        public void SelectDefaultCustomerSource(ISTPSourceProtocol source, STPErrorBlock completion)
        {
        }
    }
}
