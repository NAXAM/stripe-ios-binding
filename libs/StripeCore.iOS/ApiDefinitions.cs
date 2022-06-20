using Foundation;
using ObjCRuntime;
using StripeCore;

namespace StripeCore
{
    // @interface StripeCore_Swift_218 (NSError)
    [Category]
    [BaseType(typeof(NSError))]
    interface NSError_StripeCore_Swift_218
    {
        // +(NSError * _Nonnull)stp_genericConnectionError __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_genericConnectionError")]
        NSError Stp_genericConnectionError();

        // +(NSError * _Nonnull)stp_genericFailedToParseResponseError __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_genericFailedToParseResponseError")]
        NSError Stp_genericFailedToParseResponseError();

        // +(NSError * _Nonnull)stp_ephemeralKeyDecodingError __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_ephemeralKeyDecodingError")]
        NSError Stp_ephemeralKeyDecodingError();

        // +(NSError * _Nonnull)stp_clientSecretError __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_clientSecretError")]
        NSError Stp_clientSecretError();

        // +(NSString * _Nonnull)stp_cardErrorInvalidNumberUserMessage __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_cardErrorInvalidNumberUserMessage")]
        string Stp_cardErrorInvalidNumberUserMessage();

        // +(NSString * _Nonnull)stp_cardInvalidCVCUserMessage __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_cardInvalidCVCUserMessage")]
        string Stp_cardInvalidCVCUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorInvalidExpMonthUserMessage __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_cardErrorInvalidExpMonthUserMessage")]
        string Stp_cardErrorInvalidExpMonthUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorInvalidExpYearUserMessage __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_cardErrorInvalidExpYearUserMessage")]
        string Stp_cardErrorInvalidExpYearUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorExpiredCardUserMessage __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_cardErrorExpiredCardUserMessage")]
        string Stp_cardErrorExpiredCardUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorDeclinedUserMessage __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_cardErrorDeclinedUserMessage")]
        string Stp_cardErrorDeclinedUserMessage();

        // +(NSString * _Nonnull)stp_cardErrorProcessingErrorUserMessage __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_cardErrorProcessingErrorUserMessage")]
        string Stp_cardErrorProcessingErrorUserMessage();
    }

    // @interface STPAnalyticsClient : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10StripeCore18STPAnalyticsClient")]
    interface STPAnalyticsClient
    {
        // @property (readonly, nonatomic, strong, class) STPAnalyticsClient * _Nonnull sharedClient;
        [Static]
        [Export("sharedClient", ArgumentSemantic.Strong)]
        STPAnalyticsClient SharedClient { get; }

        // @property (copy, nonatomic) NSSet<NSString *> * _Nonnull productUsage;
        [Export("productUsage", ArgumentSemantic.Copy)]
        NSSet<NSString> ProductUsage { get; set; }

        // +(NSString * _Nullable)tokenTypeFromParameters:(NSDictionary * _Nonnull)parameters __attribute__((warn_unused_result("")));
        [Static]
        [Export("tokenTypeFromParameters:")]
        [return: NullAllowed]
        string TokenTypeFromParameters(NSDictionary parameters);
    }

    // @interface STPNumericStringValidator : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10StripeCore25STPNumericStringValidator")]
    interface STPNumericStringValidator
    {
    }

    // @interface STPURLCallbackHandler : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC10StripeCore21STPURLCallbackHandler")]
    interface STPURLCallbackHandler
    {
        // +(STPURLCallbackHandler * _Nonnull)shared __attribute__((warn_unused_result("")));
        [Static]
        [Export("shared")]
        STPURLCallbackHandler Shared { get; }

        // -(BOOL)handleURLCallback:(NSUrl * _Nonnull)url;
        [Export("handleURLCallback:")]
        bool HandleURLCallback(NSUrl url);

        // -(void)registerListener:(id<STPURLCallbackListener> _Nonnull)listener forURL:(NSUrl * _Nonnull)url;
        [Export("registerListener:forURL:")]
        void RegisterListener(STPURLCallbackListener listener, NSUrl url);

        // -(void)unregisterListener:(id<STPURLCallbackListener> _Nonnull)listener;
        [Export("unregisterListener:")]
        void UnregisterListener(STPURLCallbackListener listener);
    }

    // @protocol STPURLCallbackListener <NSObject>
    /*
      Check whether adding [Model] to this declaration is appropriate.
      [Model] is used to generate a C# class that implements this protocol,
      and might be useful for protocols that consumers are supposed to implement,
      since consumers can subclass the generated class instead of implementing
      the generated interface. If consumers are not supposed to implement this
      protocol, then [Model] is redundant and will generate code that will never
      be used.
    */
    [Protocol(Name = "_TtP10StripeCore22STPURLCallbackListener_")]
    [BaseType(typeof(NSObject), Name = "_TtP10StripeCore22STPURLCallbackListener_")]
    interface STPURLCallbackListener
    {
        // @required -(BOOL)handleURLCallback:(NSUrl * _Nonnull)url __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("handleURLCallback:")]
        bool HandleURLCallback(NSUrl url);
    }
}
