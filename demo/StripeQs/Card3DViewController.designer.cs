// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace StripeQs
{
	[Register ("Card3DViewController")]
	partial class Card3DViewController
	{
		[Outlet]
		UIKit.UIActivityIndicatorView loadingIndicator { get; set; }

		[Outlet]
		StripeSdk.STPPaymentCardTextField paymentTextField { get; set; }

		[Outlet]
		UIKit.UILabel warningPaymentLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (loadingIndicator != null) {
				loadingIndicator.Dispose ();
				loadingIndicator = null;
			}

			if (paymentTextField != null) {
				paymentTextField.Dispose ();
				paymentTextField = null;
			}

			if (warningPaymentLabel != null) {
				warningPaymentLabel.Dispose ();
				warningPaymentLabel = null;
			}
		}
	}
}
