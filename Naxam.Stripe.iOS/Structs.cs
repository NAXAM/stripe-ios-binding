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
		Full
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
		Bitcoin,
		Card,
		Giropay,
		Ideal,
		SEPADebit,
		Sofort,
		ThreeDSecure,
		Unknown
	}

	[Native]
	public enum STPErrorCode : long
	{
		ConnectionError = 40,
		InvalidRequestError = 50,
		APIError = 60,
		CardError = 70,
		CancellationError = 80,
		CheckoutUnknownError = 5000,
		CheckoutTooManyAttemptsError = 5001
	}
}
