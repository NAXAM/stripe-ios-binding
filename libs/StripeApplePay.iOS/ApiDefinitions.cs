using System;
using Foundation;
using ObjCRuntime;
using PassKit;
using StripeApplePay;
using UIKit;

namespace StripeApplePay
{
	// @interface _stpinternal_APContextSwift : NSObject <PKPaymentAuthorizationControllerDelegate>
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface _stpinternal_APContextSwift : IPKPaymentAuthorizationControllerDelegate
	{
		// -(void)presentApplePayOnViewController:(UIViewController * _Nonnull)viewController completion:(void (^ _Nullable)(void))completion __attribute__((deprecated("Use `presentApplePay(completion:)` instead.", "presentApplePay(completion:)")));
		[Export ("presentApplePayOnViewController:completion:")]
		void PresentApplePayOnViewController (UIViewController viewController, [NullAllowed] Action completion);

		// -(BOOL)respondsToSelector:(SEL _Null_unspecified)aSelector __attribute__((warn_unused_result("")));
		[Export ("respondsToSelector:")]
		bool RespondsToSelector (Selector aSelector);

		// -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didAuthorizePayment:(PKPayment * _Nonnull)payment handler:(void (^ _Nonnull)(PKPaymentAuthorizationResult * _Nonnull))completion;
		[Export ("paymentAuthorizationController:didAuthorizePayment:handler:")]
		void PaymentAuthorizationController (PKPaymentAuthorizationController controller, PKPayment payment, Action<PKPaymentAuthorizationResult> completion);

		// -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod handler:(void (^ _Nonnull)(PKPaymentRequestShippingMethodUpdate * _Nonnull))completion;
		[Export ("paymentAuthorizationController:didSelectShippingMethod:handler:")]
		void PaymentAuthorizationController (PKPaymentAuthorizationController controller, PKShippingMethod shippingMethod, Action<PKPaymentRequestShippingMethodUpdate> completion);

		// -(void)paymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller didSelectShippingContact:(PKContact * _Nonnull)contact handler:(void (^ _Nonnull)(PKPaymentRequestShippingContactUpdate * _Nonnull))completion;
		[Export ("paymentAuthorizationController:didSelectShippingContact:handler:")]
		void PaymentAuthorizationController (PKPaymentAuthorizationController controller, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> completion);

		// -(void)paymentAuthorizationControllerDidFinish:(PKPaymentAuthorizationController * _Nonnull)controller;
		[Export ("paymentAuthorizationControllerDidFinish:")]
		void PaymentAuthorizationControllerDidFinish (PKPaymentAuthorizationController controller);

		// -(UIWindow * _Nullable)presentationWindowForPaymentAuthorizationController:(PKPaymentAuthorizationController * _Nonnull)controller __attribute__((warn_unused_result("")));
		[Export ("presentationWindowForPaymentAuthorizationController:")]
		[return: NullAllowed]
		UIWindow PresentationWindowForPaymentAuthorizationController (PKPaymentAuthorizationController controller);
	}

	// @interface STPTelemetryClient : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripeApplePay18STPTelemetryClient")]
	[DisableDefaultCtor]
	interface STPTelemetryClient
	{
	}

	// @interface _stpinternal_ApplePayContextDidCompleteStorage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripeApplePay46_stpinternal_ApplePayContextDidCompleteStorage")]
	[DisableDefaultCtor]
	interface _stpinternal_ApplePayContextDidCompleteStorage
	{
	}

	// @interface _stpinternal_ApplePayContextDidCreatePaymentMethodStorage : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC14StripeApplePay57_stpinternal_ApplePayContextDidCreatePaymentMethodStorage")]
	[DisableDefaultCtor]
	interface _stpinternal_ApplePayContextDidCreatePaymentMethodStorage
	{
	}

	// @protocol _stpinternal_STPApplePayContextDelegateBase <NSObject>
	/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/[Protocol (Name = "_TtP14StripeApplePay43_stpinternal_STPApplePayContextDelegateBase_")]
	[BaseType (typeof(NSObject), Name = "_TtP14StripeApplePay43_stpinternal_STPApplePayContextDelegateBase_")]
	interface _stpinternal_STPApplePayContextDelegateBase
	{
		// @optional -(void)applePayContext:(_stpinternal_APContextSwift * _Nonnull)context didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod handler:(void (^ _Nonnull)(PKPaymentRequestShippingMethodUpdate * _Nonnull))handler;
		[Export ("applePayContext:didSelectShippingMethod:handler:")]
		void DidSelectShippingMethod (_stpinternal_APContextSwift context, PKShippingMethod shippingMethod, Action<PKPaymentRequestShippingMethodUpdate> handler);

		// @optional -(void)applePayContext:(_stpinternal_APContextSwift * _Nonnull)context didSelectShippingContact:(PKContact * _Nonnull)contact handler:(void (^ _Nonnull)(PKPaymentRequestShippingContactUpdate * _Nonnull))handler;
		[Export ("applePayContext:didSelectShippingContact:handler:")]
		void DidSelectShippingContact (_stpinternal_APContextSwift context, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> handler);
	}
}
