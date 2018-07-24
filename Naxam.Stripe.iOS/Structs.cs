using System;
using System.Runtime.InteropServices;
using ObjCRuntime;
using Foundation;

namespace StripeSdk
{
	[Native]
	public enum STPShippingType : ulong
	{
		Shipping,
		Delivery 
	}

	[Native]
	public enum STPShippingStatus : ulong
	{
		Valid,
		Invalid
	}

	[Native]
	public enum STPPaymentStatus : ulong
	{
		Success,
		Error,
		UserCancellation
	}

	[Native]
	public enum STPFilePurpose : long
	{
		IdentityDocument,
		DisputeEvidence,
		Unknown
	}

	[Native]
	public enum STPBillingAddressFields : ulong
	{
		None,
		Zip,
		Full,
		FieldsName,
	}

	[Native]
	public enum STPPaymentMethodType : ulong
	{
		None = 0,
		ApplePay = 1 << 0,
		All = ApplePay
	}

	static class CFunctions
	{
		//// extern void linkSTPAPIClientApplePayCategory ();
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern void linkSTPAPIClientApplePayCategory ();

		//// extern void linkUINavigationBarThemeCategory ();
		//[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		//static extern void linkUINavigationBarThemeCategory ();
	}

	[Native]
	public enum STPBankAccountHolderType : long
	{
		Individual,
		Company
	}

	[Native]
	public enum STPBankAccountStatus : long
	{
		New,
		Validated,
		Verified,
		VerificationFailed,
		Errored
	}

	[Native]
	public enum STPCardBrand : long
	{
		Visa,
		Amex,
		MasterCard,
		Discover,
		Jcb,
		DinersClub,
		UnionPay,
		Unknown
	}

	[Native]
	public enum STPCardFundingType : long
	{
		Debit,
		Credit,
		Prepaid,
		Other
	}

	[Native]
	public enum STPCardValidationState : long
	{
		Valid,
		Invalid,
		Incomplete
	}

	[Native]
	public enum STPRedirectContextState : ulong
	{
		NotStarted,
		InProgress,
		Cancelled,
		Completed
	}

	[Native]
	public enum STPSourceCard3DSecureStatus : long
	{
		Required,
		Optional,
		NotSupported,
		Unknown
	}

	[Native]
	public enum STPSourceRedirectStatus : long
	{
		Pending,
		Succeeded,
		Failed,
		Unknown
	}

	[Native]
	public enum STPSourceVerificationStatus : long
	{
		Pending,
		Succeeded,
		Failed,
		Unknown
	}

	[Native]
	public enum STPSourceFlow : long
	{
		None,
		Redirect,
		CodeVerification,
		Receiver,
		Unknown
	}

	[Native]
	public enum STPSourceUsage : long
	{
		Reusable,
		SingleUse,
		Unknown
	}

	[Native]
	public enum STPSourceStatus : long
	{
		Pending,
		Chargeable,
		Consumed,
		Canceled,
		Failed,
		Unknown
	}

	[Native]
	public enum STPSourceType : long
	{
		Bancontact,      
		Card,
		Giropay,
		Ideal,
		SEPADebit,
		Sofort,
		ThreeDSecure,
    	EPS,
    	Multibanco,
		Unknown,

	}

	[Native]
	public enum STPErrorCode : long
	{
		ConnectionError = 40,
		InvalidRequestError = 50,
		APIError = 60,
		CardError = 70,
		CancellationError = 80,
        STPEphemeralKeyDecodingError = 1000,
		CheckoutUnknownError = 5000,
		CheckoutTooManyAttemptsError = 5001,
	}

	// /**
	// Status types for an STPPaymentIntent
	// */
	// typedef NS_ENUM(NSInteger, STPPaymentIntentStatus) {
	[Native]
	public enum STPPaymentIntentStatus: long {
	// /**
	// 	Unknown status
	// 	*/
		Unknown,

	// /**
	// 	This PaymentIntent requires a Source
	// 	*/
		RequiresSource,

	// /**
	// 	This PaymentIntent needs to be confirmed
	// 	*/
		RequiresConfirmation,

	// /**
	// 	The selected Source requires additional authentication steps.
	// 	Additional actions found via `next_source_action`
	// 	*/
		RequiresSourceAction,

	// /**
	// 	Stripe is processing this PaymentIntent
	// 	*/
		Processing,

	// /**
	// 	The payment has succeeded
	// 	*/
		Succeeded,

	// /**
	// 	Indicates the payment must be captured, for STPPaymentIntentCaptureMethodManual
	// 	*/
		RequiresCapture,

	// /**
	// 	This PaymentIntent was canceled and cannot be changed.
	// 	*/
		Canceled,
	// };
	}

	// /**
	// Capture methods for a STPPaymentIntent
	// */
	// typedef NS_ENUM(NSInteger, STPPaymentIntentCaptureMethod) {
	[Native]
	public enum STPPaymentIntentCaptureMethod: long {
	// /**
	// 	Unknown capture method
	// 	*/
		Unknown,

	// /**
	// 	The PaymentIntent will be automatically captured
	// 	*/
		Automatic,

	// /**
	// 	The PaymentIntent must be manually captured once it has the status
	// 	`STPPaymentIntentStatusRequiresCapture`
	// 	*/
		Manual,
	}

	// /**
	// Confirmation methods for a STPPaymentIntent
	// */
	// typedef NS_ENUM(NSInteger, STPPaymentIntentConfirmationMethod) {
	[Native]
	public enum STPPaymentIntentConfirmationMethod: long {
	// /**
	// 	Unknown confirmation method
	// 	*/
		Unknown,

	// /**
	// 	Confirmed via publishable key
	// 	*/
		Publishable,

	// /**
	// 	Confirmed via secret key
	// 	*/
		Secret,
	}
}
