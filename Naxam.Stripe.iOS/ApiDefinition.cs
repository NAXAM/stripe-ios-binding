
using System;
using Contacts;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using PassKit;
using UIKit;
using AddressBook;

namespace StripeSdk
{
    partial interface ISTPAPIResponseDecodable { }
    partial interface ISTPFormEncodable { }
    partial interface ISTPPaymentMethod { }
    partial interface ISTPSourceProtocol { }
    partial interface ISTPBackendAPIAdapter { }
    partial interface ISTPPaymentContextDelegate { }
    partial interface ISTPEphemeralKeyProvider { }
    partial interface ISTPPaymentMethodsViewControllerDelegate { }

    // typedef void (^STPVoidBlock)(void);
    delegate void STPVoidBlock();

    // typedef void (^STPSourceProtocolCompletionBlock)(id<STPSourceProtocol> __nullable source, NSError * __nullable error);
    delegate void STPSourceProtocolCompletionBlock([NullAllowed] ISTPSourceProtocol source, [NullAllowed] NSError error);

    // typedef void (^STPErrorBlock)(NSError * _Nullable);
    delegate void STPErrorBlock([NullAllowed] NSError arg0);

    // typedef void (^STPJSONResponseCompletionBlock)(NSDictionary * __nullable jsonResponse, NSError * __nullable error);
    delegate void STPJSONResponseCompletionBlock([NullAllowed] NSDictionary jsonResponse, [NullAllowed] NSError error);
 
    // typedef void (^STPTokenCompletionBlock)(STPToken * _Nullable, NSError * _Nullable);
    delegate void STPTokenCompletionBlock([NullAllowed] STPToken arg0, [NullAllowed] NSError arg1);

    // typedef void (^STPSourceCompletionBlock)(STPSource * _Nullable, NSError * _Nullable);
    delegate void STPSourceCompletionBlock([NullAllowed] STPSource arg0, [NullAllowed] NSError arg1);

    // typedef void (^STPShippingMethodsCompletionBlock)(STPShippingStatus, NSError * _Nullable, NSArray<PKShippingMethod *> * _Nullable, PKShippingMethod * _Nullable);
    delegate void STPShippingMethodsCompletionBlock(STPShippingStatus arg0, [NullAllowed] NSError arg1, [NullAllowed] PKShippingMethod[] arg2, [NullAllowed] PKShippingMethod arg3);

    // typedef void (^STPFileCompletionBlock)(STPFile * _Nullable, NSError * _Nullable);
    delegate void STPFileCompletionBlock([NullAllowed] STPFile arg0, [NullAllowed] NSError arg1);

    // typedef void (^STPCustomerCompletionBlock)(STPCustomer * __nullable customer, NSError * __nullable error);
    delegate void STPCustomerCompletionBlock([NullAllowed] STPCustomer customer, [NullAllowed] NSError error);

    // @protocol STPAPIResponseDecodable <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPAPIResponseDecodable
    {
        //TODO static method inside protocol
        // @required +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response;
        [Abstract]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        ISTPAPIResponseDecodable DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);

        // @property (nonatomic, readonly, nonnull, copy) NSDictionary *allResponseFields;
        [Abstract]
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }
    }

    // @interface STPFile : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    interface STPFile : STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) NSString * _Nonnull fileId;
        [Export("fileId")]
        string FileId { get; }

        // @property (readonly, nonatomic) NSDate * _Nonnull created;
        [Export("created")]
        NSDate Created { get; }

        // @property (readonly, nonatomic) STPFilePurpose purpose;
        [Export("purpose")]
        STPFilePurpose Purpose { get; }

        // @property (readonly, nonatomic) NSNumber * _Nonnull size;
        [Export("size")]
        NSNumber Size { get; }

        // @property (readonly, nonatomic) NSString * _Nonnull type;
        [Export("type")]
        string Type { get; }

        // + (nullable NSString *)stringFromPurpose:(STPFilePurpose)purpose;
        [Static]
        [Export("stringFromPurpose:"), NullAllowed]
        string StringFromPurpose(STPFilePurpose purpose);
    }

    // @interface Stripe : NSObject
    [BaseType(typeof(NSObject))]
    interface Stripe
    {
        // +(NSString * _Nullable)defaultPublishableKey;
        // +(void)setDefaultPublishableKey:(NSString * _Nonnull)publishableKey;
        [Static]
        [NullAllowed, Export("defaultPublishableKey")]
        string DefaultPublishableKey { get; set; }
    }

    // @interface STPAPIClient : NSObject
    [BaseType(typeof(NSObject))]
    interface STPAPIClient
    {
        // +(instancetype _Nonnull)sharedClient;
        [Static]
        [Export("sharedClient")]
        STPAPIClient SharedClient();

        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration __attribute__((objc_designated_initializer));
        [Export("initWithConfiguration:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPPaymentConfiguration configuration);

        // -(instancetype _Nonnull)initWithPublishableKey:(NSString * _Nonnull)publishableKey;
        [Export("initWithPublishableKey:")]
        IntPtr Constructor(string publishableKey);

        // @property (copy, nonatomic) NSString * _Nullable publishableKey;
        [NullAllowed, Export("publishableKey")]
        string PublishableKey { get; set; }

        // @property (copy, nonatomic) STPPaymentConfiguration * _Nonnull configuration;
        [Export("configuration", ArgumentSemantic.Copy)]
        STPPaymentConfiguration Configuration { get; set; }

        // @property (nonatomic, copy, nullable) NSString *stripeAccount;
        [Export("stripeAccount", ArgumentSemantic.Copy)]
        string StripeAccount { get; set; }
    }

    // @interface BankAccounts (STPAPIClient)
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_BankAccounts
    {
        // -(void)createTokenWithBankAccount:(STPBankAccountParams * _Nonnull)bankAccount completion:(STPTokenCompletionBlock _Nullable)completion;
        [Export("createTokenWithBankAccount:completion:")]
        void CreateTokenWithBankAccount(STPBankAccountParams bankAccount, [NullAllowed] STPTokenCompletionBlock completion);
    }

    // typedef void (^STPPaymentIntentCompletionBlock)(STPPaymentIntent * __nullable paymentIntent, NSError * __nullable error);
    delegate void STPPaymentIntentCompletionBlock([NullAllowed]STPPaymentIntent paymentIntent, [NullAllowed]NSError error);

    // @interface PaymentIntents (STPAPIClient)
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_PaymentIntents
    {
        /**
        Retrieves the PaymentIntent object using the given secret. @see https://stripe.com/docs/api#retrieve_payment_intent

        @param secret      The client secret of the payment intent to be retrieved. Cannot be nil.
        @param completion  The callback to run with the returned PaymentIntent object, or an error.
        */
        // - (void)retrievePaymentIntentWithClientSecret:(NSString *)secret
        //                                    completion:(STPPaymentIntentCompletionBlock)completion;
        [Export("retrievePaymentIntentWithClientSecret:completion:")]
        void RetrievePaymentIntentWithClientSecret(string secret, [NullAllowed] STPPaymentIntentCompletionBlock completion);

        /**
        Confirms the PaymentIntent object with the provided params object.

        At a minimum, the params object must include the `clientSecret`.

        @see https://stripe.com/docs/api#confirm_payment_intent

        @param paymentIntentParams  The `STPPaymentIntentParams` to pass to `/confirm`
        @param completion           The callback to run with the returned PaymentIntent object, or an error.
        */
        // - (void)confirmPaymentIntentWithParams:(STPPaymentIntentParams *)paymentIntentParams
        //                             completion:(STPPaymentIntentCompletionBlock)completion;
        [Export("confirmPaymentIntentWithParams:completion:")]
        void ConfirmPaymentIntentWithParams(STPPaymentIntentParams paymentIntentParams, [NullAllowed] STPPaymentIntentCompletionBlock completion);
    }

    // @interface PII (STPAPIClient)
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_PII
    {
        // -(void)createTokenWithPersonalIDNumber:(NSString * _Nonnull)pii completion:(STPTokenCompletionBlock _Nullable)completion;
        [Export("createTokenWithPersonalIDNumber:completion:")]
        void CreateTokenWithPersonalIDNumber(string pii, [NullAllowed] STPTokenCompletionBlock completion);
    }

    /**
    Stripe extensions for working with Connect Accounts
    // @interface STPAPIClient (ConnectAccounts)
    */
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_ConnectAccounts
    {
        /**
        Converts an `STPConnectAccountParams` object into a Stripe token using the Stripe API.

        This allows the connected account to accept the Terms of Service, and/or send Legal Entity information.

        @param account The Connect Account parameters. Cannot be nil.
        @param completion The callback to run with the returned Stripe token (and any errors that may have occurred).
        // - (void)createTokenWithConnectAccount:(STPConnectAccountParams *)account completion:(__nullable STPTokenCompletionBlock)completion;
        */
        [Export("createTokenWithConnectAccount:completion:")]
        void CreateTokenWithConnectAccount(STPConnectAccountParams account, [NullAllowed] STPTokenCompletionBlock completion);
    }

    // @interface Upload (STPAPIClient)
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_Upload
    {
        // -(void)uploadImage:(UIImage * _Nonnull)image purpose:(STPFilePurpose)purpose completion:(STPFileCompletionBlock _Nullable)completion;
        [Export("uploadImage:purpose:completion:")]
        void UploadImage(UIImage image, STPFilePurpose purpose, [NullAllowed] STPFileCompletionBlock completion);
    }

    // @interface CreditCards (STPAPIClient)
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_CreditCards
    {
        // -(void)createTokenWithCard:(STPCardParams * _Nonnull)card completion:(STPTokenCompletionBlock _Nullable)completion;
        [Export("createTokenWithCard:completion:")]
        void CreateTokenWithCard(STPCardParams card, [NullAllowed] STPTokenCompletionBlock completion);
    }

    // @interface ApplePay (Stripe)
    [Category]
    [BaseType(typeof(Stripe))]
    interface Stripe_ApplePay
    {
        // + (BOOL)canSubmitPaymentRequest:(PKPaymentRequest *)paymentRequest;
        [Static, Export("canSubmitPaymentRequest:")]
        bool CanSubmitPaymentRequest(PKPaymentRequest paymentRequest);

        // +(BOOL)deviceSupportsApplePay;
        [Static]
        [Export("deviceSupportsApplePay")]
        bool DeviceSupportsApplePay { get; }

        // + (PKPaymentRequest *)paymentRequestWithMerchantIdentifier:(NSString *)merchantIdentifier __attribute__((deprecated));
        [Static, Export("paymentRequestWithMerchantIdentifier:")]
        PKPaymentRequest PaymentRequestWithMerchantIdentifier(string merchantIdentifier);

        // + (PKPaymentRequest *)paymentRequestWithMerchantIdentifier:(NSString *)merchantIdentifier country:(NSString *)countryCode currency:(NSString *)currencyCode
        [Static, Export("paymentRequestWithMerchantIdentifier:country:currency:")]
        PKPaymentRequest PaymentRequestWithMerchantIdentifier(string merchantIdentifier, string countryCode, string currentCode);
    }

    // @interface Sources (STPAPIClient)
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_Sources
    {
        // -(void)createSourceWithParams:(STPSourceParams * _Nonnull)params completion:(STPSourceCompletionBlock _Nonnull)completion;
        [Export("createSourceWithParams:completion:")]
        void CreateSourceWithParams(STPSourceParams @params, STPSourceCompletionBlock completion);

        // -(void)retrieveSourceWithId:(NSString * _Nonnull)identifier clientSecret:(NSString * _Nonnull)secret completion:(STPSourceCompletionBlock _Nonnull)completion;
        [Export("retrieveSourceWithId:clientSecret:completion:")]
        void RetrieveSourceWithId(string identifier, string secret, STPSourceCompletionBlock completion);

        // - (void)startPollingSourceWithId:(NSString *)identifier clientSecret:(NSString *)secret timeout:(NSTimeInterval)timeout completion:(STPSourceCompletionBlock)completion NS_EXTENSION_UNAVAILABLE("Source polling is not available in extensions") DEPRECATED_MSG_ATTRIBUTE("You should poll your own backend to update based on source status change webhook events it may receive.");
        [Export("startPollingSourceWithId:clientSecret:timeout:completion:"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Source polling is not available in extensions")]
        void StartPollingSourceWithId(string identifier, string secret, double timeout, STPSourceCompletionBlock completion);

        // - (void)stopPollingSourceWithId:(NSString *)identifier NS_EXTENSION_UNAVAILABLE("Source polling is not available in extensions") DEPRECATED_ATTRIBUTE;
        [Export("stopPollingSourceWithId:"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Source polling is not available in extensions")]
        void StopPollingSourceWithId(string identifier);
    }

    // @interface STPURLCallbackHandlerAdditions (Stripe)
    [Category]
    [BaseType(typeof(Stripe))]
    interface Stripe_STPURLCallbackHandlerAdditions
    {
        // +(BOOL)handleStripeURLCallbackWithURL:(NSURL * _Nonnull)url;
        [Static]
        [Export("handleStripeURLCallbackWithURL:")]
        bool HandleStripeURLCallbackWithURL(NSUrl url);
    }

    // @interface STPAddress : NSObject APIResponseDecodable>
    [BaseType(typeof(NSObject))]
    interface STPAddress : STPAPIResponseDecodable, STPFormEncodable
    {
        // @property (copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable line1;
        [NullAllowed, Export("line1")]
        string Line1 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable line2;
        [NullAllowed, Export("line2")]
        string Line2 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable city;
        [NullAllowed, Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable state;
        [NullAllowed, Export("state")]
        string State { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; set; }

        // + (nullable NSDictionary *)shippingInfoForChargeWithAddress:(nullable STPAddress *)address shippingMethod:(nullable PKShippingMethod *)method;
        [Static, Export("shippingInfoForChargeWithAddress:shippingMethod:")]
        NSDictionary ShippingInfoForChargeWithAddress(STPAddress address, [NullAllowed]PKShippingMethod method);

        // -(instancetype _Nonnull)initWithPKContact:(PKContact * _Nonnull)contact __attribute__((availability(ios, introduced=9.0)));
        [Export("initWithPKContact:")]
        IntPtr Constructor(PKContact contact);

        // -(PKContact * _Nonnull)PKContactValue __attribute__((availability(ios, introduced=9.0)));
        [Export("PKContactValue")]
        PKContact PKContactValue { get; }

        // -(instancetype _Nonnull)initWithCNContact:(CNContact * _Nonnull)contact __attribute__((availability(ios, introduced=9.0)));
        [Export("initWithCNContact:")]
        IntPtr Constructor(CNContact contact);

        // -(BOOL)containsRequiredFields:(STPBillingAddressFields)requiredFields;
        [Export("containsRequiredFields:")]
        bool ContainsRequiredFields(STPBillingAddressFields requiredFields);

        //- (BOOL)containsContentForBillingAddressFields:(STPBillingAddressFields)desiredFields;
        [Export("containsContentForBillingAddressFields:")]
        bool ContainsContentForBillingAddressFields(STPBillingAddressFields requiredFields);

        // - (BOOL)containsRequiredShippingAddressFields:(nullable NSSet<STPContactField> *)requiredFields;
        [Export("containsRequiredShippingAddressFields:")]
        bool ContainsRequiredShippingAddressFields([NullAllowed] NSSet<NSString> requiredFields);

        /**
        Checks if this STPAddress has any content (possibly invalid) in any of the
        desired shipping address fields.

        Where `containsRequiredShippingAddressFields:` validates that this STPAddress
        contains valid data in all of the required fields, this method checks for the
        existence of *any* data.

        Note: When `desiredFields == nil`, this method always returns
        NO.

        @parameter desiredFields The shipping address information the caller is interested in.
        @return YES if there is any data in this STPAddress that's relevant for those fields.

        - (BOOL)containsContentForShippingAddressFields:(nullable NSSet<STPContactField> *)desiredFields;
        */
        [Export("containsContentForShippingAddressFields:")]
        bool ContainsContentForShippingAddressFields([NullAllowed] NSSet<NSString> requiredFields);

        // +(PKAddressField)applePayAddressFieldsFromBillingAddressFields:(STPBillingAddressFields)billingAddressFields;
        [Static]
        [Export("applePayAddressFieldsFromBillingAddressFields:")]
        PKAddressField ApplePayAddressFieldsFromBillingAddressFields(STPBillingAddressFields billingAddressFields);

        /**
        Converts a set of STPContactField values into the closest equivalent
        representation of PKAddressField options

        @param contactFields Stripe contact fields values to convert.
        @return The closest representation of the contact fields as
        a PKAddressField value.

        + (PKAddressField)pkAddressFieldsFromStripeContactFields:(nullable NSSet<STPContactField> *)contactFields;
        */
        [Static]
        [Export("pkAddressFieldsFromStripeContactFields:")]
        PKAddressField PKAddressFieldsFromStripeContactFields([NullAllowed] NSSet contactFields);

        /**
        Converts a set of STPContactField values into the closest equivalent
        representation of PKContactField options

        @param contactFields Stripe contact fields values to convert.
        @return The closest representation of the contact fields as
        a PKContactField value.

        + (nullable NSSet<PKContactField> *)pkContactFieldsFromStripeContactFields:(nullable NSSet<STPContactField> *)contactFields API_AVAILABLE(ios(11.0));
        */
        [Introduced(PlatformName.iOS, 8, 0)]
        [Static]
        [Export("pkContactFieldsFromStripeContactFields:")]
        NSSet PLContactFieldsFromStripeContactFields([NullAllowed] NSSet contactFields);
    }

    // @protocol STPFormEncodable <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPFormEncodable
    {
        // @required +(NSString * _Nullable)rootObjectName;
        //TODO Static method inside protocol
        [Abstract]
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // @required +(NSDictionary * _Nonnull)propertyNamesToFormFieldNamesMapping;
        //TODO Static method inside protocol
        [Abstract]
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary PropertyNamesToFormFieldNamesMapping { get; }

        // @required @property (readwrite, copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Abstract]
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }
    }

    // @interface STPCardParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject))]
    interface STPCardParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSString * _Nullable number;
        [NullAllowed, Export("number")]
        string Number { get; set; }

        // -(NSString * _Nullable)last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (nonatomic) NSUInteger expMonth;
        [Export("expMonth")]
        nuint ExpMonth { get; set; }

        // @property (nonatomic) NSUInteger expYear;
        [Export("expYear")]
        nuint ExpYear { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable cvc;
        [NullAllowed, Export("cvc")]
        string Cvc { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) STPAddress * _Nonnull address;
        [Export("address", ArgumentSemantic.Copy)]
        STPAddress Address { get; set; }

        // @property (nonatomic, copy, nullable) NSString *addressLine1 DEPRECATED_MSG_ATTRIBUTE("Use address.line1");
        [NullAllowed, Export("addressLine1"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Use address.line1")]
        string AddressLine1 { get; set; }

        // @property (nonatomic, copy, nullable) NSString *addressLine2 DEPRECATED_MSG_ATTRIBUTE("Use address.line2");
        [NullAllowed, Export("addressLine2"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Use address.line2")]
        string AddressLine2 { get; set; }

        // @property (nonatomic, copy, nullable) NSString *addressCity DEPRECATED_MSG_ATTRIBUTE("Use address.city");
        [NullAllowed, Export("addressCity"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Use address.city")]
        string AddressCity { get; set; }

        // @property (nonatomic, copy, nullable) NSString *addressState DEPRECATED_MSG_ATTRIBUTE("Use address.state");
        [NullAllowed, Export("addressState"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Use address.state")]
        string AddressState { get; set; }

        // @property (nonatomic, copy, nullable) NSString *addressZip DEPRECATED_MSG_ATTRIBUTE("Use address.postalCode");
        [NullAllowed, Export("addressZip"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Use address.postalCode")]
        string AddressZip { get; set; }

        // @property (nonatomic, copy, nullable) NSString *addressCountry DEPRECATED_MSG_ATTRIBUTE("Use address.country");
        [NullAllowed, Export("addressCountry"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Use address.country")]
        string AddressCountry { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; set; }
    }

    // @interface STPCoreViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface STPCoreViewController
    {
        // -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nonnull)theme __attribute__((objc_designated_initializer));
        [Export("initWithTheme:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPTheme theme);

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);
    }

    // @interface STPCoreScrollViewController : STPCoreViewController
    [BaseType(typeof(STPCoreViewController))]
    interface STPCoreScrollViewController
    {
    }

    // @interface STPCoreTableViewController : STPCoreScrollViewController
    [BaseType(typeof(STPCoreScrollViewController))]
    interface STPCoreTableViewController
    {
    }

    // @protocol STPSourceProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPSourceProtocol
    {
        // @property (nonatomic, readonly) NSString *stripeID;
        [Abstract]
        [Export("stripeID")]
        string StripeID { get; }
    }

    // @interface STPCustomer : NSObject
    [BaseType(typeof(NSObject))]
    interface STPCustomer : STPAPIResponseDecodable
    {
        // +(instancetype _Nonnull)customerWithStripeID:(NSString * _Nonnull)stripeID defaultSource:(id<STPSourceProtocol> _Nullable)defaultSource sources:(NSArray<id<STPSourceProtocol>> * _Nonnull)sources __attribute__((deprecated));
        [Static]
        [Export("customerWithStripeID:defaultSource:sources:")]
        STPCustomer CustomerWithStripeID(string stripeID, [NullAllowed] ISTPSourceProtocol defaultSource, ISTPSourceProtocol[] sources);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
        [Export("stripeID")]
        string StripeID { get; }

        // @property (readonly, nonatomic) id<STPSourceProtocol> _Nullable defaultSource;
        [NullAllowed, Export("defaultSource")]
        ISTPSourceProtocol DefaultSource { get; }

        // @property (readonly, nonatomic) NSArray<id<STPSourceProtocol>> * _Nonnull sources;
        [Export("sources")]
        ISTPSourceProtocol[] Sources { get; }

        // @property (nonatomic, readonly, nullable) STPAddress *shippingAddress;
        [Export("shippingAddress"), NullAllowed]
        STPAddress ShippingAddress { get; }
    }

    // @interface STPCustomerDeserializer : NSObject
    [BaseType(typeof(NSObject))]
    interface STPCustomerDeserializer
    {
        // -(instancetype _Nonnull)initWithData:(NSData * _Nullable)data urlResponse:(NSURLResponse * _Nullable)urlResponse error:(NSError * _Nullable)error;
        [Export("initWithData:urlResponse:error:")]
        IntPtr Constructor([NullAllowed] NSData data, [NullAllowed] NSUrlResponse urlResponse, [NullAllowed] NSError error);

        // -(instancetype _Nonnull)initWithJSONResponse:(id _Nonnull)json;
        [Export("initWithJSONResponse:")]
        IntPtr Constructor(NSObject json);

        // @property (readonly, nonatomic) STPCustomer * _Nullable customer;
        [NullAllowed, Export("customer")]
        STPCustomer Customer { get; }

        // @property (readonly, nonatomic) NSError * _Nullable error;
        [NullAllowed, Export("error")]
        NSError Error { get; }
    }

    // @protocol STPBackendAPIAdapter <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPBackendAPIAdapter
    {
        //- (void)retrieveCustomer:(nullable STPCustomerCompletionBlock)completion;
        [Abstract]
        [Export("retrieveCustomer:")]
        void RetrieveCustomer(STPCustomerCompletionBlock completion);

        // @required -(void)attachSourceToCustomer:(id<STPSourceProtocol> _Nonnull)source completion:(STPErrorBlock _Nonnull)completion;
        [Abstract]
        [Export("attachSourceToCustomer:completion:")]
        void AttachSourceToCustomer(ISTPSourceProtocol source, STPErrorBlock completion);

        // @required -(void)selectDefaultCustomerSource:(id<STPSourceProtocol> _Nonnull)source completion:(STPErrorBlock _Nonnull)completion;
        [Abstract]
        [Export("selectDefaultCustomerSource:completion:")]
        void SelectDefaultCustomerSource(ISTPSourceProtocol source, STPErrorBlock completion);

        // - (void)detachSourceFromCustomer:(id<STPSourceProtocol>)source completion:(nullable STPErrorBlock)completion;
        [Export("detachSourceFromCustomer:completion:")]
        void DetachSourceFromCustomer(ISTPSourceProtocol source, STPErrorBlock completion);

        // - (void)updateCustomerWithShippingAddress:(STPAddress *)shipping completion:(nullable STPErrorBlock)completion;
        [Export("updateCustomerWithShippingAddress:completion:")]
        void UpdateCustomerWithShippingAddress(ISTPSourceProtocol source, STPErrorBlock completion);
    }

    // @protocol STPPaymentMethod <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPPaymentMethod
    {
        // @property (nonatomic, strong, readonly) UIImage *image;
        [Abstract]
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @property (nonatomic, strong, readonly) UIImage *templateImage;
        [Abstract]
        [Export("templateImage", ArgumentSemantic.Strong)]
        UIImage TemplateImage { get; }

        // @property (nonatomic, strong, readonly) NSString *label;
        [Abstract]
        [Export("label", ArgumentSemantic.Strong)]
        string Label { get; }
    }

    // @interface STPTheme : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface STPTheme : INSCopying
    {
        // +(STPTheme * _Nonnull)defaultTheme;
        [Static]
        [Export("defaultTheme")]
        STPTheme DefaultTheme { get; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified primaryBackgroundColor;
        [Export("primaryBackgroundColor", ArgumentSemantic.Copy)]
        UIColor PrimaryBackgroundColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified secondaryBackgroundColor;
        [Export("secondaryBackgroundColor", ArgumentSemantic.Copy)]
        UIColor SecondaryBackgroundColor { get; set; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tertiaryBackgroundColor;
        [Export("tertiaryBackgroundColor")]
        UIColor TertiaryBackgroundColor { get; }

        // @property (readonly, nonatomic) UIColor * _Nonnull quaternaryBackgroundColor;
        [Export("quaternaryBackgroundColor")]
        UIColor QuaternaryBackgroundColor { get; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified primaryForegroundColor;
        [Export("primaryForegroundColor", ArgumentSemantic.Copy)]
        UIColor PrimaryForegroundColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified secondaryForegroundColor;
        [Export("secondaryForegroundColor", ArgumentSemantic.Copy)]
        UIColor SecondaryForegroundColor { get; set; }

        // @property (readonly, nonatomic) UIColor * _Nonnull tertiaryForegroundColor;
        [Export("tertiaryForegroundColor")]
        UIColor TertiaryForegroundColor { get; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified accentColor;
        [Export("accentColor", ArgumentSemantic.Copy)]
        UIColor AccentColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified errorColor;
        [Export("errorColor", ArgumentSemantic.Copy)]
        UIColor ErrorColor { get; set; }

        // @property (copy, nonatomic) UIFont * _Null_unspecified font;
        [Export("font", ArgumentSemantic.Copy)]
        UIFont Font { get; set; }

        // @property (copy, nonatomic) UIFont * _Null_unspecified emphasisFont;
        [Export("emphasisFont", ArgumentSemantic.Copy)]
        UIFont EmphasisFont { get; set; }

        // @property (nonatomic) UIBarStyle barStyle;
        [Export("barStyle", ArgumentSemantic.Assign)]
        UIBarStyle BarStyle { get; set; }

        // @property (nonatomic) BOOL translucentNavigationBar;
        [Export("translucentNavigationBar")]
        bool TranslucentNavigationBar { get; set; }

        // @property (readonly, nonatomic) UIFont * _Nonnull smallFont;
        [Export("smallFont")]
        UIFont SmallFont { get; }

        // @property (readonly, nonatomic) UIFont * _Nonnull largeFont;
        [Export("largeFont")]
        UIFont LargeFont { get; }
    }

    // @interface STPPaymentConfiguration : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface STPPaymentConfiguration : INSCopying
    {
        // +(instancetype _Nonnull)sharedConfiguration;
        [Static]
        [Export("sharedConfiguration")]
        STPPaymentConfiguration SharedConfiguration();

        // @property (nonatomic, copy, readwrite) NSString *publishableKey;
        [Export("publishableKey")]
        string PublishableKey { get; set; }

        // @property (nonatomic) STPPaymentMethodType additionalPaymentMethods;
        [Export("additionalPaymentMethods", ArgumentSemantic.Assign)]
        STPPaymentMethodType AdditionalPaymentMethods { get; set; }

        // @property (nonatomic, assign, readwrite) STPBillingAddressFields requiredBillingAddressFields;
        [Export("requiredBillingAddressFields", ArgumentSemantic.Assign)]
        STPBillingAddressFields RequiredBillingAddressFields { get; set; }

        /**
        The shipping address fields the user must fill out when prompted for their
        shipping info. Set to nil if shipping address is not required.

        The default value is nil.

        @property (nonatomic, copy, nullable, readwrite) NSSet<STPContactField> *requiredShippingAddressFields;
        */
        [NullAllowed, Export("requiredShippingAddressFields", ArgumentSemantic.Assign)]
        NSSet RequiredShippingAddressFields { get; set; }

        // @property (nonatomic, assign, readwrite) BOOL verifyPrefilledShippingAddress;
        [Export("verifyPrefilledShippingAddress", ArgumentSemantic.Assign)]
        bool VerifyPrefilledShippingAddress { get; set; }

        // @property (nonatomic, assign, readwrite) STPShippingType shippingType;
        [Export("shippingType", ArgumentSemantic.Assign)]
        STPShippingType ShippingType { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull companyName;
        [Export("companyName")]
        string CompanyName { get; set; }

        // @property (nonatomic, copy, nullable, readwrite) NSString *appleMerchantIdentifier;
        [NullAllowed, Export("appleMerchantIdentifier")]
        string AppleMerchantIdentifier { get; set; }

        // @property (nonatomic, assign, readwrite) BOOL canDeletePaymentMethods;
        [Export("canDeletePaymentMethods")]
        bool CanDeletePaymentMethods { get; set; }

        /**
        If the value of this property is true, when your user adds a card in our UI,
        a card source will be created and added to their Stripe Customer. The default
        value is false.

        @see https://stripe.com/docs/sources/cards#create-source

        @property (nonatomic, assign) BOOL createCardSources;
        */
        [Export("createCardSources")]
        bool CreateCardSources { get; set; }

        /**
        In order to perform API requests on behalf of a connected account, e.g. to
        create a source on a connected account, set this property to the ID of the
        account for which this request is being made.

        @see https://stripe.com/docs/connect/authentication#authentication-via-the-stripe-account-header

        @property (nonatomic, copy, nullable) NSString *stripeAccount;
        */
        [Export("stripeAccount")]
        string StripeAccount { get; set; }
    }

    // @interface STPUserInformation : NSObject <NSCopying>
    [BaseType(typeof(NSObject))]
    interface STPUserInformation : INSCopying
    {
        // @property (copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; set; }

        // @property (nonatomic, strong) STPAddress * _Nullable billingAddress;
        [NullAllowed, Export("billingAddress", ArgumentSemantic.Strong)]
        STPAddress BillingAddress { get; set; }
    }

    // @interface STPAddCardViewController : STPCoreTableViewController
    [BaseType(typeof(STPCoreTableViewController))]
    interface STPAddCardViewController
    {
        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme;
        [Export("initWithConfiguration:theme:")]
        IntPtr Constructor(STPPaymentConfiguration configuration, STPTheme theme);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPAddCardViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak, nullable) id<STPAddCardViewControllerDelegate>delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong, nullable) STPUserInformation *prefilledInformation;
        [NullAllowed, Export("prefilledInformation", ArgumentSemantic.Strong)]
        STPUserInformation PrefilledInformation { get; set; }

        // @property (nonatomic, copy, nullable) NSString *managedAccountCurrency;
        [NullAllowed, Export("managedAccountCurrency")]
        string ManagedAccountCurrency { get; set; }

        // @property (nonatomic, strong, nullable) UIView *customFooterView;
        [NullAllowed, Export("customFooterView", ArgumentSemantic.Strong)]
        UIView CustomFooterView { get; set; }
    }

    // @protocol STPAddCardViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPAddCardViewControllerDelegate
    {
        // @required -(void)addCardViewControllerDidCancel:(STPAddCardViewController * _Nonnull)addCardViewController;
        [Abstract]
        [Export("addCardViewControllerDidCancel:")]
        void DidCancel(STPAddCardViewController addCardViewController);

        // @required -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreateToken:(STPToken * _Nonnull)token completion:(STPErrorBlock _Nonnull)completion;
        [Export("addCardViewController:didCreateToken:completion:")]
        void DidCreateToken(STPAddCardViewController addCardViewController, STPToken token, STPErrorBlock completion);

        /**
        This is called when the user successfully adds a card and Stripe returns a
        card source.

        Note: If `createsCardSource` is false, this method will not be called;
        `addCardViewController:didCreateToken:` will be called instead.

        You should send the source to your backend to store it on a customer, and then
        call the provided `completion` block when that call is finished. If an error
        occurs while talking to your backend, call `completion(error)`, otherwise,
        dismiss (or pop) the view controller.

        @param addCardViewController the view controller that successfully created a token
        @param source                the Stripe source that was created. @see STPSource
        @param completion            call this callback when you're done sending the token to your backend

        - (void)addCardViewController:(STPAddCardViewController *)addCardViewController
                    didCreateSource:(STPSource *)source
                        completion:(STPErrorBlock)completion;
        */
        [Export("addCardViewController:didCreateSource:completion:")]
        void DidCreateSource(STPAddCardViewController addCardViewController, STPSource token, STPErrorBlock completion);
    }

    // @interface ApplePay (STPAPIClient)
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_ApplePay
    {
        // -(void)createTokenWithPayment:(PKPayment * _Nonnull)payment completion:(STPTokenCompletionBlock _Nonnull)completion __attribute__((availability(ios, introduced=8.0)));
        [Introduced(PlatformName.iOS, 8, 0)]
        [Export("createTokenWithPayment:completion:")]
        void CreateTokenWithPayment(PKPayment payment, STPTokenCompletionBlock completion);

        // - (void)createSourceWithPayment:(nonnull PKPayment *)payment completion:(nonnull STPSourceCompletionBlock)completion;
        [Export("createSourceWithPayment:completion:")]
        void CreateSourceWithPayment(PKPayment payment, STPSourceCompletionBlock completion);
    }

    // @interface STPApplePayPaymentMethod : NSObject <STPPaymentMethod>
    [BaseType(typeof(NSObject))]
    interface STPApplePayPaymentMethod : STPPaymentMethod
    {
    }

    // @interface STPBankAccountParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject))]
    interface STPBankAccountParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSString * _Nullable accountNumber;
        [NullAllowed, Export("accountNumber")]
        string AccountNumber { get; set; }

        // @property (nonatomic, nullable, readonly) NSString *last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (copy, nonatomic) NSString * _Nullable routingNumber;
        [NullAllowed, Export("routingNumber")]
        string RoutingNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; set; }

        // @property (nonatomic, copy, nullable) NSString *accountHolderName;
        [NullAllowed, Export("accountHolderName")]
        string AccountHolderName { get; set; }

        // @property (nonatomic, assign) STPBankAccountHolderType accountHolderType;
        [Export("accountHolderType", ArgumentSemantic.Assign)]
        STPBankAccountHolderType AccountHolderType { get; set; }
    }

    // @interface STPBankAccount : NSObject<STPAPIResponseDecodable, STPSourceProtocol>
    [BaseType(typeof(NSObject)), DisableDefaultCtor]
    interface STPBankAccount : ISTPAPIResponseDecodable, ISTPSourceProtocol
    {
        // @property (nonatomic, nullable, readonly) NSString *routingNumber;
        [Export("routingNumber", ArgumentSemantic.Copy)]
        string RoutingNumber { get; }

        // @property (nonatomic, readonly) NSString *country;
        [Export("country", ArgumentSemantic.Copy)]
        string Country { get; }

        // @property (nonatomic, readonly) NSString *currency;
        [Export("currency", ArgumentSemantic.Copy)]
        string Currency { get; }

        // @property (nonatomic, readonly) NSString *bankAccountId DEPRECATED_MSG_ATTRIBUTE("Use stripeID (defined in STPSourceProtocol)");
        [Export("bankAccountId"), Deprecated(PlatformName.None, PlatformArchitecture.All, "Use stripeID (defined in STPSourceProtocol)")]
        string BankAccountId { get; }

        // @property (nonatomic, readonly) NSString *last4;
        [Export("last4")]
        string Last4 { get; }

        // @property (nonatomic, readonly) NSString *bankName;
        [Export("bankName")]
        string BankName { get; }

        // @property (nonatomic, nullable, readonly) NSString *accountHolderName;
        [NullAllowed, Export("accountHolderName")]
        string AccountHolderName { get; }

        // @property (nonatomic, readonly) STPBankAccountHolderType accountHolderType;
        [Export("accountHolderType", ArgumentSemantic.Assign)]
        STPBankAccountHolderType AccountHolderType { get; }

        // @property (nonatomic, nullable, readonly) NSString *fingerprint;
        [NullAllowed, Export("fingerprint")]
        string Fingerprint { get; }

        // @property (nonatomic, readonly) STPBankAccountStatus status;
        [Export("status")]
        STPBankAccountStatus Status { get; }

        // @property (nonatomic, copy, nullable, readonly) NSDictionary<NSString *, NSString *> *metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; }
    }

    // @interface STPCard : NSObject<STPAPIResponseDecodable, STPPaymentMethod, STPSourceProtocol>
    [BaseType(typeof(NSObject))]
    interface STPCard : ISTPAPIResponseDecodable, ISTPPaymentMethod, ISTPSourceProtocol
    {
        // -(instancetype _Nonnull)initWithID:(NSString * _Nonnull)cardID brand:(STPCardBrand)brand last4:(NSString * _Nonnull)last4 expMonth:(NSUInteger)expMonth expYear:(NSUInteger)expYear funding:(STPCardFundingType)funding;
        [Export("initWithID:brand:last4:expMonth:expYear:funding:")]
        IntPtr Constructor(string cardID, STPCardBrand brand, string last4, nuint expMonth, nuint expYear, STPCardFundingType funding);

        // +(STPCardBrand)brandFromString:(NSString * _Nonnull)string;
        [Static]
        [Export("brandFromString:")]
        STPCardBrand BrandFromString(string @string);

        // +(NSString * _Nonnull)stringFromBrand:(STPCardBrand)brand;
        [Static]
        [Export("stringFromBrand:")]
        string StringFromBrand(STPCardBrand brand);

        // +(STPCardFundingType)fundingFromString:(NSString * _Nonnull)string;
        [Static]
        [Export("fundingFromString:")]
        STPCardFundingType FundingFromString(string @string);

        // @property (readonly, nonatomic) NSString * _Nonnull last4;
        [Export("last4")]
        string Last4 { get; }

        // @property (readonly, nonatomic) NSString * _Nullable dynamicLast4;
        [NullAllowed, Export("dynamicLast4")]
        string DynamicLast4 { get; }

        // @property (readonly, nonatomic) BOOL isApplePayCard;
        [Export("isApplePayCard")]
        bool IsApplePayCard { get; }

        // @property (nonatomic) NSUInteger expMonth;
        [Export("expMonth")]
        nuint ExpMonth { get; set; }

        // @property (nonatomic) NSUInteger expYear;
        [Export("expYear")]
        nuint ExpYear { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) STPAddress * _Nullable address;
        [NullAllowed, Export("address", ArgumentSemantic.Copy)]
        STPAddress Address { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable addressLine1;
        [NullAllowed, Export("addressLine1")]
        string AddressLine1 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable addressLine2;
        [NullAllowed, Export("addressLine2")]
        string AddressLine2 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable addressCity;
        [NullAllowed, Export("addressCity")]
        string AddressCity { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable addressState;
        [NullAllowed, Export("addressState")]
        string AddressState { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable addressZip;
        [NullAllowed, Export("addressZip")]
        string AddressZip { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable addressCountry;
        [NullAllowed, Export("addressCountry")]
        string AddressCountry { get; set; }

        // @property (readonly, nonatomic) NSString * _Nullable cardId;
        [NullAllowed, Export("cardId")]
        string CardId { get; }

        // @property (readonly, nonatomic) STPCardBrand brand;
        [Export("brand")]
        STPCardBrand Brand { get; }

        // @property (readonly, nonatomic) STPCardFundingType funding;
        [Export("funding")]
        STPCardFundingType Funding { get; }

        // @property (readonly, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; set; }

        // @property (nonatomic, copy, nullable, readonly) NSDictionary<NSString *, NSString *> *metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; }
    }

    // @interface STPCardValidator : NSObject
    [BaseType(typeof(NSObject))]
    interface STPCardValidator
    {
        // +(NSString * _Nonnull)sanitizedNumericStringForString:(NSString * _Nonnull)string;
        [Static]
        [Export("sanitizedNumericStringForString:")]
        string SanitizedNumericStringForString(string @string);

        // +(BOOL)stringIsNumeric:(NSString * _Nonnull)string;
        [Static]
        [Export("stringIsNumeric:")]
        bool StringIsNumeric(string @string);

        // +(STPCardValidationState)validationStateForNumber:(NSString * _Nullable)cardNumber validatingCardBrand:(BOOL)validatingCardBrand;
        [Static]
        [Export("validationStateForNumber:validatingCardBrand:")]
        STPCardValidationState ValidationStateForNumber([NullAllowed] string cardNumber, bool validatingCardBrand);

        // +(STPCardBrand)brandForNumber:(NSString * _Nonnull)cardNumber;
        [Static]
        [Export("brandForNumber:")]
        STPCardBrand BrandForNumber(string cardNumber);

        // +(NSSet<NSNumber *> * _Nonnull)lengthsForCardBrand:(STPCardBrand)brand;
        [Static]
        [Export("lengthsForCardBrand:")]
        NSSet<NSNumber> LengthsForCardBrand(STPCardBrand brand);

        // +(NSInteger)maxLengthForCardBrand:(STPCardBrand)brand;
        [Static]
        [Export("maxLengthForCardBrand:")]
        nint MaxLengthForCardBrand(STPCardBrand brand);

        // +(NSInteger)fragmentLengthForCardBrand:(STPCardBrand)brand;
        [Static]
        [Export("fragmentLengthForCardBrand:")]
        nint FragmentLengthForCardBrand(STPCardBrand brand);

        // +(STPCardValidationState)validationStateForExpirationMonth:(NSString * _Nonnull)expirationMonth;
        [Static]
        [Export("validationStateForExpirationMonth:")]
        STPCardValidationState ValidationStateForExpirationMonth(string expirationMonth);

        // +(STPCardValidationState)validationStateForExpirationYear:(NSString * _Nonnull)expirationYear inMonth:(NSString * _Nonnull)expirationMonth;
        [Static]
        [Export("validationStateForExpirationYear:inMonth:")]
        STPCardValidationState ValidationStateForExpirationYear(string expirationYear, string expirationMonth);

        // +(NSUInteger)maxCVCLengthForCardBrand:(STPCardBrand)brand;
        [Static]
        [Export("maxCVCLengthForCardBrand:")]
        nuint MaxCVCLengthForCardBrand(STPCardBrand brand);

        // +(STPCardValidationState)validationStateForCVC:(NSString * _Nonnull)cvc cardBrand:(STPCardBrand)brand;
        [Static]
        [Export("validationStateForCVC:cardBrand:")]
        STPCardValidationState ValidationStateForCVC(string cvc, STPCardBrand brand);

        // +(STPCardValidationState)validationStateForCard:(STPCardParams * _Nonnull)card;
        [Static]
        [Export("validationStateForCard:")]
        STPCardValidationState ValidationStateForCard(STPCardParams card);

        // +(STPCardValidationState)validationStateForExpirationYear:(NSString * _Nonnull)expirationYear inMonth:(NSString * _Nonnull)expirationMonth inCurrentYear:(NSInteger)currentYear currentMonth:(NSInteger)currentMonth;
        [Static]
        [Export("validationStateForExpirationYear:inMonth:inCurrentYear:currentMonth:")]
        STPCardValidationState ValidationStateForExpirationYear(string expirationYear, string expirationMonth, nint currentYear, nint currentMonth);

        // +(STPCardValidationState)validationStateForCard:(STPCardParams * _Nonnull)card inCurrentYear:(NSInteger)currentYear currentMonth:(NSInteger)currentMonth;
        [Static]
        [Export("validationStateForCard:inCurrentYear:currentMonth:")]
        STPCardValidationState ValidationStateForCard(STPCardParams card, nint currentYear, nint currentMonth);
    }

    // @interface STPImageLibrary : NSObject
    [BaseType(typeof(NSObject))]
    interface STPImageLibrary
    {
        // +(UIImage * _Nonnull)applePayCardImage;
        [Static]
        [Export("applePayCardImage")]
        UIImage ApplePayCardImage { get; }

        // +(UIImage * _Nonnull)amexCardImage;
        [Static]
        [Export("amexCardImage")]
        UIImage AmexCardImage { get; }

        // +(UIImage * _Nonnull)dinersClubCardImage;
        [Static]
        [Export("dinersClubCardImage")]
        UIImage DinersClubCardImage { get; }

        // +(UIImage * _Nonnull)discoverCardImage;
        [Static]
        [Export("discoverCardImage")]
        UIImage DiscoverCardImage { get; }

        // +(UIImage * _Nonnull)jcbCardImage;
        [Static]
        [Export("jcbCardImage")]
        UIImage JcbCardImage { get; }

        // +(UIImage * _Nonnull)masterCardCardImage;
        [Static]
        [Export("masterCardCardImage")]
        UIImage MasterCardCardImage { get; }

        // +(UIImage * _Nonnull)visaCardImage;
        [Static]
        [Export("visaCardImage")]
        UIImage VisaCardImage { get; }

        // +(UIImage * _Nonnull)unknownCardCardImage;
        [Static]
        [Export("unknownCardCardImage")]
        UIImage UnknownCardCardImage { get; }

        // +(UIImage * _Nonnull)brandImageForCardBrand:(STPCardBrand)brand;
        [Static]
        [Export("brandImageForCardBrand:")]
        UIImage BrandImageForCardBrand(STPCardBrand brand);

        // +(UIImage * _Nonnull)templatedBrandImageForCardBrand:(STPCardBrand)brand;
        [Static]
        [Export("templatedBrandImageForCardBrand:")]
        UIImage TemplatedBrandImageForCardBrand(STPCardBrand brand);

        // +(UIImage * _Nonnull)cvcImageForCardBrand:(STPCardBrand)brand;
        [Static]
        [Export("cvcImageForCardBrand:")]
        UIImage CvcImageForCardBrand(STPCardBrand brand);

        // +(UIImage * _Nonnull)errorImageForCardBrand:(STPCardBrand)brand;
        [Static]
        [Export("errorImageForCardBrand:")]
        UIImage ErrorImageForCardBrand(STPCardBrand brand);

        /**
        An icon representing UnionPay.

        + (UIImage *)unionPayCardImage;
        */
        [Static]
        [Export("unionPayCardImage")]
        UIImage UnionPayCardImage();
    }

    // @interface STPPaymentActivityIndicatorView : UIView
    [BaseType(typeof(UIView))]
    interface STPPaymentActivityIndicatorView
    {
        // -(void)setAnimating:(BOOL)animating animated:(BOOL)animated;
        [Export("setAnimating:animated:")]
        void SetAnimating(bool animating, bool animated);

        // @property (nonatomic) BOOL animating;
        [Export("animating")]
        bool Animating { get; set; }

        // @property (nonatomic) BOOL hidesWhenStopped;
        [Export("hidesWhenStopped")]
        bool HidesWhenStopped { get; set; }
    }

    // @protocol STPPaymentCardTextFieldDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPPaymentCardTextFieldDelegate
    {
        // @optional -(void)paymentCardTextFieldDidChange:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidChange:")]
        void PaymentCardTextFieldDidChange(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidBeginEditingNumber:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidBeginEditingNumber:")]
        void PaymentCardTextFieldDidBeginEditingNumber(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidEndEditingNumber:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidEndEditingNumber:")]
        void PaymentCardTextFieldDidEndEditingNumber(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidBeginEditingCVC:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidBeginEditingCVC:")]
        void PaymentCardTextFieldDidBeginEditingCVC(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidEndEditingCVC:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidEndEditingCVC:")]
        void PaymentCardTextFieldDidEndEditingCVC(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidBeginEditingExpiration:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidBeginEditingExpiration:")]
        void PaymentCardTextFieldDidBeginEditingExpiration(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidEndEditingExpiration:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidEndEditingExpiration:")]
        void PaymentCardTextFieldDidEndEditingExpiration(STPPaymentCardTextField textField);
    }

    // @interface STPPaymentCardTextField : UIControl <UIKeyInput>
    [BaseType(typeof(UIControl))]
    interface STPPaymentCardTextField : IUIKeyInput
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPPaymentCardTextFieldDelegate Delegate { get; set; }

        // @property (nonatomic, weak, nullable) IBOutlet id<STPPaymentCardTextFieldDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, copy, null_resettable) UIFont *font UI_APPEARANCE_SELECTOR;
        [Export("font", ArgumentSemantic.Copy),]
        UIFont Font { get; set; }

        // @property (nonatomic, copy, null_resettable) UIColor *textColor UI_APPEARANCE_SELECTOR;
        [Export("textColor", ArgumentSemantic.Copy)]
        UIColor TextColor { get; set; }

        // @property (nonatomic, copy, null_resettable) UIColor *textErrorColor UI_APPEARANCE_SELECTOR;
        [Export("textErrorColor", ArgumentSemantic.Copy)]
        UIColor TextErrorColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified placeholderColor __attribute__((annotate("ui_appearance_selector")));
        [Export("placeholderColor", ArgumentSemantic.Copy)]
        UIColor PlaceholderColor { get; set; }

        // @property (nonatomic, copy, nullable) IBInspectable NSString *numberPlaceholder;
        [NullAllowed, Export("numberPlaceholder", ArgumentSemantic.Copy)]
        string NumberPlaceholder { get; set; }

        // @property (nonatomic, copy, nullable) IBInspectable NSString *expirationPlaceholder;
        [NullAllowed, Export("expirationPlaceholder", ArgumentSemantic.Copy)]
        string ExpirationPlaceholder { get; set; }

        // @property (nonatomic, copy, nullable) IBInspectable NSString *cvcPlaceholder;
        [NullAllowed, Export("cvcPlaceholder", ArgumentSemantic.Copy)]
        string CvcPlaceholder { get; set; }

        // @property (nonatomic, copy, nullable) IBInspectable NSString *postalCodePlaceholder;
        [NullAllowed, Export("postalCodePlaceholder", ArgumentSemantic.Copy)]
        string PostalCodePlaceholder { get; set; }

        // @property (nonatomic, copy, null_resettable) UIColor *cursorColor UI_APPEARANCE_SELECTOR;
        [Export("cursorColor", ArgumentSemantic.Copy)]
        UIColor CursorColor { get; set; }

        // @property (nonatomic, copy, nullable) UIColor *borderColor UI_APPEARANCE_SELECTOR;
        [NullAllowed, Export("borderColor", ArgumentSemantic.Copy)]
        UIColor BorderColor { get; set; }

        // @property (nonatomic, assign) CGFloat borderWidth UI_APPEARANCE_SELECTOR;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (nonatomic, assign) CGFloat cornerRadius UI_APPEARANCE_SELECTOR;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic, assign) UIKeyboardAppearance keyboardAppearance UI_APPEARANCE_SELECTOR;
        [Export("keyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance KeyboardAppearance { get; set; }

        // @property (nonatomic, strong, nullable) UIView *inputView;
        [NullAllowed, Export("inputView", ArgumentSemantic.Strong)]
        UIView InputView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable inputAccessoryView;
        [NullAllowed, Export("inputAccessoryView", ArgumentSemantic.Strong)]
        UIView InputAccessoryView { get; set; }

        // @property (nonatomic, nullable, readonly) UIImage *brandImage;
        [NullAllowed, Export("brandImage")]
        UIImage BrandImage { get; }

        // -(BOOL)becomeFirstResponder;
        [Export("becomeFirstResponder")]
        bool BecomeFirstResponder();

        // -(BOOL)resignFirstResponder;
        [Export("resignFirstResponder")]
        bool ResignFirstResponder();

        // -(void)clear;
        [Export("clear")]
        void Clear();

        // +(UIImage * _Nullable)cvcImageForCardBrand:(STPCardBrand)cardBrand;
        [Static]
        [Export("cvcImageForCardBrand:")]
        [return: NullAllowed]
        UIImage CvcImageForCardBrand(STPCardBrand cardBrand);

        // +(UIImage * _Nullable)brandImageForCardBrand:(STPCardBrand)cardBrand;
        [Static]
        [Export("brandImageForCardBrand:")]
        [return: NullAllowed]
        UIImage BrandImageForCardBrand(STPCardBrand cardBrand);

        // +(UIImage * _Nullable)errorImageForCardBrand:(STPCardBrand)cardBrand;
        [Static]
        [Export("errorImageForCardBrand:")]
        [return: NullAllowed]
        UIImage ErrorImageForCardBrand(STPCardBrand cardBrand);

        // -(CGRect)brandImageRectForBounds:(CGRect)bounds;
        [Export("brandImageRectForBounds:")]
        CGRect BrandImageRectForBounds(CGRect bounds);

        // -(CGRect)fieldsRectForBounds:(CGRect)bounds;
        [Export("fieldsRectForBounds:")]
        CGRect FieldsRectForBounds(CGRect bounds);

        // -(CGRect)numberFieldRectForBounds:(CGRect)bounds;
        [Export("numberFieldRectForBounds:")]
        CGRect NumberFieldRectForBounds(CGRect bounds);

        // -(CGRect)cvcFieldRectForBounds:(CGRect)bounds;
        [Export("cvcFieldRectForBounds:")]
        CGRect CvcFieldRectForBounds(CGRect bounds);

        // -(CGRect)expirationFieldRectForBounds:(CGRect)bounds;
        [Export("expirationFieldRectForBounds:")]
        CGRect ExpirationFieldRectForBounds(CGRect bounds);

        // @property (readonly, nonatomic) BOOL isValid;
        [Export("isValid")]
        bool IsValid { get; }

        // @property (readonly, nonatomic) BOOL valid;
        [Export("valid")]
        bool Valid { get; }

        // @property (getter = isEnabled, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (readonly, nonatomic) NSString * _Nullable cardNumber;
        [NullAllowed, Export("cardNumber")]
        string CardNumber { get; }

        // @property (readonly, nonatomic) NSUInteger expirationMonth;
        [Export("expirationMonth")]
        nuint ExpirationMonth { get; }

        // @property (nonatomic, readonly, nullable) NSString *formattedExpirationMonth;
        [NullAllowed, Export("formattedExpirationMonth")]
        string FormattedExpirationMonth { get; }

        // @property (readonly, nonatomic) NSUInteger expirationYear;
        [Export("expirationYear")]
        nuint ExpirationYear { get; }

        // @property (readonly, nonatomic) NSString * _Nullable formattedExpirationYear;
        [NullAllowed, Export("formattedExpirationYear")]
        string FormattedExpirationYear { get; }

        // @property (readonly, nonatomic) NSString * _Nullable cvc;
        [NullAllowed, Export("cvc")]
        string Cvc { get; }

        // @property (readwrite, nonatomic, strong) STPCardParams * _Nonnull cardParams;
        [Export("cardParams", ArgumentSemantic.Strong)]
        STPCardParams CardParams { get; set; }
    }

    // @interface STPPaymentResult : NSObject
    [BaseType(typeof(NSObject))]
    interface STPPaymentResult
    {
        // @property (readonly, nonatomic) id<STPSourceProtocol> _Nonnull source;
        [Export("source")]
        ISTPSourceProtocol Source { get; }

        // -(instancetype _Nonnull)initWithSource:(id<STPSourceProtocol> _Nonnull)source;
        [Export("initWithSource:")]
        IntPtr Constructor(ISTPSourceProtocol source);
    }

    // @interface STPPaymentContext : NSObject
    [BaseType(typeof(NSObject))]
    interface STPPaymentContext
    {
        // - (instancetype)initWithCustomerContext:(STPCustomerContext *)customerContext;
        [Export("initWithCustomerContext:")]
        IntPtr Constructor(STPCustomerContext customerContext);

        // - (instancetype)initWithCustomerContext:(STPCustomerContext *)customerContext configuration:(STPPaymentConfiguration *)configuration theme:(STPTheme *)theme;;
        [Export("initWithCustomerContext:configuration:theme:")]
        IntPtr Constructor(STPCustomerContext customerContext, STPPaymentConfiguration configuration, STPTheme theme);

        // -(instancetype _Nonnull)initWithAPIAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter;
        [Export("initWithAPIAdapter:")]
        IntPtr Constructor(ISTPBackendAPIAdapter apiAdapter);

        // -(instancetype _Nonnull)initWithAPIAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter configuration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme;
        [Export("initWithAPIAdapter:configuration:theme:")]
        IntPtr Constructor(ISTPBackendAPIAdapter apiAdapter, STPPaymentConfiguration configuration, STPTheme theme);

        // @property (readonly, nonatomic) id<STPBackendAPIAdapter> _Nonnull apiAdapter;
        [Export("apiAdapter")]
        ISTPBackendAPIAdapter ApiAdapter { get; }

        // @property (readonly, nonatomic) STPPaymentConfiguration * _Nonnull configuration;
        [Export("configuration")]
        STPPaymentConfiguration Configuration { get; }

        // @property (readonly, nonatomic) STPTheme * _Nonnull theme;
        [Export("theme")]
        STPTheme Theme { get; }

        // @property (nonatomic, strong) STPUserInformation * _Nullable prefilledInformation;
        [NullAllowed, Export("prefilledInformation", ArgumentSemantic.Strong)]
        STPUserInformation PrefilledInformation { get; set; }

        // @property (nonatomic, weak) UIViewController * _Nullable hostViewController;
        [NullAllowed, Export("hostViewController", ArgumentSemantic.Weak)]
        UIViewController HostViewController { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPPaymentContextDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<STPPaymentContextDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) BOOL loading;
        [Export("loading")]
        bool Loading { get; }

        // @property (readonly, nonatomic) id<STPPaymentMethod> _Nullable selectedPaymentMethod;
        [NullAllowed, Export("selectedPaymentMethod")]
        ISTPPaymentMethod SelectedPaymentMethod { get; }

        // @property (readonly, nonatomic) NSArray<id<STPPaymentMethod>> * _Nullable paymentMethods;
        [NullAllowed, Export("paymentMethods")]
        ISTPPaymentMethod[] PaymentMethods { get; }

        // @property (readonly, nonatomic) PKShippingMethod * _Nullable selectedShippingMethod;
        [NullAllowed, Export("selectedShippingMethod")]
        PKShippingMethod SelectedShippingMethod { get; }

        // @property (readonly, nonatomic) NSArray<PKShippingMethod *> * _Nullable shippingMethods;
        [NullAllowed, Export("shippingMethods")]
        PKShippingMethod[] ShippingMethods { get; }

        // @property (readonly, nonatomic) STPAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress")]
        STPAddress ShippingAddress { get; }

        // @property (nonatomic) NSInteger paymentAmount;
        [Export("paymentAmount")]
        nint PaymentAmount { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull paymentCurrency;
        [Export("paymentCurrency")]
        string PaymentCurrency { get; set; }

        // @property (nonatomic, copy) NSString *paymentCountry;
        [Export("paymentCountry")]
        string PaymentCountry { get; set; }

        // @property (copy, nonatomic) NSArray<PKPaymentSummaryItem *> * _Nonnull paymentSummaryItems __attribute__((availability(ios, introduced=8.0)));
        [Introduced(PlatformName.iOS, 8, 0)]
        [Export("paymentSummaryItems", ArgumentSemantic.Copy)]
        PKPaymentSummaryItem[] PaymentSummaryItems { get; set; }

        // @property (assign, nonatomic) UIModalPresentationStyle modalPresentationStyle;
        [Export("modalPresentationStyle", ArgumentSemantic.Assign)]
        UIModalPresentationStyle ModalPresentationStyle { get; set; }

        /**
        The mode to use when displaying the title of the navigation bar in all view
        controllers presented by the context. The default value is `automatic`,
        which causes the title to use the same styling as the previously displayed
        navigation item (if the view controller is pushed onto the `hostViewController`).

        If the `prefersLargeTitles` property of the `hostViewController`'s navigation bar
        is false, this property has no effect and the navigation item's title is always
        displayed as a small title.

        If the view controller is presented modally, `automatic` and
        `never` always result in a navigation bar with a small title.

        @property (nonatomic, assign) UINavigationItemLargeTitleDisplayMode largeTitleDisplayMode NS_AVAILABLE_IOS(11_0);
        */
        [Introduced(PlatformName.iOS, 11, 0)]
        [Export("largeTitleDisplayMode", ArgumentSemantic.Assign)]
        UINavigationItemLargeTitleDisplayMode LargeTitleDisplayMode { get; set; }

        // @property (nonatomic, strong) UIView *paymentMethodsViewControllerFooterView;
        [Export("paymentMethodsViewControllerFooterView", ArgumentSemantic.Strong)]
        UIView PaymentMethodsViewControllerFooterView { get; set; }

        // @property (nonatomic, strong) UIView *addCardViewControllerFooterView;
        [Export("addCardViewControllerFooterView", ArgumentSemantic.Strong)]
        UIView AddCardViewControllerFooterView { get; set; }

        // -(void)retryLoading;
        [Export("retryLoading")]
        void RetryLoading();

        // -(void)presentPaymentMethodsViewController;
        [Export("presentPaymentMethodsViewController")]
        void PresentPaymentMethodsViewController();

        // -(void)pushPaymentMethodsViewController;
        [Export("pushPaymentMethodsViewController")]
        void PushPaymentMethodsViewController();

        // -(void)presentShippingViewController;
        [Export("presentShippingViewController")]
        void PresentShippingViewController();

        // -(void)pushShippingViewController;
        [Export("pushShippingViewController")]
        void PushShippingViewController();

        // -(void)requestPayment;
        [Export("requestPayment")]
        void RequestPayment();
    }

    // @protocol STPPaymentContextDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPPaymentContextDelegate
    {
        // @required -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didFailToLoadWithError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("paymentContext:didFailToLoadWithError:")]
        void PaymentContext(STPPaymentContext paymentContext, NSError error);

        // @required -(void)paymentContextDidChange:(STPPaymentContext * _Nonnull)paymentContext;
        [Abstract]
        [Export("paymentContextDidChange:")]
        void PaymentContextDidChange(STPPaymentContext paymentContext);

        // @required -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didCreatePaymentResult:(STPPaymentResult * _Nonnull)paymentResult completion:(STPErrorBlock _Nonnull)completion;
        [Abstract]
        [Export("paymentContext:didCreatePaymentResult:completion:")]
        void PaymentContext(STPPaymentContext paymentContext, STPPaymentResult paymentResult, STPErrorBlock completion);

        // @required -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didFinishWithStatus:(STPPaymentStatus)status error:(NSError * _Nullable)error;
        [Abstract]
        [Export("paymentContext:didFinishWithStatus:error:")]
        void PaymentContext(STPPaymentContext paymentContext, STPPaymentStatus status, [NullAllowed] NSError error);

        // @optional -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didUpdateShippingAddress:(STPAddress * _Nonnull)address completion:(STPShippingMethodsCompletionBlock _Nonnull)completion;
        [Export("paymentContext:didUpdateShippingAddress:completion:")]
        void PaymentContext(STPPaymentContext paymentContext, STPAddress address, STPShippingMethodsCompletionBlock completion);
    }

    // @interface STPPaymentMethodsViewController : STPCoreViewController
    [BaseType(typeof(STPCoreViewController))]
    interface STPPaymentMethodsViewController
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPPaymentMethodsViewControllerDelegate Delegate { get; }

        // @property (readonly, nonatomic, weak) id<STPPaymentMethodsViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; }

        // -(instancetype _Nonnull)initWithPaymentContext:(STPPaymentContext * _Nonnull)paymentContext;
        [Export("initWithPaymentContext:")]
        IntPtr Constructor(STPPaymentContext paymentContext);

        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme apiAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter delegate:(id<STPPaymentMethodsViewControllerDelegate> _Nonnull)delegate;
        [Export("initWithConfiguration:theme:apiAdapter:delegate:")]
        IntPtr Constructor(STPPaymentConfiguration configuration, STPTheme theme, ISTPBackendAPIAdapter apiAdapter, ISTPPaymentMethodsViewControllerDelegate @delegate);

        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme customerContext:(STPCustomerContext *)customerContext delegate:(id<STPPaymentMethodsViewControllerDelegate> _Nonnull)delegate;
        [Export("initWithConfiguration:theme:customerContext:delegate:")]
        IntPtr Constructor(STPPaymentConfiguration configuration, STPTheme theme, STPCustomerContext customerContext, ISTPPaymentMethodsViewControllerDelegate @delegate);

        // @property (nonatomic, strong) STPUserInformation * _Nullable prefilledInformation;
        [NullAllowed, Export("prefilledInformation", ArgumentSemantic.Strong)]
        STPUserInformation PrefilledInformation { get; set; }

        // @property (nonatomic, strong) UIView *paymentMethodsViewControllerFooterView;
        [Export("paymentMethodsViewControllerFooterView", ArgumentSemantic.Strong)]
        UIView PaymentMethodsViewControllerFooterView { get; set; }

        // @property (nonatomic, strong) UIView *addCardViewControllerFooterView;
        [Export("addCardViewControllerFooterView", ArgumentSemantic.Strong)]
        UIView AddCardViewControllerFooterView { get; set; }

        // -(void)dismissWithCompletion:(STPVoidBlock _Nullable)completion;
        [Export("dismissWithCompletion:")]
        void DismissWithCompletion([NullAllowed] STPVoidBlock completion);
    }

    // @protocol STPPaymentMethodsViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPPaymentMethodsViewControllerDelegate
    {
        // @required -(void)paymentMethodsViewController:(STPPaymentMethodsViewController * _Nonnull)paymentMethodsViewController didSelectPaymentMethod:(id<STPPaymentMethod> _Nonnull)paymentMethod;
        [Abstract]
        [Export("paymentMethodsViewController:didSelectPaymentMethod:")]
        void PaymentMethodsViewController(STPPaymentMethodsViewController paymentMethodsViewController, ISTPPaymentMethod paymentMethod);

        // @required -(void)paymentMethodsViewController:(STPPaymentMethodsViewController * _Nonnull)paymentMethodsViewController didFailToLoadWithError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("paymentMethodsViewController:didFailToLoadWithError:")]
        void PaymentMethodsViewController(STPPaymentMethodsViewController paymentMethodsViewController, NSError error);

        // @required -(void)paymentMethodsViewControllerDidFinish:(STPPaymentMethodsViewController * _Nonnull)paymentMethodsViewController;
        [Abstract]
        [Export("paymentMethodsViewControllerDidFinish:")]
        void PaymentMethodsViewControllerDidFinish(STPPaymentMethodsViewController paymentMethodsViewController);

        // @required -(void)paymentMethodsViewControllerDidCancel:(STPPaymentMethodsViewController * _Nonnull)paymentMethodsViewController;
        [Abstract]
        [Export("paymentMethodsViewControllerDidCancel:")]
        void PaymentMethodsViewControllerDidCancel(STPPaymentMethodsViewController paymentMethodsViewController);
    }

    /**
    A callback run when the context believes the redirect action has been completed.

    @param sourceID The stripe id of the source.
    @param clientSecret The client secret of the source.
    @param error An error if one occured. Note that a lack of an error does not 
    mean that the action was completed successfully, the presence of one confirms 
    that it was not. Currently the only possible error the context can know about 
    is if SFSafariViewController fails its initial load (like the user has no 
    internet connection, or servers are down).

    typedef void (^STPRedirectContextCompletionBlock)(NSString *sourceID, NSString * __nullable clientSecret, NSError * __nullable error);
    */
    delegate void STPRedirectContextCompletionBlock(string sourceID, [NullAllowed]string clientSecret, NSError error);

    // @interface STPRedirectContext : NSObject
    //[Unavailable(PlatformName.iOSAppExtension)]
    //[Unavailable(PlatformName.MacOSXAppExtension)]
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPRedirectContext
    {
        // @property (readonly, nonatomic) STPRedirectContextState state;
        [Export("state")]
        STPRedirectContextState State { get; }

        // -(instancetype _Nullable)initWithSource:(STPSource * _Nonnull)source completion:(STPRedirectContextCompletionBlock _Nonnull)completion;
        [Export("initWithSource:completion:")]
        IntPtr Constructor(STPSource source, STPRedirectContextCompletionBlock completion);

        /**
        // Initializer for context from an `STPPaymentIntent`.

        // This should be used when the `status` is `STPPaymentIntentStatusRequiresSourceAction`.
        // If the next action involves a redirect, this init method will return a non-nil object.

        // @param paymentIntent The STPPaymentIntent that needs a redirect.
        // @param completion A block to fire when the action is believed to have
        // been completed.

        // @return nil if the provided PaymentIntent does not need a redirect. Otherwise
        // a new context object.

        // @note Execution of the completion block does not necessarily mean the user
        // successfully performed the redirect action.
        // */
        // - (nullable instancetype)initWithPaymentIntent:(STPPaymentIntent *)paymentIntent
        //                                     completion:(STPRedirectContextPaymentIntentCompletionBlock)completion;
        [Export("initWithPaymentIntent:completion:")]
        IntPtr Constructor(STPPaymentIntent paymentIntent, STPRedirectContextPaymentIntentCompletionBlock completion);


        // -(void)startRedirectFlowFromViewController:(UIViewController * _Nonnull)presentingViewController;
        [Export("startRedirectFlowFromViewController:")]
        void StartRedirectFlowFromViewController(UIViewController presentingViewController);

        /**
        Starts a redirect flow by presenting an SFSafariViewController in your app
        from the passed in view controller.

        You must ensure that your app delegate listens for  the `returnURL` that you
        set on your source object, and forwards it to the Stripe SDK so that the
        context can be notified when the redirect is completed and dismiss the
        view controller. See `[Stripe handleStripeURLCallbackWithURL:]`

        The context will listen for both received URLs and app open notifications 
        and fire its completion block when either the URL is received, or the next
        time the app is foregrounded.

        @note This method does nothing if the context is not in the 
        `STPRedirectContextStateNotStarted` state.

        @param presentingViewController The view controller to present the Safari 
        view controller from.

        - (void)startSafariViewControllerRedirectFlowFromViewController:(UIViewController *)presentingViewController;
        */
        [Export("startSafariViewControllerRedirectFlowFromViewController:")]
        void StartSafariViewControllerRedirectFlowFromViewController(UIViewController presentingViewController);

        // -(void)startSafariAppRedirectFlow;
        [Export("startSafariAppRedirectFlow")]
        void StartSafariAppRedirectFlow();

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();
    }

    // @interface STPShippingAddressViewController : STPCoreTableViewController
    [BaseType(typeof(STPCoreTableViewController))]
    interface STPShippingAddressViewController
    {
        // -(instancetype _Nonnull)initWithPaymentContext:(STPPaymentContext * _Nonnull)paymentContext;
        [Export("initWithPaymentContext:")]
        IntPtr Constructor(STPPaymentContext paymentContext);

        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme currency:(NSString * _Nullable)currency shippingAddress:(STPAddress * _Nullable)shippingAddress selectedShippingMethod:(PKShippingMethod * _Nullable)selectedShippingMethod prefilledInformation:(STPUserInformation * _Nullable)prefilledInformation;
        [Export("initWithConfiguration:theme:currency:shippingAddress:selectedShippingMethod:prefilledInformation:")]
        IntPtr Constructor(STPPaymentConfiguration configuration, STPTheme theme, [NullAllowed] string currency, [NullAllowed] STPAddress shippingAddress, [NullAllowed] PKShippingMethod selectedShippingMethod, [NullAllowed] STPUserInformation prefilledInformation);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPShippingAddressViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<STPShippingAddressViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)dismissWithCompletion:(STPVoidBlock _Nullable)completion;
        [Export("dismissWithCompletion:")]
        void DismissWithCompletion([NullAllowed] STPVoidBlock completion);
    }

    // @protocol STPShippingAddressViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPShippingAddressViewControllerDelegate
    {
        // @required -(void)shippingAddressViewControllerDidCancel:(STPShippingAddressViewController * _Nonnull)addressViewController;
        [Abstract]
        [Export("shippingAddressViewControllerDidCancel:")]
        void ShippingAddressViewControllerDidCancel(STPShippingAddressViewController addressViewController);

        // @required -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didEnterAddress:(STPAddress * _Nonnull)address completion:(STPShippingMethodsCompletionBlock _Nonnull)completion;
        [Abstract]
        [Export("shippingAddressViewController:didEnterAddress:completion:")]
        void ShippingAddressViewController(STPShippingAddressViewController addressViewController, STPAddress address, STPShippingMethodsCompletionBlock completion);

        // @required -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didFinishWithAddress:(STPAddress * _Nonnull)address shippingMethod:(PKShippingMethod * _Nullable)method;
        [Abstract]
        [Export("shippingAddressViewController:didFinishWithAddress:shippingMethod:")]
        void ShippingAddressViewController(STPShippingAddressViewController addressViewController, STPAddress address, [NullAllowed] PKShippingMethod method);
    }

    // @interface STPSourceCardDetails : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPSourceCardDetails : STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, nonatomic) NSUInteger expMonth;
        [Export("expMonth")]
        nuint ExpMonth { get; }

        // @property (readonly, nonatomic) NSUInteger expYear;
        [Export("expYear")]
        nuint ExpYear { get; }

        // @property (readonly, nonatomic) STPCardBrand brand;
        [Export("brand")]
        STPCardBrand Brand { get; }

        // @property (readonly, nonatomic) STPCardFundingType funding;
        [Export("funding")]
        STPCardFundingType Funding { get; }

        // @property (readonly, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, nonatomic) STPSourceCard3DSecureStatus threeDSecure;
        [Export("threeDSecure")]
        STPSourceCard3DSecureStatus ThreeDSecure { get; }

        // @property (nonatomic, readonly) BOOL isApplePayCard;
        [Export("isApplePayCard")]
        bool IsApplePayCard { get; }
    }

    // @interface STPSourceOwner : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPSourceOwner : STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) STPAddress * _Nullable address;
        [NullAllowed, Export("address")]
        STPAddress Address { get; }

        // @property (readonly, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; }

        // @property (readonly, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; }

        // @property (readonly, nonatomic) STPAddress * _Nullable verifiedAddress;
        [NullAllowed, Export("verifiedAddress")]
        STPAddress VerifiedAddress { get; }

        // @property (readonly, nonatomic) NSString * _Nullable verifiedEmail;
        [NullAllowed, Export("verifiedEmail")]
        string VerifiedEmail { get; }

        // @property (readonly, nonatomic) NSString * _Nullable verifiedName;
        [NullAllowed, Export("verifiedName")]
        string VerifiedName { get; }

        // @property (readonly, nonatomic) NSString * _Nullable verifiedPhone;
        [NullAllowed, Export("verifiedPhone")]
        string VerifiedPhone { get; }
    }

    // @interface STPSourceReceiver : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPSourceReceiver : STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) NSString * _Nullable address;
        [NullAllowed, Export("address")]
        string Address { get; }

        // @property (readonly, nonatomic) NSNumber * _Nullable amountCharged;
        [NullAllowed, Export("amountCharged")]
        NSNumber AmountCharged { get; }

        // @property (readonly, nonatomic) NSNumber * _Nullable amountReceived;
        [NullAllowed, Export("amountReceived")]
        NSNumber AmountReceived { get; }

        // @property (readonly, nonatomic) NSNumber * _Nullable amountReturned;
        [NullAllowed, Export("amountReturned")]
        NSNumber AmountReturned { get; }
    }

    // @interface STPSourceRedirect : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPSourceRedirect : STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) NSURL * _Nullable returnURL;
        [NullAllowed, Export("returnURL")]
        NSUrl ReturnURL { get; }

        // @property (readonly, nonatomic) STPSourceRedirectStatus status;
        [Export("status")]
        STPSourceRedirectStatus Status { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable url;
        [NullAllowed, Export("url")]
        NSUrl Url { get; }
    }

    // @interface STPSourceSEPADebitDetails : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPSourceSEPADebitDetails : STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, nonatomic) NSString * _Nullable bankCode;
        [NullAllowed, Export("bankCode")]
        string BankCode { get; }

        // @property (readonly, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, nonatomic) NSString * _Nullable fingerprint;
        [NullAllowed, Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, nonatomic) NSString * _Nullable mandateReference;
        [NullAllowed, Export("mandateReference")]
        string MandateReference { get; }

        // @property (readonly, nonatomic) NSURL * _Nullable mandateURL;
        [NullAllowed, Export("mandateURL")]
        NSUrl MandateURL { get; }
    }

    // @interface STPSourceVerification : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPSourceVerification : STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) NSNumber * _Nullable attemptsRemaining;
        [NullAllowed, Export("attemptsRemaining")]
        NSNumber AttemptsRemaining { get; }

        // @property (readonly, nonatomic) STPSourceVerificationStatus status;
        [Export("status")]
        STPSourceVerificationStatus Status { get; }
    }

    // @interface STPSource : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPSource : STPAPIResponseDecodable, STPSourceProtocol
    {
        // @property (readonly, nonatomic) NSNumber * _Nullable amount;
        [NullAllowed, Export("amount")]
        NSNumber Amount { get; }

        // @property (readonly, nonatomic) NSString * _Nullable clientSecret;
        [NullAllowed, Export("clientSecret")]
        string ClientSecret { get; }

        // @property (readonly, nonatomic) NSDate * _Nullable created;
        [NullAllowed, Export("created")]
        NSDate Created { get; }

        // @property (readonly, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; }

        // @property (readonly, nonatomic) STPSourceFlow flow;
        [Export("flow")]
        STPSourceFlow Flow { get; }

        // @property (readonly, nonatomic) BOOL livemode;
        [Export("livemode")]
        bool Livemode { get; }

        // @property (readonly, nonatomic) NSDictionary * _Nullable metadata;
        [NullAllowed, Export("metadata")]
        NSDictionary Metadata { get; }

        // @property (readonly, nonatomic) STPSourceOwner * _Nullable owner;
        [NullAllowed, Export("owner")]
        STPSourceOwner Owner { get; }

        // @property (readonly, nonatomic) STPSourceReceiver * _Nullable receiver;
        [NullAllowed, Export("receiver")]
        STPSourceReceiver Receiver { get; }

        // @property (readonly, nonatomic) STPSourceRedirect * _Nullable redirect;
        [NullAllowed, Export("redirect")]
        STPSourceRedirect Redirect { get; }

        // @property (readonly, nonatomic) STPSourceStatus status;
        [Export("status")]
        STPSourceStatus Status { get; }

        // @property (readonly, nonatomic) STPSourceType type;
        [Export("type")]
        STPSourceType Type { get; }

        // @property (readonly, nonatomic) STPSourceUsage usage;
        [Export("usage")]
        STPSourceUsage Usage { get; }

        // @property (readonly, nonatomic) STPSourceVerification * _Nullable verification;
        [NullAllowed, Export("verification")]
        STPSourceVerification Verification { get; }

        // @property (readonly, nonatomic) NSDictionary * _Nullable details;
        [NullAllowed, Export("details")]
        NSDictionary Details { get; }

        // @property (readonly, nonatomic) STPSourceCardDetails * _Nullable cardDetails;
        [NullAllowed, Export("cardDetails")]
        STPSourceCardDetails CardDetails { get; }

        // @property (readonly, nonatomic) STPSourceSEPADebitDetails * _Nullable sepaDebitDetails;
        [NullAllowed, Export("sepaDebitDetails")]
        STPSourceSEPADebitDetails SepaDebitDetails { get; }
    }

    // @interface STPSourceParams : NSObject <STPFormEncodable, NSCopying>
    [BaseType(typeof(NSObject))]
    interface STPSourceParams : STPFormEncodable, INSCopying
    {
        // @property (assign, nonatomic) STPSourceType type;
        [Export("type", ArgumentSemantic.Assign)]
        STPSourceType Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull rawTypeString;
        [Export("rawTypeString")]
        string RawTypeString { get; set; }

        // @property (copy, nonatomic) NSNumber * _Nullable amount;
        [NullAllowed, Export("amount", ArgumentSemantic.Copy)]
        NSNumber Amount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; set; }

        // @property (assign, nonatomic) STPSourceFlow flow;
        [Export("flow", ArgumentSemantic.Assign)]
        STPSourceFlow Flow { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nullable metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nullable owner;
        [NullAllowed, Export("owner", ArgumentSemantic.Copy)]
        NSDictionary Owner { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nullable redirect;
        [NullAllowed, Export("redirect", ArgumentSemantic.Copy)]
        NSDictionary Redirect { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable token;
        [NullAllowed, Export("token")]
        string Token { get; set; }

        // @property (assign, nonatomic) STPSourceUsage usage;
        [Export("usage", ArgumentSemantic.Assign)]
        STPSourceUsage Usage { get; set; }

        // +(STPSourceParams * _Nonnull)bancontactParamsWithAmount:(NSUInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor;
        [Static]
        [Export("bancontactParamsWithAmount:name:returnURL:statementDescriptor:")]
        STPSourceParams BancontactParamsWithAmount(nuint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

        // +(STPSourceParams * _Nonnull)cardParamsWithCard:(STPCardParams * _Nonnull)card;
        [Static]
        [Export("cardParamsWithCard:")]
        STPSourceParams CardParamsWithCard(STPCardParams card);

        // +(STPSourceParams * _Nonnull)giropayParamsWithAmount:(NSUInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor;
        [Static]
        [Export("giropayParamsWithAmount:name:returnURL:statementDescriptor:")]
        STPSourceParams GiropayParamsWithAmount(nuint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

		// +(STPSourceParams * _Nonnull)idealParamsWithAmount:(NSUInteger)amount name:(NSString * _Nullable)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor bank:(NSString * _Nullable)bank;
        [Static]
        [Export("idealParamsWithAmount:name:returnURL:statementDescriptor:bank:")]
		STPSourceParams IdealParamsWithAmount(nuint amount, [NullAllowed] string name, string returnURL, [NullAllowed] string statementDescriptor, [NullAllowed] string bank);

        // +(STPSourceParams * _Nonnull)sepaDebitParamsWithName:(NSString * _Nonnull)name iban:(NSString * _Nonnull)iban addressLine1:(NSString * _Nullable)addressLine1 city:(NSString * _Nullable)city postalCode:(NSString * _Nullable)postalCode country:(NSString * _Nullable)country;
        [Static]
        [Export("sepaDebitParamsWithName:iban:addressLine1:city:postalCode:country:")]
        STPSourceParams SepaDebitParamsWithName(string name, string iban, [NullAllowed] string addressLine1, [NullAllowed] string city, [NullAllowed] string postalCode, [NullAllowed] string country);

        // +(STPSourceParams * _Nonnull)sofortParamsWithAmount:(NSUInteger)amount returnURL:(NSString * _Nonnull)returnURL country:(NSString * _Nonnull)country statementDescriptor:(NSString * _Nullable)statementDescriptor;
        [Static]
        [Export("sofortParamsWithAmount:returnURL:country:statementDescriptor:")]
        STPSourceParams SofortParamsWithAmount(nuint amount, string returnURL, string country, [NullAllowed] string statementDescriptor);

        // +(STPSourceParams * _Nonnull)threeDSecureParamsWithAmount:(NSUInteger)amount currency:(NSString * _Nonnull)currency returnURL:(NSString * _Nonnull)returnURL card:(NSString * _Nonnull)card;
        [Static]
        [Export("threeDSecureParamsWithAmount:currency:returnURL:card:")]
        STPSourceParams ThreeDSecureParamsWithAmount(nuint amount, string currency, string returnURL, string card);

        //+ (STPSourceParams *)alipayParamsWithAmount:(NSUInteger)amount currency:(NSString *)currency returnURL:(NSString *)returnURL;
        [Static]
        [Export("alipayParamsWithAmount:currency:returnURL:")]
        STPSourceParams alipayParamsWithAmount(nuint amount, string currency, string returnURL);

        //+ (STPSourceParams *)alipayReusableParamsWithCurrency:(NSString *)currency returnURL:(NSString *)returnURL;
        [Static]
        [Export("alipayReusableParamsWithCurrency:returnURL:")]
        STPSourceParams alipayReusableParamsWithCurrency(string currency, string returnURL);

        // + (STPSourceParams*) p24ParamsWithAmount:(NSUInteger) amount currency:(NSString*) currency email:(NSString*) email  name:(nullable NSString *)name returnURL:(NSString*) returnURL;
        [Static]
        [Export("p24ParamsWithAmount:currency:email:name:returnURL:card:")]
        STPSourceParams P24ParamsWithAmount(nuint amount, string currency, string email, string name, string returnURL, string card);

        /**
        Creates params for a card source created from Visa Checkout.

        @note Creating an STPSource with these params will give you a
        source with type == STPSourceTypeCard

        @param callId The callId property from a `VisaCheckoutResult` object.
        @return An STPSourceParams object populated with the provided values.

        + (STPSourceParams *)visaCheckoutParamsWithCallId:(NSString *)callId;
        */
        [Static]
        [Export("visaCheckoutParamsWithCallId:")]
        STPSourceParams VisaCheckoutParamsWithCallId(string callId);

        // /**
        //  Create params for an EPS source
        //  @see https://stripe.com/docs/sources/eps

        //  @param amount                  The amount to charge the customer.
        //  @param name                    The full name of the account holder.
        //  @param returnURL               The URL the customer should be redirected to
        //  after the authorization process.
        //  @param statementDescriptor     A custom statement descriptor for the
        //  payment (optional).

        //  @return An STPSourceParams object populated with the provided values.
        //  */
        // + (STPSourceParams *)epsParamsWithAmount:(NSUInteger)amount
        //                                     name:(NSString *)name
        //                                returnURL:(NSString *)returnURL
        //                      statementDescriptor:(nullable NSString *)statementDescriptor;
        [Static]
        [Export("epsParamsWithAmount:name:returnURL:statementDescriptor:")]
        STPSourceParams EpsParamsWithAmount(uint amount, string name, string returnUrl, string statementDescriptor);

        // /**
        //  Create params for a Multibanco source
        //  @see https://stripe.com/docs/sources/multibanco

        //  @param amount      The amount to charge the customer.
        //  @param returnURL   The URL the customer should be redirected to after the
        //  authorization process.
        //  @param email       The full email address of the customer.

        //  @return An STPSourceParams object populated with the provided values.
        //  */
        // + (STPSourceParams *)multibancoParamsWithAmount:(NSUInteger)amount
        //                                       returnURL:(NSString *)returnURL
        //                                           email:(NSString *)email;
        [Static]
        [Export("multibancoParamsWithAmount:returnURL:email:")]
        STPSourceParams MultibancoParamsWithAmount(string callId, string returnURL, string email);


    }

    // @interface STPToken : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPToken : STPAPIResponseDecodable, STPSourceProtocol
    {
        // @property (readonly, nonatomic) NSString * _Nonnull tokenId;
        [Export("tokenId")]
        string TokenId { get; }

        // @property (readonly, nonatomic) BOOL livemode;
        [Export("livemode")]
        bool Livemode { get; }

        // @property (readonly, nonatomic) STPCard * _Nullable card;
        [NullAllowed, Export("card")]
        STPCard Card { get; }

        // @property (readonly, nonatomic) STPBankAccount * _Nullable bankAccount;
        [NullAllowed, Export("bankAccount")]
        STPBankAccount BankAccount { get; }

        // @property (readonly, nonatomic) NSDate * _Nullable created;
        [NullAllowed, Export("created")]
        NSDate Created { get; }
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const _Nonnull StripeDomain;
        [Field("StripeDomain", "__Internal")]
        NSString StripeDomain { get; }
    }

    [Static]
    partial interface STPContactField
    {
        /**
        Constants that represent different parts of a users contact/address information.

        typedef NSString * STPContactField NS_STRING_ENUM;
        */

        /**
        The contact's full physical address.

        extern STPContactField const STPContactFieldPostalAddress;
        */
        [Field("STPContactFieldPostalAddress", "__Internal")]
        NSString PostalAddress { get; }

        /**
        The contact's email address.

        extern STPContactField const STPContactFieldEmailAddress;
        */
        [Field("STPContactFieldEmailAddress", "__Internal")]
        NSString EmailAddress { get; }

        /**
        The contact's phone number.

        extern STPContactField const STPContactFieldPhoneNumber;
        */
        [Field("STPContactFieldPhoneNumber", "__Internal")]
        NSString PhoneNumber { get; }

        /**
        The contact's name.

        extern STPContactField const STPContactFieldName;
        */
        [Field("STPContactFieldName", "__Internal")]
        NSString Name { get; }
    }

    [Static]
    partial interface STPErrorConstants
    {
        // extern NSString *const _Nonnull STPErrorMessageKey;
        [Field("STPErrorMessageKey", "__Internal")]
        NSString STPErrorMessageKey { get; }

        // extern NSString *const _Nonnull STPCardErrorCodeKey;
        [Field("STPCardErrorCodeKey", "__Internal")]
        NSString STPCardErrorCodeKey { get; }

        // extern NSString *const _Nonnull STPErrorParameterKey;
        [Field("STPErrorParameterKey", "__Internal")]
        NSString STPErrorParameterKey { get; }

        // extern NSString *const _Nonnull STPStripeErrorCodeKey;
        [Field("STPStripeErrorCodeKey", "__Internal")]
        NSString STPStripeErrorCodeKey { get; }

        // extern NSString *const _Nonnull STPStripeErrorTypeKey;
        [Field("STPStripeErrorTypeKey", "__Internal")]
        NSString STPStripeErrorTypeKey { get; }

        // extern STPCardErrorCode  _Nonnull const STPInvalidNumber;
        [Field("STPInvalidNumber", "__Internal")]
        NSString STPInvalidNumber { get; }

        // extern STPCardErrorCode  _Nonnull const STPInvalidExpMonth;
        [Field("STPInvalidExpMonth", "__Internal")]
        NSString STPInvalidExpMonth { get; }

        // extern STPCardErrorCode  _Nonnull const STPInvalidExpYear;
        [Field("STPInvalidExpYear", "__Internal")]
        NSString STPInvalidExpYear { get; }

        // extern STPCardErrorCode  _Nonnull const STPInvalidCVC;
        [Field("STPInvalidCVC", "__Internal")]
        NSString STPInvalidCVC { get; }

        // extern STPCardErrorCode  _Nonnull const STPIncorrectNumber;
        [Field("STPIncorrectNumber", "__Internal")]
        NSString STPIncorrectNumber { get; }

        // extern STPCardErrorCode  _Nonnull const STPExpiredCard;
        [Field("STPExpiredCard", "__Internal")]
        NSString STPExpiredCard { get; }

        // extern STPCardErrorCode  _Nonnull const STPCardDeclined;
        [Field("STPCardDeclined", "__Internal")]
        NSString STPCardDeclined { get; }

        // extern STPCardErrorCode  _Nonnull const STPProcessingError;
        [Field("STPProcessingError", "__Internal")]
        NSString STPProcessingError { get; }

        // extern STPCardErrorCode  _Nonnull const STPIncorrectCVC;
        [Field("STPIncorrectCVC", "__Internal")]
        NSString STPIncorrectCVC { get; }
    }

    // @interface Stripe (NSError)
    [Category]
    [BaseType(typeof(NSError))]
    interface NSError_Stripe
    {
        // +(NSError * _Nullable)stp_errorFromStripeResponse:(NSDictionary * _Nullable)jsonDictionary;
        [Static]
        [Export("stp_errorFromStripeResponse:")]
        [return: NullAllowed]
        NSError StpErrorFromStripeResponse([NullAllowed] NSDictionary jsonDictionary);


    }

    // @interface Stripe_Theme (UINavigationBar)
    [Category]
    [BaseType(typeof(UINavigationBar))]
    interface UINavigationBar_Stripe_Theme
    {
        // - (void)stp_setTheme:(STPTheme *)theme DEPRECATED_MSG_ATTRIBUTE("Use the `stp_theme` property.");
        [Static, Deprecated(PlatformName.None, message: "Use the `stp_theme` property.")]
        [Export("stp_setTheme:")]
        void StpSetTheme(STPTheme theme);

        // @property (nonatomic, strong) STPTheme * _Nullable stp_theme;
        [Static]
        [NullAllowed, Export("stp_theme", ArgumentSemantic.Strong)]
        STPTheme StpTheme { get; set; }
    }

    //@interface STPCustomerContext : NSObject <STPBackendAPIAdapter>
    [BaseType(typeof(NSObject))]
    interface STPCustomerContext : STPBackendAPIAdapter
    {
        // - (instancetype)initWithKeyProvider:(id<STPEphemeralKeyProvider>)keyProvider;
        [Export("initWithKeyProvider:")]
        IntPtr Constructor(ISTPEphemeralKeyProvider keyProvider);

        // - (void)clearCachedCustomer;
        [Export("clearCachedCustomer")]
        void ClearCachedCustomer();

        /**
        By default, `STPCustomerContext` will filter Apple Pay sources when it retrieves
        a Customer object. Apple Pay sources should generally not be re-used and
        shouldn't be offered to customers as a new payment source (Apple Pay sources may
        only be re-used for subscriptions).

        If you are using `STPCustomerContext` to back your own UI and would like to
        disable Apple Pay filtering, set this property to YES.

        Note: If you are using `STPPaymentContext`, you should not change this property.

        @property (nonatomic, assign) BOOL includeApplePaySources;
        */
        [Export("includeApplePaySources", ArgumentSemantic.Assign)]
        bool IncludeApplePaySources { get; set; }
    }

    // @protocol STPEphemeralKeyProvider <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPEphemeralKeyProvider
    {
        // - (void)createCustomerKeyWithAPIVersion:(NSString *)apiVersion completion:(STPJSONResponseCompletionBlock)completion;
        [Abstract, Export("createCustomerKeyWithAPIVersion:completion:")]
        void SreateCustomerKeyWithAPIVersion(string apiVersion, STPJSONResponseCompletionBlock completion);
    }

    /**
    Parameters for creating a Connect Account token.

    @interface STPConnectAccountParams : NSObject<STPFormEncodable>
    */
    [BaseType(typeof(NSObject))]
    interface STPConnectAccountParams : STPFormEncodable
    {

        /**
        Optional boolean indicating that the Terms Of Service were shown to the user &
        the user accepted them.

        @property (nonatomic, nullable, readonly) NSNumber *tosShownAndAccepted;
        */
        [Export("tosShownAndAccepted", ArgumentSemantic.Strong)]
        NSNumber TosShownAndAccepted { get; }

        /**
        Required property with information about the legal entity for this account.

        At least one field in the legalEntity must have a value, otherwise the create token
        call will fail.

        @property (nonatomic, readonly) STPLegalEntityParams *legalEntity;
        */
        [Export("legalEntity", ArgumentSemantic.Strong)]
        STPLegalEntityParams LegalEntity { get; }

        /**
        `STPConnectAccountParams` cannot be directly instantiated, use `initWithTosShownAndAccepted:legalEntity:`
        or `initWithLegalEntity:`

        - (instancetype)init __attribute__((unavailable("Cannot be directly instantiated")));
        */

        /**
        Initialize `STPConnectAccountParams` with tosShownAndAccepted = YES

        This method cannot be called with `wasAccepted == NO`, guarded by a `NSParameterAssert()`.

        Use this init method if you want to set the `tosShownAndAccepted` parameter. If you
        don't, use the `initWithLegalEntity:` version instead.

        @param wasAccepted Must be YES, but only if the user was shown & accepted the ToS
        @param legalEntity data about the legal entity

        - (instancetype)initWithTosShownAndAccepted:(BOOL)wasAccepted
                                        legalEntity:(STPLegalEntityParams *)legalEntity;
        */
        [Export("initWithTosShownAndAccepted:legalEntity:")]
        IntPtr Constructor(bool wasAccepted, STPLegalEntityParams legalEntity);

        /**
        Initialize `STPConnectAccountParams` with the `STPLegalEntityParams` provided.

        This init method cannot change the `tosShownAndAccepted` parameter. Use
        `initWithTosShownAndAccepted:legalEntity:` instead if you need to do that.

        These two init methods exist to avoid the (slightly awkward) NSNumber box that would
        be needed around `tosShownAndAccepted` if it was optional/nullable, and to enforce
        that it is either nil or YES.

        @param legalEntity data to send to Stripe about the legal entity

        - (instancetype)initWithLegalEntity:(STPLegalEntityParams *)legalEntity;
        */
        [Export("initWithLegalEntity:")]
        IntPtr Constructor(STPLegalEntityParams legalEntity);

    }

    /**
    Stripe API parameters to define a Person. Things like their name, address, etc.

    All of the fields are optional.

    @interface STPPersonParams: NSObject<STPFormEncodable>
    */
    [BaseType(typeof(NSObject))]
    interface STPPersonParams : STPFormEncodable
    {
        /**
        The first name of this person.

        @property (nonatomic, copy, nullable) NSString *firstName;
        */
        [NullAllowed, Export("firstName")]
        string FirstName { get; set; }

        /**
        The last name of this person.

        @property (nonatomic, copy, nullable) NSString *lastName;
        */
        [NullAllowed, Export("lastName")]
        string LastName { get; set; }

        /**
        The maiden name of this person.

        @property (nonatomic, copy, nullable) NSString *maidenName;
        */
        [NullAllowed, Export("maidenName")]
        string MaidenName { get; set; }

        /**
        The address parameter. For `STPPersonParams`, this is the address of the person.
        For the `STPLegalEntityParams` subclass, see also `personalAddress`.

        @property (nonatomic, strong, nullable) STPAddress *address;
        */
        [NullAllowed, Export("address")]
        STPAddress Address { get; set; }

        /**
        The date of birth (dob) of this person.

        Must include `day`, `month`, and `year`, and only those fields are used.

        @property (nonatomic, copy, nullable) NSDateComponents *dateOfBirth;
        */
        [NullAllowed, Export("dateOfBirth")]
        NSDateComponents DateOfBirth { get; set; }

        /**
        Verification document for this person.

        @property (nonatomic, strong, nullable) STPVerificationParams *verification;
        */
        [NullAllowed, Export("verification")]
        STPVerificationParams Verification { get; set; }
    }

    /**
    Stripe API parameters to define a Legal Entity. This extends `STPPersonParams`
    and adds some more fields.

    Legal entities can be either an individual or a company.

    @interface STPLegalEntityParams : STPPersonParams
    */
    [BaseType(typeof(STPPersonParams))]
    interface STPLegalEntityParams
    {

        /**
        Additional owners of the legal entity.

        @property (nonatomic, copy, nullable) NSArray<STPPersonParams *> *additionalOwners;
        */
        [NullAllowed, Export("additionalOwners")]
        STPPersonParams[] AdditionalOwners { get; set; }

        /**
        The business name

        @property (nonatomic, copy, nullable) NSString *businessName;
        */
        [NullAllowed, Export("businessName")]
        string BusinessName { get; set; }

        /**
        The business Tax Id

        @property (nonatomic, copy, nullable) NSString *businessTaxId;
        */
        [NullAllowed, Export("businessTaxId")]
        string BusinessTaxId { get; set; }

        /**
        The business VAT Id

        @property (nonatomic, copy, nullable) NSString *businessVATId;
        */
        [NullAllowed, Export("businessVATId")]
        string BusinessVATId { get; set; }

        /**
        The gender of the individual, as a string.

        Currently either `male` or `female` are supported values.

        @property (nonatomic, copy, nullable) NSString *genderString;
        */
        [NullAllowed, Export("genderString")]
        string GenderString { get; set; }

        /**
        The personal address field.

        @property (nonatomic, strong, nullable) STPAddress *personalAddress;
        */
        [NullAllowed, Export("personalAddress")]
        string PersonalAddress { get; set; }

        /**
        The Personal Id number

        @property (nonatomic, copy, nullable) NSString *personalIdNumber;
        */
        [NullAllowed, Export("personalIdNumber")]
        string PersonalIdNumber { get; set; }

        /**
        The phone number of the entity.

        @property (nonatomic, copy, nullable) NSString *phoneNumber;
        */
        [NullAllowed, Export("phoneNumber")]
        string PhoneNumber { get; set; }

        /**
        The last four digits of the SSN of the individual.

        @property (nonatomic, copy, nullable) NSString *ssnLast4;
        */
        [NullAllowed, Export("ssnLast4")]
        string SsnLast4 { get; set; }

        /**
        The Tax Id Registrar

        @property (nonatomic, copy, nullable) NSString *taxIdRegistrar;
        */
        [NullAllowed, Export("taxIdRegistrar")]
        string TaxIdRegistrar { get; set; }

        /**
        The type of this legal entity, as a string.

        Currently `individual` or `company` are supported values.

        @property (nonatomic, copy, nullable) NSString *entityTypeString;
        */
        [NullAllowed, Export("entityTypeString")]
        string EntityTypeStringDocument { get; set; }
    }


    /**
    Parameters for supported types of verification.

    @interface STPVerificationParams: NSObject<STPFormEncodable>
    */
    [BaseType(typeof(NSObject))]
    interface STPVerificationParams : STPFormEncodable
    {
        /**
        The file id for the uploaded verification document.

        @property (nonatomic, copy, nullable) NSString *document;
        */
        [NullAllowed, Export("document")]
        string Document { get; set; }
    }

    // @interface STPPaymentIntent : NSObject<STPAPIResponseDecodable>
    [BaseType(typeof(NSObject)), DisableDefaultCtor]
    interface STPPaymentIntent : STPAPIResponseDecodable {
        // /**
        // The Stripe ID of the PaymentIntent.
        // */
        // @property (nonatomic, readonly) NSString *stripeId;
        [Export("stripeId")]
        string StripeId { get; }

        // /**
        // The client secret used to fetch this PaymentIntent
        // */
        // @property (nonatomic, readonly) NSString *clientSecret;
        [Export("clientSecret")]
        string ClientSecret { get; }

        // /**
        // Amount intended to be collected by this PaymentIntent.
        // */
        // @property (nonatomic, readonly) NSNumber *amount;
        [Export("amount")]
        float Amount { get; }

        // /**
        // If status is `STPPaymentIntentStatusCanceled`, when the PaymentIntent was canceled.
        // */
        // @property (nonatomic, nullable, readonly) NSDate *canceledAt;
        [Export("canceledAt")]
        NSDate CanceledAt { get; }

        // /**
        // Capture method of this PaymentIntent
        // */
        // @property (nonatomic, readonly) STPPaymentIntentCaptureMethod captureMethod;
        [Export("captureMethod")]
        STPPaymentIntentCaptureMethod CaptureMethod { get; }

        // /**
        // Confirmation method of this PaymentIntent
        // */
        // @property (nonatomic, readonly) STPPaymentIntentConfirmationMethod confirmationMethod;
        [Export("confirmationMethod")]
        STPPaymentIntentConfirmationMethod ConfirmationMethod { get; }

        // /**
        // When the PaymentIntent was created.
        // */
        // @property (nonatomic, nullable, readonly) NSDate *created;
        [Export("created")]
        NSDate created { get; }

        // /**
        // The currency associated with the PaymentIntent.
        // */
        // @property (nonatomic, readonly) NSString *currency;
        [Export("currency")]
        string Currency { get; }

        // /**
        // The `description` field of the PaymentIntent.
        // An arbitrary string attached to the object. Often useful for displaying to users.
        // */
        // @property (nonatomic, nullable, readonly) NSString *stripeDescription;
        [Export("stripeDescription")]
        string StripeDescription { get; }

        // /**
        // Whether or not this PaymentIntent was created in livemode.
        // */
        // @property (nonatomic, readonly) BOOL livemode;
        [Export("livemode")]
        bool Livemode { get; }

        // /**
        // Email address that the receipt for the resulting payment will be sent to.
        // */
        // @property (nonatomic, nullable, readonly) NSString *receiptEmail;
        [Export("receiptEmail")]
        string ReceiptEmail { get; }

        // /**
        // The URL to redirect your customer back to after they authenticate or cancel their
        // payment on the payment method’s app or site.

        // This should be a URL that your app handles if the PaymentIntent is going to
        // be confirmed in your app, and it has a redirect authorization flow.
        // */
        // @property (nonatomic, nullable, readonly) NSURL *returnUrl;
        [Export("returnUrl")]
        NSUrl ReturnUrl { get; }

        // /**
        // The Stripe ID of the Source used in this PaymentIntent.
        // */
        // @property (nonatomic, nullable, readonly) NSString *sourceId;
        [Export("sourceId")]
        string SourceId { get; }

        // /**
        // Status of the PaymentIntent
        // */
        // @property (nonatomic, readonly) STPPaymentIntentStatus status;
        [Export("status")]
        STPPaymentIntentStatus Status { get; }
    }

    // @interface STPPaymentIntentParams : NSObject<STPFormEncodable>
    [BaseType(typeof(NSObject))]
    interface STPPaymentIntentParams : STPFormEncodable {
        // /**
        // Initialize this `STPPaymentIntentParams` with a `clientSecret`, which is the only required
        // field.

        // @param clientSecret the client secret for this PaymentIntent
        // */
        // - (instancetype)initWithClientSecret:(NSString *)clientSecret;
        [Export("initWithClientSecret:")]
        IntPtr Constructor(string clientSecret);

        // /**
        // The Stripe id of the PaymentIntent, extracted from the clientSecret.
        // */
        // @property (nonatomic, copy, nullable, readonly) NSString *stripeId;
        [Export("stripeId")]
        [return: NullAllowed]
        string StripeId {get;}

        // /**
        // The client secret of the PaymentIntent. Required
        // */
        // @property (nonatomic, copy, readwrite) NSString *clientSecret;
        [Export("clientSecret")]
        string ClientSecret {get; set;}

        // /**
        // Provide a supported `STPSourceParams` object into here, and Stripe will create a Source
        // during PaymentIntent confirmation.

        // @note alternative to `sourceId`
        // */
        // @property (nonatomic, strong, nullable, readwrite) STPSourceParams *sourceParams;
        [Export("sourceParams"), NullAllowed]
        STPSourceParams SourceParams {get; set;}

        // /**
        // Provide an already created Source's id, and it will be used to confirm the PaymentIntent.

        // @note alternative to `sourceParams`
        // */
        // @property (nonatomic, copy, nullable, readwrite) NSString *sourceId;
        [Export("sourceId"), NullAllowed]
        string SourceId {get; set;}

        // /**
        // Email address that the receipt for the resulting payment will be sent to.
        // */
        // @property (nonatomic, copy, nullable, readwrite) NSString *receiptEmail;
        [Export("receiptEmail"), NullAllowed]
        string ReceiptEmail {get; set;}

        // /**
        // `@YES` to save this PaymentIntent’s Source to the associated Customer,
        // if the Source is not already attached.

        // This should be a boolean NSNumber, so that it can be `nil`
        // */
        // @property (nonatomic, strong, nullable, readwrite) NSNumber *saveSourceToCustomer;
        [Export("saveSourceToCustomer"), NullAllowed]
        float SaveSourceToCustomer {get; set;}

        // /**
        // The URL to redirect your customer back to after they authenticate or cancel
        // their payment on the payment method’s app or site.
        // This should probably be a URL that opens your iOS app.
        // */
        // @property (nonatomic, copy, nullable, readwrite) NSString *returnUrl;
        [Export("returnUrl"), NullAllowed]
        string ReturnUrl {get; set;}
    }

    //typedef void(^STPRedirectContextPaymentIntentCompletionBlock)(NSString *clientSecret, NSError * __nullable error);
    delegate void STPRedirectContextPaymentIntentCompletionBlock(string clientSecret, [NullAllowed] NSError error);
}
