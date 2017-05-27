
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
    partial interface ISTPAPIResponseDecodable {}
    partial interface ISTPFormEncodable {}
    partial interface ISTPPaymentMethod {}
    partial interface ISTPSourceProtocol {}

    // typedef void (^STPVoidBlock)();
    delegate void STPVoidBlock();

    // typedef void (^STPErrorBlock)(NSError * _Nullable);
    delegate void STPErrorBlock([NullAllowed] NSError arg0);

    // typedef void (^STPTokenCompletionBlock)(STPToken * _Nullable, NSError * _Nullable);
    delegate void STPTokenCompletionBlock([NullAllowed] STPToken arg0, [NullAllowed] NSError arg1);

    // typedef void (^STPSourceCompletionBlock)(STPSource * _Nullable, NSError * _Nullable);
    delegate void STPSourceCompletionBlock([NullAllowed] STPSource arg0, [NullAllowed] NSError arg1);

    // typedef void (^STPShippingMethodsCompletionBlock)(STPShippingStatus, NSError * _Nullable, NSArray<PKShippingMethod *> * _Nullable, PKShippingMethod * _Nullable);
    delegate void STPShippingMethodsCompletionBlock(STPShippingStatus arg0, [NullAllowed] NSError arg1, [NullAllowed] PKShippingMethod[] arg2, [NullAllowed] PKShippingMethod arg3);

    // typedef void (^STPFileCompletionBlock)(STPFile * _Nullable, NSError * _Nullable);
    delegate void STPFileCompletionBlock([NullAllowed] STPFile arg0, [NullAllowed] NSError arg1);

    // @protocol STPAPIResponseDecodable <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPAPIResponseDecodable
    {
        //TODO static method inside protocol
        // @required +(NSArray * _Nonnull)requiredFields;
        [Abstract]
        [Export("requiredFields")]
        NSObject[] RequiredFields { get; }

        //TODO static method inside protocol
        // @required +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response;
        [Abstract]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPAPIResponseDecodable DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);

        // @required @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Abstract]
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }
    }

    // @interface STPFile : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    interface STPFile : ISTPAPIResponseDecodable
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

        // +(NSString * _Nonnull)stringFromPurpose:(STPFilePurpose)purpose;
        [Static]
        [Export("stringFromPurpose:")]
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

    // @interface PII (STPAPIClient)
    [Category]
    [BaseType(typeof(STPAPIClient))]
    interface STPAPIClient_PII
    {
        // -(void)createTokenWithPersonalIDNumber:(NSString * _Nonnull)pii completion:(STPTokenCompletionBlock _Nullable)completion;
        [Export("createTokenWithPersonalIDNumber:completion:")]
        void CreateTokenWithPersonalIDNumber(string pii, [NullAllowed] STPTokenCompletionBlock completion);
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
        // +(BOOL)canSubmitPaymentRequest:(PKPaymentRequest * _Nonnull)paymentRequest __attribute__((availability(ios, introduced=8.0)));
        [Introduced(PlatformName.iOS, 8, 0)]
        [Static]
        [Export("canSubmitPaymentRequest:")]
        bool CanSubmitPaymentRequest(PKPaymentRequest paymentRequest);

        // +(BOOL)deviceSupportsApplePay;
        [Static]
        [Export("deviceSupportsApplePay")]
        bool DeviceSupportsApplePay { get; }

        // +(PKPaymentRequest * _Nonnull)paymentRequestWithMerchantIdentifier:(NSString * _Nonnull)merchantIdentifier __attribute__((availability(ios, introduced=8.0)));
        [Introduced(PlatformName.iOS, 8, 0)]
        [Static]
        [Export("paymentRequestWithMerchantIdentifier:")]
        PKPaymentRequest PaymentRequestWithMerchantIdentifier(string merchantIdentifier);
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

		// -(void)startPollingSourceWithId:(NSString * _Nonnull)identifier clientSecret:(NSString * _Nonnull)secret timeout:(NSTimeInterval)timeout completion:(STPSourceCompletionBlock _Nonnull)completion __attribute__((availability(ios_app_extension, unavailable))) __attribute__((availability(macos_app_extension, unavailable)));
		//TODO PlatformName.iOSAppExtension
		//[Unavailable(PlatformName.iOSAppExtension)]
		//[Unavailable(PlatformName.MacOSXAppExtension)]
		[Export("startPollingSourceWithId:clientSecret:timeout:completion:")]
        void StartPollingSourceWithId(string identifier, string secret, double timeout, STPSourceCompletionBlock completion);

		// -(void)stopPollingSourceWithId:(NSString * _Nonnull)identifier __attribute__((availability(ios_app_extension, unavailable))) __attribute__((availability(macos_app_extension, unavailable)));
		//TODO PlatformName.iOSAppExtension
		//[Unavailable(PlatformName.iOSAppExtension)]
		//[Unavailable(PlatformName.MacOSXAppExtension)]
		[Export("stopPollingSourceWithId:")]
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

    // @interface STPAddress : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    interface STPAddress : ISTPAPIResponseDecodable
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

        // -(instancetype _Nonnull)initWithABRecord:(ABRecordRef _Nonnull)record;
        [Export("initWithABRecord:")]
        unsafe IntPtr Constructor(ABRecord record);

		// -(ABRecordRef _Nonnull)ABRecordValue;
		[Export("ABRecordValue")]
        unsafe ABRecord ABRecordValue { get; }

        // -(instancetype _Nonnull)initWithPKContact:(PKContact * _Nonnull)contact __attribute__((availability(ios, introduced=9.0)));
        [Introduced(PlatformName.iOS, 9, 0)]
        [Export("initWithPKContact:")]
        IntPtr Constructor(PKContact contact);

        // -(PKContact * _Nonnull)PKContactValue __attribute__((availability(ios, introduced=9.0)));
        [Introduced(PlatformName.iOS, 9, 0)]
        [Export("PKContactValue")]
        PKContact PKContactValue { get; }

        // -(instancetype _Nonnull)initWithCNContact:(CNContact * _Nonnull)contact __attribute__((availability(ios, introduced=9.0)));
        [Introduced(PlatformName.iOS, 9, 0)]
        [Export("initWithCNContact:")]
        IntPtr Constructor(CNContact contact);

        // -(BOOL)containsRequiredFields:(STPBillingAddressFields)requiredFields;
        [Export("containsRequiredFields:")]
        bool ContainsRequiredFields(STPBillingAddressFields requiredFields);

        // -(BOOL)containsRequiredShippingAddressFields:(PKAddressField)requiredFields;
        [Export("containsRequiredShippingAddressFields:")]
        bool ContainsRequiredShippingAddressFields(PKAddressField requiredFields);

        // +(PKAddressField)applePayAddressFieldsFromBillingAddressFields:(STPBillingAddressFields)billingAddressFields;
        [Static]
        [Export("applePayAddressFieldsFromBillingAddressFields:")]
        PKAddressField ApplePayAddressFieldsFromBillingAddressFields(STPBillingAddressFields billingAddressFields);
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
    interface STPCardParams : ISTPFormEncodable
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
        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
        [Abstract]
        [Export("stripeID")]
        string StripeID { get; }
    }

    // @interface STPCustomer : NSObject
    [BaseType(typeof(NSObject))]
    interface STPCustomer
    {
        // +(instancetype _Nonnull)customerWithStripeID:(NSString * _Nonnull)stripeID defaultSource:(id<STPSourceProtocol> _Nullable)defaultSource sources:(NSArray<id<STPSourceProtocol>> * _Nonnull)sources;
        [Static]
        [Export("customerWithStripeID:defaultSource:sources:")]
        STPCustomer CustomerWithStripeID(string stripeID, [NullAllowed] STPSourceProtocol defaultSource, STPSourceProtocol[] sources);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
        [Export("stripeID")]
        string StripeID { get; }

        // @property (readonly, nonatomic) id<STPSourceProtocol> _Nullable defaultSource;
        [NullAllowed, Export("defaultSource")]
        STPSourceProtocol DefaultSource { get; }

        // @property (readonly, nonatomic) NSArray<id<STPSourceProtocol>> * _Nonnull sources;
        [Export("sources")]
        STPSourceProtocol[] Sources { get; }
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

    // typedef void (^STPCustomerCompletionBlock)(STPCustomer * _Nullable, NSError * _Nullable);
    delegate void STPCustomerCompletionBlock([NullAllowed] STPCustomer arg0, [NullAllowed] NSError arg1);

    // @protocol STPBackendAPIAdapter <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPBackendAPIAdapter
    {
        // @required -(void)retrieveCustomer:(STPCustomerCompletionBlock _Nonnull)completion;
        [Abstract]
        [Export("retrieveCustomer:")]
        void RetrieveCustomer(STPCustomerCompletionBlock completion);

        // @required -(void)attachSourceToCustomer:(id<STPSourceProtocol> _Nonnull)source completion:(STPErrorBlock _Nonnull)completion;
        [Abstract]
        [Export("attachSourceToCustomer:completion:")]
        void AttachSourceToCustomer(STPSourceProtocol source, STPErrorBlock completion);

        // @required -(void)selectDefaultCustomerSource:(id<STPSourceProtocol> _Nonnull)source completion:(STPErrorBlock _Nonnull)completion;
        [Abstract]
        [Export("selectDefaultCustomerSource:completion:")]
        void SelectDefaultCustomerSource(STPSourceProtocol source, STPErrorBlock completion);
    }

    // @protocol STPPaymentMethod <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPPaymentMethod
    {
        // @required @property (readonly, nonatomic) UIImage * image;
        [Abstract]
        [Export("image")]
        UIImage Image { get; }

        // @required @property (readonly, nonatomic) UIImage * templateImage;
        [Abstract]
        [Export("templateImage")]
        UIImage TemplateImage { get; }

        // @required @property (readonly, nonatomic) NSString * label;
        [Abstract]
        [Export("label")]
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

        // @property (copy, nonatomic) NSString * _Nonnull publishableKey;
        [Export("publishableKey")]
        string PublishableKey { get; set; }

        // @property (nonatomic) STPPaymentMethodType additionalPaymentMethods;
        [Export("additionalPaymentMethods", ArgumentSemantic.Assign)]
        STPPaymentMethodType AdditionalPaymentMethods { get; set; }

        // @property (nonatomic) STPBillingAddressFields requiredBillingAddressFields;
        [Export("requiredBillingAddressFields", ArgumentSemantic.Assign)]
        STPBillingAddressFields RequiredBillingAddressFields { get; set; }

        // @property (nonatomic) PKAddressField requiredShippingAddressFields;
        [Export("requiredShippingAddressFields", ArgumentSemantic.Assign)]
        PKAddressField RequiredShippingAddressFields { get; set; }

        // @property (nonatomic) STPShippingType shippingType;
        [Export("shippingType", ArgumentSemantic.Assign)]
        STPShippingType ShippingType { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull companyName;
        [Export("companyName")]
        string CompanyName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable appleMerchantIdentifier;
        [NullAllowed, Export("appleMerchantIdentifier")]
        string AppleMerchantIdentifier { get; set; }

        // @property (nonatomic) BOOL smsAutofillDisabled;
        [Export("smsAutofillDisabled")]
        bool SmsAutofillDisabled { get; set; }
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

        // @property (nonatomic, weak) id<STPAddCardViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) STPUserInformation * _Nullable prefilledInformation;
        [NullAllowed, Export("prefilledInformation", ArgumentSemantic.Strong)]
        STPUserInformation PrefilledInformation { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable managedAccountCurrency;
        [NullAllowed, Export("managedAccountCurrency")]
        string ManagedAccountCurrency { get; set; }
    }

    // @protocol STPAddCardViewControllerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface STPAddCardViewControllerDelegate
    {
        // @required -(void)addCardViewControllerDidCancel:(STPAddCardViewController * _Nonnull)addCardViewController;
        [Abstract]
        [Export("addCardViewControllerDidCancel:")]
        void AddCardViewControllerDidCancel(STPAddCardViewController addCardViewController);

        // @required -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreateToken:(STPToken * _Nonnull)token completion:(STPErrorBlock _Nonnull)completion;
        [Abstract]
        [Export("addCardViewController:didCreateToken:completion:")]
        void AddCardViewController(STPAddCardViewController addCardViewController, STPToken token, STPErrorBlock completion);
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
    }

    // @interface STPApplePayPaymentMethod : NSObject <STPPaymentMethod>
    [BaseType(typeof(NSObject))]
    interface STPApplePayPaymentMethod : ISTPPaymentMethod
    {
    }

    // @interface STPBankAccountParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject))]
    interface STPBankAccountParams : ISTPFormEncodable
    {
        // @property (copy, nonatomic) NSString * _Nullable accountNumber;
        [NullAllowed, Export("accountNumber")]
        string AccountNumber { get; set; }

        // -(NSString * _Nullable)last4;
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

        // @property (copy, nonatomic) NSString * _Nullable accountHolderName;
        [NullAllowed, Export("accountHolderName")]
        string AccountHolderName { get; set; }

        // @property (nonatomic) STPBankAccountHolderType accountHolderType;
        [Export("accountHolderType", ArgumentSemantic.Assign)]
        STPBankAccountHolderType AccountHolderType { get; set; }
    }

    // @interface STPBankAccount : STPBankAccountParams <STPAPIResponseDecodable>
    [BaseType(typeof(STPBankAccountParams))]
    interface STPBankAccount : ISTPAPIResponseDecodable
    {
        // @property (copy, nonatomic) NSString * _Nonnull routingNumber;
        [Export("routingNumber")]
        string RoutingNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; set; }

        // @property (readonly, nonatomic) NSString * _Nonnull bankAccountId;
        [Export("bankAccountId")]
        string BankAccountId { get; }

        // @property (readonly, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, nonatomic) NSString * _Nullable bankName;
        [NullAllowed, Export("bankName")]
        string BankName { get; }

        // @property (copy, nonatomic) NSString * _Nullable accountHolderName;
        [NullAllowed, Export("accountHolderName")]
        string AccountHolderName { get; set; }

        // @property (nonatomic) STPBankAccountHolderType accountHolderType;
        [Export("accountHolderType", ArgumentSemantic.Assign)]
        STPBankAccountHolderType AccountHolderType { get; set; }

        // @property (readonly, nonatomic) NSString * _Nullable fingerprint;
        [NullAllowed, Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, nonatomic) STPBankAccountStatus status;
        [Export("status")]
        STPBankAccountStatus Status { get; }
    }

    // @interface STPCard : STPCardParams <STPAPIResponseDecodable, STPPaymentMethod, STPSourceProtocol>
    [BaseType(typeof(STPCardParams))]
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

    // @interface STPPaymentCardTextField :˚ UIControl <UIKeyInput>
    [BaseType(typeof(UIControl))]
    interface STPPaymentCardTextField : IUIKeyInput
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPPaymentCardTextFieldDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<STPPaymentCardTextFieldDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (copy, nonatomic) UIFont * _Null_unspecified font __attribute__((annotate("ui_appearance_selector")));
        [Export("font", ArgumentSemantic.Copy)]
        UIFont Font { get; set; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified textColor __attribute__((annotate("ui_appearance_selector")));
        [Export("textColor", ArgumentSemantic.Copy)]
        UIColor TextColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified textErrorColor __attribute__((annotate("ui_appearance_selector")));
        [Export("textErrorColor", ArgumentSemantic.Copy)]
        UIColor TextErrorColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified placeholderColor __attribute__((annotate("ui_appearance_selector")));
        [Export("placeholderColor", ArgumentSemantic.Copy)]
        UIColor PlaceholderColor { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable numberPlaceholder;
        [NullAllowed, Export("numberPlaceholder")]
        string NumberPlaceholder { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable expirationPlaceholder;
        [NullAllowed, Export("expirationPlaceholder")]
        string ExpirationPlaceholder { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable cvcPlaceholder;
        [NullAllowed, Export("cvcPlaceholder")]
        string CvcPlaceholder { get; set; }

        // @property (copy, nonatomic) UIColor * _Null_unspecified cursorColor __attribute__((annotate("ui_appearance_selector")));
        [Export("cursorColor", ArgumentSemantic.Copy)]
        UIColor CursorColor { get; set; }

        // @property (copy, nonatomic) UIColor * _Nullable borderColor __attribute__((annotate("ui_appearance_selector")));
        [NullAllowed, Export("borderColor", ArgumentSemantic.Copy)]
        UIColor BorderColor { get; set; }

        // @property (assign, nonatomic) CGFloat borderWidth __attribute__((annotate("ui_appearance_selector")));
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (assign, nonatomic) CGFloat cornerRadius __attribute__((annotate("ui_appearance_selector")));
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (assign, nonatomic) UIKeyboardAppearance keyboardAppearance __attribute__((annotate("ui_appearance_selector")));
        [Export("keyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance KeyboardAppearance { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable inputAccessoryView;
        [NullAllowed, Export("inputAccessoryView", ArgumentSemantic.Strong)]
        UIView InputAccessoryView { get; set; }

        // @property (readonly, nonatomic) UIImage * _Nullable brandImage;
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

        // @property (readonly, nonatomic) NSString * _Nullable formattedExpirationMonth;
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
        STPSourceProtocol Source { get; }

        // -(instancetype _Nonnull)initWithSource:(id<STPSourceProtocol> _Nonnull)source;
        [Export("initWithSource:")]
        IntPtr Constructor(STPSourceProtocol source);
    }

    // @interface STPPaymentContext : NSObject
    [BaseType(typeof(NSObject))]
    interface STPPaymentContext
    {
        // -(instancetype _Nonnull)initWithAPIAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter;
        [Export("initWithAPIAdapter:")]
        IntPtr Constructor(STPBackendAPIAdapter apiAdapter);

        // -(instancetype _Nonnull)initWithAPIAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter configuration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme;
        [Export("initWithAPIAdapter:configuration:theme:")]
        IntPtr Constructor(STPBackendAPIAdapter apiAdapter, STPPaymentConfiguration configuration, STPTheme theme);

        // @property (readonly, nonatomic) id<STPBackendAPIAdapter> _Nonnull apiAdapter;
        [Export("apiAdapter")]
        STPBackendAPIAdapter ApiAdapter { get; }

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
        STPPaymentMethod SelectedPaymentMethod { get; }

        // @property (readonly, nonatomic) NSArray<id<STPPaymentMethod>> * _Nullable paymentMethods;
        [NullAllowed, Export("paymentMethods")]
        STPPaymentMethod[] PaymentMethods { get; }

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

        // @property (copy, nonatomic) NSArray<PKPaymentSummaryItem *> * _Nonnull paymentSummaryItems __attribute__((availability(ios, introduced=8.0)));
        [Introduced(PlatformName.iOS, 8, 0)]
        [Export("paymentSummaryItems", ArgumentSemantic.Copy)]
        PKPaymentSummaryItem[] PaymentSummaryItems { get; set; }

        // @property (assign, nonatomic) UIModalPresentationStyle modalPresentationStyle;
        [Export("modalPresentationStyle", ArgumentSemantic.Assign)]
        UIModalPresentationStyle ModalPresentationStyle { get; set; }

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
        IntPtr Constructor(STPPaymentConfiguration configuration, STPTheme theme, STPBackendAPIAdapter apiAdapter, STPPaymentMethodsViewControllerDelegate @delegate);

        // @property (nonatomic, strong) STPUserInformation * _Nullable prefilledInformation;
        [NullAllowed, Export("prefilledInformation", ArgumentSemantic.Strong)]
        STPUserInformation PrefilledInformation { get; set; }

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
        void PaymentMethodsViewController(STPPaymentMethodsViewController paymentMethodsViewController, STPPaymentMethod paymentMethod);

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

    // typedef void (^STPRedirectContextCompletionBlock)(NSString * _Nonnull, NSString * _Nonnull, NSError * _Nonnull);
    delegate void STPRedirectContextCompletionBlock(string arg0, string arg1, NSError arg2);

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

        // -(void)startRedirectFlowFromViewController:(UIViewController * _Nonnull)presentingViewController;
        [Export("startRedirectFlowFromViewController:")]
        void StartRedirectFlowFromViewController(UIViewController presentingViewController);

        // -(void)startSafariViewControllerRedirectFlowFromViewController:(UIViewController * _Nonnull)presentingViewController __attribute__((availability(ios, introduced=9.0)));
        [Introduced(PlatformName.iOS, 9, 0)]
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
    interface STPSourceCardDetails : ISTPAPIResponseDecodable
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
    }

    // @interface STPSourceOwner : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPSourceOwner : ISTPAPIResponseDecodable
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
    interface STPSourceReceiver : ISTPAPIResponseDecodable
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
    interface STPSourceRedirect : ISTPAPIResponseDecodable
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
    interface STPSourceSEPADebitDetails : ISTPAPIResponseDecodable
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
    interface STPSourceVerification : ISTPAPIResponseDecodable
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
    interface STPSource : ISTPAPIResponseDecodable, ISTPSourceProtocol
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
    interface STPSourceParams : ISTPFormEncodable, INSCopying
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

        // +(STPSourceParams * _Nonnull)bitcoinParamsWithAmount:(NSUInteger)amount currency:(NSString * _Nonnull)currency email:(NSString * _Nonnull)email;
        [Static]
        [Export("bitcoinParamsWithAmount:currency:email:")]
        STPSourceParams BitcoinParamsWithAmount(nuint amount, string currency, string email);

        // +(STPSourceParams * _Nonnull)cardParamsWithCard:(STPCardParams * _Nonnull)card;
        [Static]
        [Export("cardParamsWithCard:")]
        STPSourceParams CardParamsWithCard(STPCardParams card);

        // +(STPSourceParams * _Nonnull)giropayParamsWithAmount:(NSUInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor;
        [Static]
        [Export("giropayParamsWithAmount:name:returnURL:statementDescriptor:")]
        STPSourceParams GiropayParamsWithAmount(nuint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

        // +(STPSourceParams * _Nonnull)idealParamsWithAmount:(NSUInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor bank:(NSString * _Nullable)bank;
        [Static]
        [Export("idealParamsWithAmount:name:returnURL:statementDescriptor:bank:")]
        STPSourceParams IdealParamsWithAmount(nuint amount, string name, string returnURL, [NullAllowed] string statementDescriptor, [NullAllowed] string bank);

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
    }

    // @interface STPToken : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPToken : ISTPAPIResponseDecodable, ISTPSourceProtocol
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

        // +(NSError * _Nonnull)stp_genericConnectionError;
        [Static]
        [Export("stp_genericConnectionError")]
        NSError StpGenericConnectionError();

        // +(NSError * _Nonnull)stp_genericFailedToParseResponseError;
        [Static]
        [Export("stp_genericFailedToParseResponseError")]
        NSError StpGenericFailedToParseResponseError();

        // -(BOOL)stp_isUnknownCheckoutError;
        [Static]
        [Export("stp_isUnknownCheckoutError")]
        bool StpIsUnknownCheckoutError();

        // -(BOOL)stp_isURLSessionCancellationError;
        [Static]
        [Export("stp_isURLSessionCancellationError")]
        bool StpIsURLSessionCancellationError();

        // +(NSString * _Nonnull)stp_cardErrorInvalidNumberUserMessage;
        [Static]
        [Export("stp_cardErrorInvalidNumberUserMessage")]
        string StpCardErrorInvalidNumberUserMessage();

        // +(NSString * _Nonnull)stp_cardInvalidCVCUserMessage;
        [Static]
        [Export("stp_cardInvalidCVCUserMessage")]
        string StpCardInvalidCVCUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorInvalidExpMonthUserMessage;
        [Static]
        [Export("stp_cardErrorInvalidExpMonthUserMessage")]
        string StpCardErrorInvalidExpMonthUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorInvalidExpYearUserMessage;
        [Static]
        [Export("stp_cardErrorInvalidExpYearUserMessage")]
        string StpCardErrorInvalidExpYearUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorExpiredCardUserMessage;
        [Static]
        [Export("stp_cardErrorExpiredCardUserMessage")]
        string StpCardErrorExpiredCardUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorDeclinedUserMessage;
        [Static]
        [Export("stp_cardErrorDeclinedUserMessage")]
        string StpCardErrorDeclinedUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorProcessingErrorUserMessage;
        [Static]
        [Export("stp_cardErrorProcessingErrorUserMessage")]
        string StpCardErrorProcessingErrorUserMessage();

        // +(NSString * _Nonnull)stp_unexpectedErrorMessage;
        [Static]
        [Export("stp_unexpectedErrorMessage")]
        string StpUnexpectedErrorMessage();
    }

    // @interface Stripe_Theme (UINavigationBar)
    [Category]
    [BaseType(typeof(UINavigationBar))]
    interface UINavigationBar_Stripe_Theme
    {
        // -(void)stp_setTheme:(STPTheme * _Nonnull)theme __attribute__((deprecated("")));
        [Static]
        [Export("stp_setTheme:")]
        void StpSetTheme(STPTheme theme);

        // @property (nonatomic, strong) STPTheme * _Nullable stp_theme;
        [Static]
        [NullAllowed, Export("stp_theme", ArgumentSemantic.Strong)]
        STPTheme StpTheme { get; set; }
    }
}
