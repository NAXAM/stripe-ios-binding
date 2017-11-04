using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Foundation;
using StripeSdk;
using UIKit;

namespace StripeQs
{
    public partial class Card3DViewController : UIViewController,StripeSdk.ISTPPaymentCardTextFieldDelegate
    {
        private const string REDIRECT_URL = "payments-page://stripe-redirect";
        public Card3DViewController() : base("Card3DViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Initialize();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        protected void Initialize()
        {
            NavigationItem.RightBarButtonItem = new UIBarButtonItem("Pay", UIBarButtonItemStyle.Done, (sender, e) =>
            {
                View.EndEditing(true);
                Pay();
            });
            NavigationItem.RightBarButtonItem.Enabled = false;
            //NavigationItem.RightBarButtonItem.TintColor = ColorHub.Instance.Gold.ToNativeColor();

            paymentTextField.WeakDelegate = this;

        }

        private void Pay()
        {
            if (!paymentTextField.IsValid)
                return;
            UpdateUIWhenPaymentInProgress(true);

            var config = STPPaymentConfiguration.SharedConfiguration();
			nuint centAmount = (nuint)(10 * 100);
			string cur = "sgd";
            STPAPIClient stripeClient = new STPAPIClient(config);
            STPSourceParams sourceParams = STPSourceParams.CardParamsWithCard(paymentTextField.CardParams);
            stripeClient.CreateSourceWithParams(sourceParams, (STPSource source, NSError error) =>
            {
                if (error != null)
                {
                    System.Diagnostics.Debug.WriteLine(error.ToString());
                    return;
                }
                if (source.CardDetails.ThreeDSecure == STPSourceCard3DSecureStatus.Required)
                {
                    //TODO: need update currency for stripeAPI.
                    var threeSourceParams = STPSourceParams.ThreeDSecureParamsWithAmount(centAmount, cur, REDIRECT_URL, (source).StripeID);
                    stripeClient.CreateSourceWithParams(threeSourceParams, (STPSource arg0, NSError arg1) =>
                    {
                        if (error != null)
                        {
                            System.Diagnostics.Debug.WriteLine("Payment Failed");
                        }
                        else
                        {
                            STPRedirectContext redirectContext = new STPRedirectContext(arg0, (string sourceId, string clientSecret, NSError arg2) =>
                            {
                                STPAPIClient.SharedClient().StartPollingSourceWithId(sourceId, clientSecret, 10, (STPSource sourcex, NSError errorx) =>
                                {
                                    UpdateUIWhenPaymentInProgress(false);
                                    switch (sourcex.Status)
                                    {
                                        case STPSourceStatus.Chargeable:
                                            //TODO: charge.
                                            Charge(source.StripeID, (int)centAmount);
                                            //ViewModel.Charge((sourcex).StripeID, _order);
                                            break;
                                        case STPSourceStatus.Consumed:
                                            //TODO: continute payment.
                                            Debug.WriteLine("Payment Success");
                                            //Navigator.NavigateTo((int)ScreenKey.PaymentCompleted);
                                            break;
                                        case STPSourceStatus.Canceled:
                                            break;
                                        case STPSourceStatus.Pending:
                                        case STPSourceStatus.Failed:
                                        case STPSourceStatus.Unknown:
                                            //UserDialogs.Instance.AlertEx("Payment Failed");
                                            System.Diagnostics.Debug.WriteLine("Payment Failed");
                                            break;
                                    }
                                });
                            });

                            redirectContext.StartRedirectFlowFromViewController(this);
                        }

                    });
                }
                else
                {

                    if (source != null)
                    {
                        string stripeID = (source).StripeID;
                        //ViewModel.Charge((source).StripeID, _order);
                        Charge(source.StripeID, (int)centAmount);
                    }
                }
            });
        }

        [Export("paymentCardTextFieldDidChange:")]
        public void PaymentCardTextFieldDidChange(StripeSdk.STPPaymentCardTextField textField)
        {
            NavigationItem.RightBarButtonItem.Enabled = textField.IsValid;
        }

        private void UpdateUIWhenPaymentInProgress(bool inprogress)
        {
            warningPaymentLabel.Alpha = loadingIndicator.Alpha = inprogress ? 1 : 0;

            if (NavigationItem.RightBarButtonItem != null)
            {
                NavigationItem.RightBarButtonItem.Enabled = !inprogress;
            }

            if (NavigationItem.LeftBarButtonItem != null)
            {
                NavigationItem.LeftBarButtonItem.Enabled = !inprogress;
            }
            if (inprogress)
            {
                loadingIndicator.StartAnimating();
            }
            else
            {
                loadingIndicator.StopAnimating();
            }
        }

        HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://naxam-stripe.herokuapp.com"),
        };

        public void Charge(string sourceId, int amount)
        {
            var kv = new KeyValuePair<string, string>[] {
                new KeyValuePair<string, string>("source", sourceId ),
                new KeyValuePair<string, string>("amount", amount.ToString())
            };
            var json = client.PostAsync("/create_charge", new FormUrlEncodedContent(kv)).Result.Content.ReadAsStringAsync().Result;
            Debug.WriteLine($"Charge>>>>> {sourceId} {amount} \n response:{json}");
        }
    }
}

