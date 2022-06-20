using System;
using Contacts;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using PassKit;
using SafariServices;
using Stripe;
using StripeCore;
using StripeApplePay;
using UIKit;

namespace Stripe
{
    // @interface Stripe_Swift_221 (NSError)
    [Category]
    [BaseType(typeof(NSError))]
    interface NSError_Stripe_Swift_221
    {
        // +(NSError * _Nullable)stp_errorFromStripeResponse:(NSDictionary * _Nullable)jsonDictionary __attribute__((warn_unused_result("")));
        [Static]
        [Export("stp_errorFromStripeResponse:")]
        [return: NullAllowed]
        NSError Stp_errorFromStripeResponse([NullAllowed] NSDictionary jsonDictionary);
    }

    // @protocol STPAPIResponseDecodable <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    partial interface ISTPAPIResponseDecodable { }

    [Protocol(Name = "_TtP6Stripe23STPAPIResponseDecodable_"), Model]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe23STPAPIResponseDecodable_")]
    interface STPAPIResponseDecodable
    {
        //// @required +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        //[Static, Abstract]
        //[Export ("decodedObjectFromAPIResponse:")]
        //[return: NullAllowed]
        //ISTPAPIResponseDecodable DecodedObjectFromAPIResponse ([NullAllowed] NSDictionary response);

        // @required @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Abstract]
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }
    }

    // @protocol STPFormTextFieldContainer <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe25STPFormTextFieldContainer_"), Model]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe25STPFormTextFieldContainer_")]
    interface STPFormTextFieldContainer
    {
        // @required @property (nonatomic, strong) UIFont * _Nonnull formFont;
        [Abstract]
        [Export("formFont", ArgumentSemantic.Strong)]
        UIFont FormFont { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nonnull formTextColor;
        [Abstract]
        [Export("formTextColor", ArgumentSemantic.Strong)]
        UIColor FormTextColor { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nonnull formTextErrorColor;
        [Abstract]
        [Export("formTextErrorColor", ArgumentSemantic.Strong)]
        UIColor FormTextErrorColor { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nonnull formPlaceholderColor;
        [Abstract]
        [Export("formPlaceholderColor", ArgumentSemantic.Strong)]
        UIColor FormPlaceholderColor { get; set; }

        // @required @property (nonatomic, strong) UIColor * _Nonnull formCursorColor;
        [Abstract]
        [Export("formCursorColor", ArgumentSemantic.Strong)]
        UIColor FormCursorColor { get; set; }

        // @required @property (nonatomic) UIKeyboardAppearance formKeyboardAppearance;
        [Abstract]
        [Export("formKeyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance FormKeyboardAppearance { get; set; }
    }

    // @interface STPMultiFormTextField : UIView <STPFormTextFieldContainer, UITextFieldDelegate>
    [BaseType(typeof(UIView), Name = "_TtC6Stripe21STPMultiFormTextField")]
    partial interface STPMultiFormTextField : STPFormTextFieldContainer, IUITextFieldDelegate
    {
        // -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
        [Export("textField:shouldChangeCharactersInRange:replacementString:")]
        bool TextField(UITextField textField, NSRange range, string @string);

        // -(void)focusNextForm;
        [Export("focusNextForm")]
        void FocusNextForm();

        // @property (readonly, nonatomic) BOOL canResignFirstResponder;
        [Export("canResignFirstResponder")]
        bool CanResignFirstResponder { get; }

        // -(BOOL)resignFirstResponder __attribute__((warn_unused_result("")));
        [Export("resignFirstResponder")]
        bool ResignFirstResponder { get; }

        // @property (readonly, nonatomic) BOOL isFirstResponder;
        [Export("isFirstResponder")]
        bool IsFirstResponder { get; }

        // @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
        [Export("canBecomeFirstResponder")]
        bool CanBecomeFirstResponder { get; }

        // -(BOOL)becomeFirstResponder __attribute__((warn_unused_result("")));
        [Export("becomeFirstResponder")]
        bool BecomeFirstResponder();

        // -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
        [Export("textFieldDidEndEditing:")]
        void TextFieldDidEndEditing(UITextField textField);

        // -(void)textFieldDidBeginEditing:(UITextField * _Nonnull)textField;
        [Export("textFieldDidBeginEditing:")]
        void TextFieldDidBeginEditing(UITextField textField);

        // -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
        [Export("textFieldShouldReturn:")]
        bool TextFieldShouldReturn(UITextField textField);

        // @property (nonatomic, strong) UIFont * _Nonnull formFont;
        [Export("formFont", ArgumentSemantic.Strong)]
        UIFont FormFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull formTextColor;
        [Export("formTextColor", ArgumentSemantic.Strong)]
        UIColor FormTextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull formTextErrorColor;
        [Export("formTextErrorColor", ArgumentSemantic.Strong)]
        UIColor FormTextErrorColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull formPlaceholderColor;
        [Export("formPlaceholderColor", ArgumentSemantic.Strong)]
        UIColor FormPlaceholderColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull formCursorColor;
        [Export("formCursorColor", ArgumentSemantic.Strong)]
        UIColor FormCursorColor { get; set; }

        // @property (nonatomic) UIKeyboardAppearance formKeyboardAppearance;
        [Export("formKeyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance FormKeyboardAppearance { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)coder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder coder);
    }

    // @interface STPAUBECSDebitFormView : STPMultiFormTextField <UITextViewDelegate>
    [BaseType(typeof(STPMultiFormTextField), Name = "_TtC6Stripe22STPAUBECSDebitFormView")]
    interface STPAUBECSDebitFormView : IUITextViewDelegate
    {
        // -(instancetype _Nonnull)initWithCompanyName:(NSString * _Nonnull)companyName __attribute__((objc_designated_initializer));
        [Export("initWithCompanyName:")]
        [DesignatedInitializer]
        IntPtr Constructor(string companyName);

        // @property (nonatomic, strong) UIColor * _Nonnull formBackgroundColor;
        [Export("formBackgroundColor", ArgumentSemantic.Strong)]
        UIColor FormBackgroundColor { get; set; }

        [Wrap("WeakBecsDebitFormDelegate")]
        [NullAllowed]
        STPAUBECSDebitFormViewDelegate BecsDebitFormDelegate { get; set; }

        // @property (nonatomic, weak) id<STPAUBECSDebitFormViewDelegate> _Nullable becsDebitFormDelegate;
        [NullAllowed, Export("becsDebitFormDelegate", ArgumentSemantic.Weak)]
        NSObject WeakBecsDebitFormDelegate { get; set; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodParams * _Nullable paymentMethodParams;
        [NullAllowed, Export("paymentMethodParams", ArgumentSemantic.Strong)]
        STPPaymentMethodParams PaymentMethodParams { get; }

        // -(CGSize)systemLayoutSizeFittingSize:(CGSize)targetSize withHorizontalFittingPriority:(UILayoutPriority)horizontalFittingPriority verticalFittingPriority:(UILayoutPriority)verticalFittingPriority __attribute__((warn_unused_result("")));
        [Export("systemLayoutSizeFittingSize:withHorizontalFittingPriority:verticalFittingPriority:")]
        CGSize SystemLayoutSizeFittingSize(CGSize targetSize, float horizontalFittingPriority, float verticalFittingPriority);

        // -(BOOL)textView:(UITextView * _Nonnull)textView shouldInteractWithURL:(NSUrl * _Nonnull)URL inRange:(NSRange)characterRange interaction:(UITextItemInteraction)interaction __attribute__((warn_unused_result("")));
        [Export("textView:shouldInteractWithURL:inRange:interaction:")]
        bool TextView(UITextView textView, NSUrl URL, NSRange characterRange, UITextItemInteraction interaction);

        // @property (nonatomic, strong) UIFont * _Nonnull formFont;
        [Export("formFont", ArgumentSemantic.Strong)]
        UIFont FormFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull formTextColor;
        [Export("formTextColor", ArgumentSemantic.Strong)]
        UIColor FormTextColor { get; set; }
    }

    // @protocol STPAUBECSDebitFormViewDelegate <NSObject>
    [Protocol(Name = "_TtP6Stripe30STPAUBECSDebitFormViewDelegate_"), Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe30STPAUBECSDebitFormViewDelegate_")]
    interface STPAUBECSDebitFormViewDelegate
    {
        // @required -(void)auBECSDebitForm:(STPAUBECSDebitFormView * _Nonnull)form didChangeToStateComplete:(BOOL)complete;
        [Abstract]
        [Export("auBECSDebitForm:didChangeToStateComplete:")]
        void DidChangeToStateComplete(STPAUBECSDebitFormView form, bool complete);
    }

    // @protocol STPPaymentCardTextFieldDelegate <NSObject>
    [Protocol(Name = "_TtP6Stripe31STPPaymentCardTextFieldDelegate_"), Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe31STPPaymentCardTextFieldDelegate_")]
    interface STPPaymentCardTextFieldDelegate
    {
        // @optional -(void)paymentCardTextFieldDidChange:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidChange:")]
        void PaymentCardTextFieldDidChange(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidBeginEditing:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidBeginEditing:")]
        void PaymentCardTextFieldDidBeginEditing(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldWillEndEditingForReturn:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldWillEndEditingForReturn:")]
        void PaymentCardTextFieldWillEndEditingForReturn(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidEndEditing:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidEndEditing:")]
        void PaymentCardTextFieldDidEndEditing(STPPaymentCardTextField textField);

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

        // @optional -(void)paymentCardTextFieldDidBeginEditingPostalCode:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidBeginEditingPostalCode:")]
        void PaymentCardTextFieldDidBeginEditingPostalCode(STPPaymentCardTextField textField);

        // @optional -(void)paymentCardTextFieldDidEndEditingPostalCode:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidEndEditingPostalCode:")]
        void PaymentCardTextFieldDidEndEditingPostalCode(STPPaymentCardTextField textField);
    }

    // @interface STPCoreViewController : UIViewController
    [BaseType(typeof(UIViewController), Name = "_TtC6Stripe21STPCoreViewController")]
    interface STPCoreViewController
    {
        // -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nullable)theme __attribute__((objc_designated_initializer));
        [Export("initWithTheme:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] STPTheme theme);

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        // // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        // [Export ("initWithCoder:")]
        // [DesignatedInitializer]
        // IntPtr Constructor (NSCoder aDecoder);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillAppear:(BOOL)animated;
        [Export("viewWillAppear:")]
        void ViewWillAppear(bool animated);

        // -(void)viewWillDisappear:(BOOL)animated;
        [Export("viewWillDisappear:")]
        void ViewWillDisappear(bool animated);

        // @property (readonly, nonatomic) UIStatusBarStyle preferredStatusBarStyle;
        [Export("preferredStatusBarStyle")]
        UIStatusBarStyle PreferredStatusBarStyle { get; }
    }

    // @interface STPCoreScrollViewController : STPCoreViewController
    [BaseType(typeof(STPCoreViewController), Name = "_TtC6Stripe27STPCoreScrollViewController")]
    interface STPCoreScrollViewController
    {
        // @property (nonatomic, strong) UIScrollView * _Nonnull scrollView;
        [Export("scrollView", ArgumentSemantic.Strong)]
        UIScrollView ScrollView { get; set; }

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewDidLayoutSubviews;
        [Export("viewDidLayoutSubviews")]
        void ViewDidLayoutSubviews();

        // -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nullable)theme __attribute__((objc_designated_initializer));
        [Export("initWithTheme:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] STPTheme theme);

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        // // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        // [Export ("initWithCoder:")]
        // [DesignatedInitializer]
        // IntPtr Constructor (NSCoder aDecoder);
    }

    // @interface STPCoreTableViewController : STPCoreScrollViewController
    [BaseType(typeof(STPCoreScrollViewController), Name = "_TtC6Stripe26STPCoreTableViewController")]
    interface STPCoreTableViewController
    {
        // @property (readonly, nonatomic, strong) UITableView * _Nullable tableView;
        [NullAllowed, Export("tableView", ArgumentSemantic.Strong)]
        UITableView TableView { get; }

        // -(void)viewWillAppear:(BOOL)animated;
        [Export("viewWillAppear:")]
        void ViewWillAppear(bool animated);

        //// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export ("tableView:heightForHeaderInSection:")]
        //nfloat TableView (UITableView tableView, nint section);

        // -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nullable)theme __attribute__((objc_designated_initializer));
        [Export("initWithTheme:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] STPTheme theme);

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        // // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        // [Export ("initWithCoder:")]
        // [DesignatedInitializer]
        // IntPtr Constructor (NSCoder aDecoder);
    }

    // @interface STPAddCardViewController : STPCoreTableViewController <STPPaymentCardTextFieldDelegate, UITableViewDataSource, UITableViewDelegate>
    [BaseType(typeof(STPCoreTableViewController), Name = "_TtC6Stripe24STPAddCardViewController")]
    interface STPAddCardViewController : STPPaymentCardTextFieldDelegate, IUITableViewDataSource, IUITableViewDelegate
    {
        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme __attribute__((objc_designated_initializer));
        [Export("initWithConfiguration:theme:")]
        [DesignatedInitializer]
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

        // @property (nonatomic, strong) UIView * _Nullable customFooterView;
        [NullAllowed, Export("customFooterView", ArgumentSemantic.Strong)]
        UIView CustomFooterView { get; set; }

        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }

        // -(CGFloat)tableView:(UITableView * _Nonnull)tableView estimatedHeightForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
        [Export("tableView:estimatedHeightForRowAtIndexPath:")]
        nfloat TableView(UITableView tableView, NSIndexPath indexPath);

        // -(void)viewDidLayoutSubviews;
        [Export("viewDidLayoutSubviews")]
        void ViewDidLayoutSubviews();

        // -(void)updateAppearance;
        [Export("updateAppearance")]
        void UpdateAppearance();

        // -(void)viewDidAppear:(BOOL)animated;
        [Export("viewDidAppear:")]
        void ViewDidAppear(bool animated);

        // -(void)handleCancelTapped:(id _Nullable)sender;
        [Export("handleCancelTapped:")]
        void HandleCancelTapped([NullAllowed] NSObject sender);

        // -(void)paymentCardTextFieldDidChange:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidChange:")]
        void PaymentCardTextFieldDidChange(STPPaymentCardTextField textField);

        // -(void)paymentCardTextFieldWillEndEditingForReturn:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldWillEndEditingForReturn:")]
        void PaymentCardTextFieldWillEndEditingForReturn(STPPaymentCardTextField textField);

        // -(void)paymentCardTextFieldDidBeginEditingCVC:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidBeginEditingCVC:")]
        void PaymentCardTextFieldDidBeginEditingCVC(STPPaymentCardTextField textField);

        // -(void)paymentCardTextFieldDidEndEditingCVC:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidEndEditingCVC:")]
        void PaymentCardTextFieldDidEndEditingCVC(STPPaymentCardTextField textField);

        // -(void)paymentCardTextFieldDidBeginEditing:(STPPaymentCardTextField * _Nonnull)textField;
        [Export("paymentCardTextFieldDidBeginEditing:")]
        void PaymentCardTextFieldDidBeginEditing(STPPaymentCardTextField textField);

        // -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
        [Export("numberOfSectionsInTableView:")]
        nint NumberOfSectionsInTableView(UITableView tableView);

        // -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        [Export("tableView:numberOfRowsInSection:")]
        nint TableView(UITableView tableView, nint section);

        //// -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
        //[Export("tableView:cellForRowAtIndexPath:")]
        //UITableViewCell TableView(UITableView tableView, NSIndexPath indexPath);

        // -(void)tableView:(UITableView * _Nonnull)tableView willDisplayCell:(UITableViewCell * _Nonnull)cell forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:willDisplayCell:forRowAtIndexPath:")]
        void TableView(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath);

        //// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:heightForFooterInSection:")]
        //nfloat TableView(UITableView tableView, nint section);

        //// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:heightForHeaderInSection:")]
        //nfloat TableView(UITableView tableView, nint section);

        //// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:viewForHeaderInSection:")]
        //[return: NullAllowed]
        //UIView TableView(UITableView tableView, nint section);

        //// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:viewForFooterInSection:")]
        //[return: NullAllowed]
        //UIView TableView(UITableView tableView, nint section);

        // -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
        [Export("viewWillTransitionToSize:withTransitionCoordinator:")]
        void ViewWillTransitionToSize(CGSize size, IUIViewControllerTransitionCoordinator coordinator);
    }

    // @protocol STPAddCardViewControllerDelegate <NSObject>
    [Protocol(Name = "_TtP6Stripe32STPAddCardViewControllerDelegate_"), Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe32STPAddCardViewControllerDelegate_")]
    interface STPAddCardViewControllerDelegate
    {
        // @required -(void)addCardViewControllerDidCancel:(STPAddCardViewController * _Nonnull)addCardViewController;
        [Abstract]
        [Export("addCardViewControllerDidCancel:")]
        void AddCardViewControllerDidCancel(STPAddCardViewController addCardViewController);

        // @required -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreatePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nonnull)(NSError * _Nullable))completion;
        [Abstract]
        [Export("addCardViewController:didCreatePaymentMethod:completion:")]
        void AddCardViewController(STPAddCardViewController addCardViewController, STPPaymentMethod paymentMethod, Action<NSError> completion);

        // @optional -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreateToken:(STPToken * _Nonnull)token completion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((deprecated("Use addCardViewController(_:didCreatePaymentMethod:completion:) instead and migrate your integration to PaymentIntents. See https://stripe.com/docs/payments/payment-intents/migration/charges#read", "addCardViewController:didCreatePaymentMethod:completion:")));
        [Export("addCardViewController:didCreateToken:completion:")]
        void AddCardViewController(STPAddCardViewController addCardViewController, STPToken token, Action<NSError> completion);

        // @optional -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreateSource:(STPSource * _Nonnull)source completion:(void (^ _Nonnull)(NSError * _Nullable))completion __attribute__((deprecated("Use addCardViewController(_:didCreatePaymentMethod:completion:) instead and migrate your integration to PaymentIntents. See https://stripe.com/docs/payments/payment-intents/migration/charges#read", "addCardViewController:didCreatePaymentMethod:completion:")));
        [Export("addCardViewController:didCreateSource:completion:")]
        void AddCardViewController(STPAddCardViewController addCardViewController, STPSource source, Action<NSError> completion);
    }

    // @interface STPAddress : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe10STPAddress")]
    partial interface STPAddress
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

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSDictionary * _Nullable)shippingInfoForChargeWithAddress:(STPAddress * _Nullable)address shippingMethod:(PKShippingMethod * _Nullable)method __attribute__((warn_unused_result("")));
        [Static]
        [Export("shippingInfoForChargeWithAddress:shippingMethod:")]
        [return: NullAllowed]
        NSDictionary ShippingInfoForChargeWithAddress([NullAllowed] STPAddress address, [NullAllowed] PKShippingMethod method);

        // -(instancetype _Nonnull)initWithPaymentMethodBillingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails __attribute__((objc_designated_initializer));
        [Export("initWithPaymentMethodBillingDetails:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPPaymentMethodBillingDetails billingDetails);

        // -(instancetype _Nonnull)initWithPKContact:(PKContact * _Nonnull)contact __attribute__((objc_designated_initializer));
        [Export("initWithPKContact:")]
        [DesignatedInitializer]
        IntPtr Constructor(PKContact contact);

        // -(PKContact * _Nonnull)PKContactValue __attribute__((warn_unused_result("")));
        [Export("PKContactValue")]
        PKContact PKContactValue { get; }

        // -(instancetype _Nonnull)initWithCNContact:(CNContact * _Nonnull)contact __attribute__((objc_designated_initializer));
        [Export("initWithCNContact:")]
        [DesignatedInitializer]
        IntPtr Constructor(CNContact contact);

        // -(BOOL)containsRequiredFields:(enum STPBillingAddressFields)requiredFields __attribute__((warn_unused_result("")));
        [Export("containsRequiredFields:")]
        bool ContainsRequiredFields(STPBillingAddressFields requiredFields);

        // -(BOOL)containsContentForBillingAddressFields:(enum STPBillingAddressFields)desiredFields __attribute__((warn_unused_result("")));
        [Export("containsContentForBillingAddressFields:")]
        bool ContainsContentForBillingAddressFields(STPBillingAddressFields desiredFields);

        // -(BOOL)containsRequiredShippingAddressFields:(NSSet<STPContactField *> * _Nullable)requiredFields __attribute__((warn_unused_result("")));
        [Export("containsRequiredShippingAddressFields:")]
        bool ContainsRequiredShippingAddressFields([NullAllowed] NSSet requiredFields);

        // -(BOOL)containsContentForShippingAddressFields:(NSSet<STPContactField *> * _Nullable)desiredFields __attribute__((warn_unused_result("")));
        [Export("containsContentForShippingAddressFields:")]
        bool ContainsContentForShippingAddressFields([NullAllowed] NSSet desiredFields);

        // +(NSSet<PKContactField> * _Nonnull)applePayContactFieldsFromBillingAddressFields:(enum STPBillingAddressFields)billingAddressFields __attribute__((warn_unused_result("")));
        [Static]
        [Export("applePayContactFieldsFromBillingAddressFields:")]
        NSSet<NSString> ApplePayContactFieldsFromBillingAddressFields(STPBillingAddressFields billingAddressFields);

        // +(NSSet<PKContactField> * _Nullable)pkContactFieldsFromStripeContactFields:(NSSet<STPContactField *> * _Nullable)contactFields __attribute__((warn_unused_result("")));
        [Static]
        [Export("pkContactFieldsFromStripeContactFields:")]
        [return: NullAllowed]
        NSSet<NSString> PkContactFieldsFromStripeContactFields([NullAllowed] NSSet contactFields);

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }
    }

    // @interface Stripe_Swift_738 (STPAddress) <NSCopying>
    // [Category]
    // [BaseType (typeof(STPAddress))]
    partial interface STPAddress : INSCopying
    {
        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // @interface Stripe_Swift_744 (STPAddress) <STPAPIResponseDecodable>
    // [Category]
    // [BaseType (typeof(STPAddress))]
    partial interface STPAddress //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPAddress DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @protocol STPFormEncodable <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe16STPFormEncodable_")]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe16STPFormEncodable_")]
    interface STPFormEncodable
    {
        // @required +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [Abstract, NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // @required +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // @required @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Abstract]
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }
    }

    // @interface Stripe_Swift_765 (STPAddress) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPAddress))]
    partial interface STPAddress : STPFormEncodable
    {
        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @protocol _stpinternal_apContextDelegate
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface _stpinternal_apContextDelegate
    {
        // @required -(void)applePayContext:(_stpinternal_APContextSwift * _Nonnull)context didCreatePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod paymentInformation:(PKPayment * _Nonnull)paymentInformation completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("applePayContext:didCreatePaymentMethod:paymentInformation:completion:")]
        void DidCreatePaymentMethod(_stpinternal_APContextSwift context, STPPaymentMethod paymentMethod, PKPayment paymentInformation, Action<NSString, NSError> completion);

        // @required -(void)applePayContext:(_stpinternal_APContextSwift * _Nonnull)context didCompleteWithStatus:(enum STPPaymentStatus)status error:(NSError * _Nullable)error;
        [Abstract]
        [Export("applePayContext:didCompleteWithStatus:error:")]
        void DidCompleteWithStatus(_stpinternal_APContextSwift context, STPPaymentStatus status, [NullAllowed] NSError error);
    }

    // @protocol STPPaymentOption <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe16STPPaymentOption_")]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe16STPPaymentOption_")]
    interface STPPaymentOption
    {
        // @required @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
        [Abstract]
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @required @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
        [Abstract]
        [Export("templateImage", ArgumentSemantic.Strong)]
        UIImage TemplateImage { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull label;
        [Abstract]
        [Export("label")]
        string Label { get; }

        // @required @property (readonly, nonatomic) BOOL isReusable;
        [Abstract]
        [Export("isReusable")]
        bool IsReusable { get; }
    }

    // @interface STPApplePayPaymentOption : NSObject <STPPaymentOption>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe24STPApplePayPaymentOption")]
    interface STPApplePayPaymentOption : STPPaymentOption
    {
        // @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
        [Export("templateImage", ArgumentSemantic.Strong)]
        UIImage TemplateImage { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull label;
        [Export("label")]
        string Label { get; }

        // @property (readonly, nonatomic) BOOL isReusable;
        [Export("isReusable")]
        bool IsReusable { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }
    }

    // @protocol STPAuthenticationContext <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe24STPAuthenticationContext_")]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe24STPAuthenticationContext_")]
    interface STPAuthenticationContext
    {
        // @required -(UIViewController * _Nonnull)authenticationPresentingViewController __attribute__((warn_unused_result("")));
        [Abstract]
        [Export("authenticationPresentingViewController")]
        UIViewController AuthenticationPresentingViewController { get; }

        // @optional -(void)prepareAuthenticationContextForPresentation:(void (^ _Nonnull)(void))completion;
        [Export("prepareAuthenticationContextForPresentation:")]
        void PrepareAuthenticationContextForPresentation(Action completion);

        // @optional -(void)configureSafariViewController:(SFSafariViewController * _Nonnull)viewController;
        [Export("configureSafariViewController:")]
        void ConfigureSafariViewController(SFSafariViewController viewController);

        // @optional -(void)authenticationContextWillDismissViewController:(UIViewController * _Nonnull)viewController;
        [Export("authenticationContextWillDismissViewController:")]
        void AuthenticationContextWillDismissViewController(UIViewController viewController);
    }

    // @protocol STPBackendAPIAdapter <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe20STPBackendAPIAdapter_")]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe20STPBackendAPIAdapter_")]
    interface STPBackendAPIAdapter
    {
        // @required -(void)retrieveCustomer:(void (^ _Nullable)(STPCustomer * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("retrieveCustomer:")]
        void RetrieveCustomer([NullAllowed] Action<STPCustomer, NSError> completion);

        // @required -(void)listPaymentMethodsForCustomerWithCompletion:(void (^ _Nullable)(NSArray<STPPaymentMethod *> * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("listPaymentMethodsForCustomerWithCompletion:")]
        void ListPaymentMethodsForCustomerWithCompletion([NullAllowed] Action<NSArray, NSError> completion);

        // @required -(void)attachPaymentMethodToCustomer:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Abstract]
        [Export("attachPaymentMethodToCustomer:completion:")]
        void AttachPaymentMethodToCustomer(STPPaymentMethod paymentMethod, [NullAllowed] Action<NSError> completion);

        // @optional -(void)detachPaymentMethodFromCustomer:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("detachPaymentMethodFromCustomer:completion:")]
        void DetachPaymentMethodFromCustomer(STPPaymentMethod paymentMethod, [NullAllowed] Action<NSError> completion);

        // @optional -(void)updateCustomerWithShippingAddress:(STPAddress * _Nonnull)shipping completion:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("updateCustomerWithShippingAddress:completion:")]
        void UpdateCustomerWithShippingAddress(STPAddress shipping, [NullAllowed] Action<NSError> completion);
    }

    // @protocol STPSourceProtocol <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe17STPSourceProtocol_")]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe17STPSourceProtocol_")]
    interface STPSourceProtocol
    {
        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
        [Abstract]
        [Export("stripeID")]
        string StripeID { get; }
    }

    // @interface STPBankAccount : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe14STPBankAccount")]
    [DisableDefaultCtor]
    interface STPBankAccount : /*STPAPIResponseDecodable,*/ STPSourceProtocol
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable routingNumber;
        [NullAllowed, Export("routingNumber")]
        string RoutingNumber { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable bankName;
        [NullAllowed, Export("bankName")]
        string BankName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable accountHolderName;
        [NullAllowed, Export("accountHolderName")]
        string AccountHolderName { get; }

        // @property (readonly, nonatomic) enum STPBankAccountHolderType accountHolderType;
        [Export("accountHolderType")]
        STPBankAccountHolderType AccountHolderType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
        [NullAllowed, Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, nonatomic) enum STPBankAccountStatus status;
        [Export("status")]
        STPBankAccountStatus Status { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use stripeID (defined in STPSourceProtocol)") NSString * bankAccountId __attribute__((deprecated("Use stripeID (defined in STPSourceProtocol)")));
        [Export("bankAccountId")]
        string BankAccountId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
        [Export("stripeID")]
        string StripeID { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // -(BOOL)isEqual:(id _Nullable)bankAccount __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject bankAccount);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPBankAccount DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPBankAccountCollector : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPBankAccountCollector")]
    interface STPBankAccountCollector
    {
        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }

        // -(instancetype _Nonnull)initWithAPIClient:(STPAPIClient * _Nonnull)apiClient;
        [Export("initWithAPIClient:")]
        IntPtr Constructor(STPAPIClient apiClient);

        // -(void)collectBankAccountForPaymentWithClientSecret:(NSString * _Nonnull)clientSecret params:(STPCollectBankAccountParams * _Nonnull)params from:(UIViewController * _Nonnull)viewController completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion __attribute__((availability(ios, introduced=12)));
        [iOS(12, 0)]
        [Export("collectBankAccountForPaymentWithClientSecret:params:from:completion:")]
        void CollectBankAccountForPaymentWithClientSecret(string clientSecret, STPCollectBankAccountParams @params, UIViewController viewController, Action<STPPaymentIntent, NSError> completion);

        // -(void)collectBankAccountForSetupWithClientSecret:(NSString * _Nonnull)clientSecret params:(STPCollectBankAccountParams * _Nonnull)params from:(UIViewController * _Nonnull)viewController completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion __attribute__((availability(ios, introduced=12)));
        [iOS(12, 0)]
        [Export("collectBankAccountForSetupWithClientSecret:params:from:completion:")]
        void CollectBankAccountForSetupWithClientSecret(string clientSecret, STPCollectBankAccountParams @params, UIViewController viewController, Action<STPSetupIntent, NSError> completion);
    }

    // @interface STPBankAccountParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe20STPBankAccountParams")]
    interface STPBankAccountParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSString * _Nullable accountNumber;
        [NullAllowed, Export("accountNumber")]
        string AccountNumber { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable last4;
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

        // @property (nonatomic) enum STPBankAccountHolderType accountHolderType;
        [Export("accountHolderType", ArgumentSemantic.Assign)]
        STPBankAccountHolderType AccountHolderType { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPBankSelectionViewController : STPCoreTableViewController <UITableViewDataSource, UITableViewDelegate>
    [BaseType(typeof(STPCoreTableViewController), Name = "_TtC6Stripe30STPBankSelectionViewController")]
    interface STPBankSelectionViewController : IUITableViewDataSource, IUITableViewDelegate
    {
        // -(instancetype _Nonnull)initWithBankMethod:(enum STPBankSelectionMethod)bankMethod;
        [Export("initWithBankMethod:")]
        IntPtr Constructor(STPBankSelectionMethod bankMethod);

        // -(instancetype _Nonnull)initWithTheme:(STPTheme * _Nullable)theme;
        [Export("initWithTheme:")]
        IntPtr Constructor([NullAllowed] STPTheme theme);

        // -(instancetype _Nonnull)initWithBankMethod:(enum STPBankSelectionMethod)bankMethod configuration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme __attribute__((objc_designated_initializer));
        [Export("initWithBankMethod:configuration:theme:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPBankSelectionMethod bankMethod, STPPaymentConfiguration configuration, STPTheme theme);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPBankSelectionViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<STPBankSelectionViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }

        // -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
        [Export("numberOfSectionsInTableView:")]
        nint NumberOfSectionsInTableView(UITableView tableView);

        // -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        [Export("tableView:numberOfRowsInSection:")]
        nint TableView(UITableView tableView, nint section);

        // -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
        [Export("tableView:cellForRowAtIndexPath:")]
        UITableViewCell TableView(UITableView tableView, NSIndexPath indexPath);

        // -(void)tableView:(UITableView * _Nonnull)tableView willDisplayCell:(UITableViewCell * _Nonnull)cell forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:willDisplayCell:forRowAtIndexPath:")]
        void TableView(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath);

        //// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:heightForFooterInSection:")]
        //nfloat TableView(UITableView tableView, nint section);

        //// -(BOOL)tableView:(UITableView * _Nonnull)tableView shouldHighlightRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
        //[Export("tableView:shouldHighlightRowAtIndexPath:")]
        //bool TableView(UITableView tableView, NSIndexPath indexPath);

        //// -(void)tableView:(UITableView * _Nonnull)tableView didSelectRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        //[Export("tableView:didSelectRowAtIndexPath:")]
        //void TableView(UITableView tableView, NSIndexPath indexPath);
    }

    // @protocol STPBankSelectionViewControllerDelegate <NSObject>
    [Protocol(Name = "_TtP6Stripe38STPBankSelectionViewControllerDelegate_"), Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe38STPBankSelectionViewControllerDelegate_")]
    interface STPBankSelectionViewControllerDelegate
    {
        // @required -(void)bankSelectionViewController:(STPBankSelectionViewController * _Nonnull)bankViewController didCreatePaymentMethodParams:(STPPaymentMethodParams * _Nonnull)paymentMethodParams;
        [Abstract]
        [Export("bankSelectionViewController:didCreatePaymentMethodParams:")]
        void DidCreatePaymentMethodParams(STPBankSelectionViewController bankViewController, STPPaymentMethodParams paymentMethodParams);
    }

    // @interface STPCard : NSObject <STPAPIResponseDecodable, STPPaymentOption, STPSourceProtocol>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe7STPCard")]
    [DisableDefaultCtor]
    interface STPCard : /*STPAPIResponseDecodable,*/ STPPaymentOption, STPSourceProtocol
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull last4;
        [Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable dynamicLast4;
        [NullAllowed, Export("dynamicLast4")]
        string DynamicLast4 { get; }

        // @property (readonly, nonatomic) BOOL isApplePayCard;
        [Export("isApplePayCard")]
        bool IsApplePayCard { get; }

        // @property (readonly, nonatomic) NSInteger expMonth;
        [Export("expMonth")]
        nint ExpMonth { get; }

        // @property (readonly, nonatomic) NSInteger expYear;
        [Export("expYear")]
        nint ExpYear { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic, strong) STPAddress * _Nullable address;
        [NullAllowed, Export("address", ArgumentSemantic.Strong)]
        STPAddress Address { get; }

        // @property (readonly, nonatomic) enum STPCardBrand brand;
        [Export("brand")]
        STPCardBrand Brand { get; }

        // @property (readonly, nonatomic) enum STPCardFundingType funding;
        [Export("funding")]
        STPCardFundingType Funding { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; }

        // +(NSString * _Nonnull)stringFromBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("stringFromBrand:")]
        string StringFromBrand(STPCardBrand brand);

        // +(enum STPCardBrand)brandFromString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
        [Static]
        [Export("brandFromString:")]
        STPCardBrand BrandFromString(string @string);

        // -(instancetype _Nonnull)initWithID:(NSString * _Nonnull)cardID brand:(enum STPCardBrand)brand last4:(NSString * _Nonnull)last4 expMonth:(NSInteger)expMonth expYear:(NSInteger)expYear funding:(enum STPCardFundingType)funding __attribute__((objc_designated_initializer)) __attribute__((deprecated("You cannot directly instantiate an STPCard. You should only use one that has been returned from an STPAPIClient callback.")));
        [Export("initWithID:brand:last4:expMonth:expYear:funding:")]
        [DesignatedInitializer]
        IntPtr Constructor(string cardID, STPCardBrand brand, string last4, nint expMonth, nint expYear, STPCardFundingType funding);

        // +(enum STPCardFundingType)fundingFromString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
        [Static]
        [Export("fundingFromString:")]
        STPCardFundingType FundingFromString(string @string);

        // @property (copy, nonatomic) NSString * _Nonnull stripeID;
        [Export("stripeID")]
        string StripeID { get; set; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // -(BOOL)isEqual:(id _Nullable)other __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject other);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPCard DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
        [Export("templateImage", ArgumentSemantic.Strong)]
        UIImage TemplateImage { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull label;
        [Export("label")]
        string Label { get; }

        // @property (readonly, nonatomic) BOOL isReusable;
        [Export("isReusable")]
        bool IsReusable { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using yoursecret key instead.") NSDictionary<NSString *,NSString *> * metadata __attribute__((deprecated("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using yoursecret key instead.")));
        [Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Metadata { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use stripeID (defined in STPSourceProtocol)") NSString * cardId __attribute__((deprecated("Use stripeID (defined in STPSourceProtocol)")));
        [Export("cardId")]
        string CardId { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.line1") NSString * addressLine1 __attribute__((deprecated("Use address.line1")));
        [Export("addressLine1")]
        string AddressLine1 { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.line2") NSString * addressLine2 __attribute__((deprecated("Use address.line2")));
        [Export("addressLine2")]
        string AddressLine2 { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.city") NSString * addressCity __attribute__((deprecated("Use address.city")));
        [Export("addressCity")]
        string AddressCity { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.state") NSString * addressState __attribute__((deprecated("Use address.state")));
        [Export("addressState")]
        string AddressState { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.postalCode") NSString * addressZip __attribute__((deprecated("Use address.postalCode")));
        [Export("addressZip")]
        string AddressZip { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Use address.country") NSString * addressCountry __attribute__((deprecated("Use address.country")));
        [Export("addressCountry")]
        string AddressCountry { get; }
    }

    // @interface STPCardBrandUtilities : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe21STPCardBrandUtilities")]
    interface STPCardBrandUtilities
    {
        // +(NSString * _Nullable)stringFromCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("stringFromCardBrand:")]
        [return: NullAllowed]
        string StringFromCardBrand(STPCardBrand brand);
    }

    // @interface STPFormView : UIView
    [BaseType(typeof(UIView), Name = "_TtC6Stripe11STPFormView")]
    interface STPFormView
    {
        // @property (readonly, nonatomic) BOOL canResignFirstResponder;
        [Export("canResignFirstResponder")]
        bool CanResignFirstResponder { get; }

        // -(BOOL)resignFirstResponder __attribute__((warn_unused_result("")));
        [Export("resignFirstResponder")]
        bool ResignFirstResponder();

        // @property (readonly, nonatomic) BOOL isFirstResponder;
        [Export("isFirstResponder")]
        bool IsFirstResponder { get; }

        // @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
        [Export("canBecomeFirstResponder")]
        bool CanBecomeFirstResponder { get; }

        // -(BOOL)becomeFirstResponder __attribute__((warn_unused_result("")));
        [Export("becomeFirstResponder")]
        bool BecomeFirstResponder();

        // @property (getter = isUserInteractionEnabled, nonatomic) BOOL userInteractionEnabled;
        [Export("userInteractionEnabled")]
        bool UserInteractionEnabled { [Bind("isUserInteractionEnabled")] get; set; }
    }

    // @interface STPCardFormView : STPFormView
    [BaseType(typeof(STPFormView), Name = "_TtC6Stripe15STPCardFormView")]
    interface STPCardFormView
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPCardFormViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<STPCardFormViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable disabledBackgroundColor;
        [NullAllowed, Export("disabledBackgroundColor", ArgumentSemantic.Strong)]
        UIColor DisabledBackgroundColor { get; set; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodParams * _Nullable cardParams;
        [NullAllowed, Export("cardParams", ArgumentSemantic.Strong)]
        STPPaymentMethodParams CardParams { get; }

        // @property (getter = isUserInteractionEnabled, nonatomic) BOOL userInteractionEnabled;
        [Export("userInteractionEnabled")]
        bool UserInteractionEnabled { [Bind("isUserInteractionEnabled")] get; set; }

        // -(instancetype _Nonnull)initWithStyle:(enum STPCardFormViewStyle)style;
        [Export("initWithStyle:")]
        IntPtr Constructor(STPCardFormViewStyle style);
    }

    // @interface Stripe_Swift_1420 (STPCardFormView)
    // [Unavailable (PlatformName.iOSAppExtension)]
    [iOS(13, 0)]
    [Category]
    [BaseType(typeof(STPCardFormView))]
    interface STPCardFormView_Stripe_Swift_1420
    {
    }

    // @protocol STPCardFormViewDelegate <NSObject>
    [Protocol(Name = "_TtP6Stripe23STPCardFormViewDelegate_"), Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe23STPCardFormViewDelegate_")]
    interface STPCardFormViewDelegate
    {
        // @required -(void)cardFormView:(STPCardFormView * _Nonnull)form didChangeToStateComplete:(BOOL)complete;
        [Abstract]
        [Export("cardFormView:didChangeToStateComplete:")]
        void DidChangeToStateComplete(STPCardFormView form, bool complete);
    }

    // @interface STPCardParams : NSObject <NSCopying, STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe13STPCardParams")]
    interface STPCardParams : INSCopying, STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(instancetype _Nonnull)initWithPaymentMethodParams:(STPPaymentMethodParams * _Nonnull)paymentMethodParams;
        [Export("initWithPaymentMethodParams:")]
        IntPtr Constructor(STPPaymentMethodParams paymentMethodParams);

        // @property (copy, nonatomic) NSString * _Nullable number;
        [NullAllowed, Export("number")]
        string Number { get; set; }

        // -(NSString * _Nullable)last4 __attribute__((warn_unused_result("")));
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

        // @property (nonatomic, strong) STPAddress * _Nonnull address;
        [Export("address", ArgumentSemantic.Strong)]
        STPAddress Address { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; set; }

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

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // @interface STPCardValidator : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe16STPCardValidator")]
    interface STPCardValidator
    {
        // +(NSString * _Nonnull)sanitizedNumericStringForString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
        [Static]
        [Export("sanitizedNumericStringForString:")]
        string SanitizedNumericStringForString(string @string);

        // +(NSString * _Nonnull)sanitizedPostalStringForString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
        [Static]
        [Export("sanitizedPostalStringForString:")]
        string SanitizedPostalStringForString(string @string);

        // +(BOOL)stringIsNumeric:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
        [Static]
        [Export("stringIsNumeric:")]
        bool StringIsNumeric(string @string);

        // +(enum STPCardValidationState)validationStateForNumber:(NSString * _Nullable)cardNumber validatingCardBrand:(BOOL)validatingCardBrand __attribute__((warn_unused_result("")));
        [Static]
        [Export("validationStateForNumber:validatingCardBrand:")]
        STPCardValidationState ValidationStateForNumber([NullAllowed] string cardNumber, bool validatingCardBrand);

        // +(enum STPCardBrand)brandForNumber:(NSString * _Nonnull)cardNumber __attribute__((warn_unused_result("")));
        [Static]
        [Export("brandForNumber:")]
        STPCardBrand BrandForNumber(string cardNumber);

        // +(NSSet<NSNumber *> * _Nonnull)lengthsForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("lengthsForCardBrand:")]
        NSSet<NSNumber> LengthsForCardBrand(STPCardBrand brand);

        // +(NSInteger)maxLengthForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("maxLengthForCardBrand:")]
        nint MaxLengthForCardBrand(STPCardBrand brand);

        // +(NSInteger)fragmentLengthForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("fragmentLengthForCardBrand:")]
        nint FragmentLengthForCardBrand(STPCardBrand brand);

        // +(enum STPCardValidationState)validationStateForExpirationMonth:(NSString * _Nonnull)expirationMonth __attribute__((warn_unused_result("")));
        [Static]
        [Export("validationStateForExpirationMonth:")]
        STPCardValidationState ValidationStateForExpirationMonth(string expirationMonth);

        // +(enum STPCardValidationState)validationStateForExpirationYear:(NSString * _Nonnull)expirationYear inMonth:(NSString * _Nonnull)expirationMonth __attribute__((warn_unused_result("")));
        [Static]
        [Export("validationStateForExpirationYear:inMonth:")]
        STPCardValidationState ValidationStateForExpirationYear(string expirationYear, string expirationMonth);

        // +(NSUInteger)maxCVCLengthForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("maxCVCLengthForCardBrand:")]
        nuint MaxCVCLengthForCardBrand(STPCardBrand brand);

        // +(enum STPCardValidationState)validationStateForCVC:(NSString * _Nonnull)cvc cardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("validationStateForCVC:cardBrand:")]
        STPCardValidationState ValidationStateForCVC(string cvc, STPCardBrand brand);

        // +(enum STPCardValidationState)validationStateForCard:(STPCardParams * _Nonnull)card __attribute__((warn_unused_result("")));
        [Static]
        [Export("validationStateForCard:")]
        STPCardValidationState ValidationStateForCard(STPCardParams card);
    }

    // @interface STPCollectBankAccountParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe27STPCollectBankAccountParams")]
    [DisableDefaultCtor]
    interface STPCollectBankAccountParams
    {
        // +(STPCollectBankAccountParams * _Nonnull)collectUSBankAccountParamsWithName:(NSString * _Nonnull)name email:(NSString * _Nullable)email __attribute__((warn_unused_result("")));
        [Static]
        [Export("collectUSBankAccountParamsWithName:email:")]
        STPCollectBankAccountParams CollectUSBankAccountParamsWithName(string name, [NullAllowed] string email);
    }

    // @interface STPConfirmAlipayOptions : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPConfirmAlipayOptions")]
    partial interface STPConfirmAlipayOptions
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull appBundleID;
        [Export("appBundleID")]
        string AppBundleID { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull appVersionKey;
        [Export("appVersionKey")]
        string AppVersionKey { get; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_1718 (STPConfirmAlipayOptions) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConfirmAlipayOptions))]
    partial interface STPConfirmAlipayOptions : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConfirmBLIKOptions : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe21STPConfirmBLIKOptions")]
    [DisableDefaultCtor]
    partial interface STPConfirmBLIKOptions
    {
        // @property (copy, nonatomic) NSString * _Nonnull code;
        [Export("code")]
        string Code { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(instancetype _Nonnull)initWithCode:(NSString * _Nonnull)code __attribute__((objc_designated_initializer));
        [Export("initWithCode:")]
        [DesignatedInitializer]
        IntPtr Constructor(string code);
    }

    // // @interface Stripe_Swift_1743 (STPConfirmBLIKOptions) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConfirmBLIKOptions))]
    partial interface STPConfirmBLIKOptions : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConfirmCardOptions : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe21STPConfirmCardOptions")]
    partial interface STPConfirmCardOptions
    {
        // @property (copy, nonatomic) NSString * _Nullable cvc;
        [NullAllowed, Export("cvc")]
        string Cvc { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable network;
        [NullAllowed, Export("network")]
        string Network { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_1766 (STPConfirmCardOptions) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConfirmCardOptions))]
    partial interface STPConfirmCardOptions : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConfirmPaymentMethodOptions : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe30STPConfirmPaymentMethodOptions")]
    partial interface STPConfirmPaymentMethodOptions
    {
        // @property (nonatomic, strong) STPConfirmCardOptions * _Nullable cardOptions;
        [NullAllowed, Export("cardOptions", ArgumentSemantic.Strong)]
        STPConfirmCardOptions CardOptions { get; set; }

        // @property (nonatomic, strong) STPConfirmAlipayOptions * _Nullable alipayOptions;
        [NullAllowed, Export("alipayOptions", ArgumentSemantic.Strong)]
        STPConfirmAlipayOptions AlipayOptions { get; set; }

        // @property (nonatomic, strong) STPConfirmBLIKOptions * _Nullable blikOptions;
        [NullAllowed, Export("blikOptions", ArgumentSemantic.Strong)]
        STPConfirmBLIKOptions BlikOptions { get; set; }

        // @property (nonatomic, strong) STPConfirmWeChatPayOptions * _Nullable weChatPayOptions;
        [NullAllowed, Export("weChatPayOptions", ArgumentSemantic.Strong)]
        STPConfirmWeChatPayOptions WeChatPayOptions { get; set; }

        // @property (nonatomic, strong) STPConfirmUSBankAccountOptions * _Nullable usBankAccountOptions;
        [NullAllowed, Export("usBankAccountOptions", ArgumentSemantic.Strong)]
        STPConfirmUSBankAccountOptions UsBankAccountOptions { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_1800 (STPConfirmPaymentMethodOptions) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConfirmPaymentMethodOptions))]
    partial interface STPConfirmPaymentMethodOptions : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConfirmUSBankAccountOptions : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe30STPConfirmUSBankAccountOptions")]
    [DisableDefaultCtor]
    partial interface STPConfirmUSBankAccountOptions
    {
        // -(instancetype _Nonnull)initWithSetupFutureUsage:(enum STPPaymentIntentSetupFutureUsage)setupFutureUsage __attribute__((objc_designated_initializer));
        [Export("initWithSetupFutureUsage:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPPaymentIntentSetupFutureUsage setupFutureUsage);

        // @property (nonatomic) enum STPPaymentIntentSetupFutureUsage setupFutureUsage;
        [Export("setupFutureUsage", ArgumentSemantic.Assign)]
        STPPaymentIntentSetupFutureUsage SetupFutureUsage { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }
    }

    // // @interface Stripe_Swift_1829 (STPConfirmUSBankAccountOptions) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConfirmUSBankAccountOptions))]
    partial interface STPConfirmUSBankAccountOptions : STPFormEncodable
    {
        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPConfirmWeChatPayOptions : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPConfirmWeChatPayOptions")]
    [DisableDefaultCtor]
    partial interface STPConfirmWeChatPayOptions
    {
        // @property (copy, nonatomic) NSString * _Nullable appId;
        [NullAllowed, Export("appId")]
        string AppId { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(instancetype _Nonnull)initWithAppId:(NSString * _Nonnull)appId __attribute__((objc_designated_initializer));
        [Export("initWithAppId:")]
        [DesignatedInitializer]
        IntPtr Constructor(string appId);
    }

    // // @interface Stripe_Swift_1856 (STPConfirmWeChatPayOptions) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConfirmWeChatPayOptions))]
    partial interface STPConfirmWeChatPayOptions : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConnectAccountAddress : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe24STPConnectAccountAddress")]
    partial interface STPConnectAccountAddress
    {
        // @property (copy, nonatomic) NSString * _Nullable city;
        [NullAllowed, Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable line1;
        [NullAllowed, Export("line1")]
        string Line1 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable line2;
        [NullAllowed, Export("line2")]
        string Line2 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable state;
        [NullAllowed, Export("state")]
        string State { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable town;
        [NullAllowed, Export("town")]
        string Town { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_1894 (STPConnectAccountAddress) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConnectAccountAddress))]
    partial interface STPConnectAccountAddress : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConnectAccountCompanyParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe30STPConnectAccountCompanyParams")]
    partial interface STPConnectAccountCompanyParams
    {
        // @property (nonatomic, strong) STPConnectAccountAddress * _Null_unspecified address;
        [Export("address", ArgumentSemantic.Strong)]
        STPConnectAccountAddress Address { get; set; }

        // @property (nonatomic, strong) STPConnectAccountAddress * _Nullable kanaAddress;
        [NullAllowed, Export("kanaAddress", ArgumentSemantic.Strong)]
        STPConnectAccountAddress KanaAddress { get; set; }

        // @property (nonatomic, strong) STPConnectAccountAddress * _Nullable kanjiAddress;
        [NullAllowed, Export("kanjiAddress", ArgumentSemantic.Strong)]
        STPConnectAccountAddress KanjiAddress { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable directorsProvided;
        [NullAllowed, Export("directorsProvided", ArgumentSemantic.Strong)]
        NSNumber DirectorsProvided { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable kanaName;
        [NullAllowed, Export("kanaName")]
        string KanaName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable kanjiName;
        [NullAllowed, Export("kanjiName")]
        string KanjiName { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable ownersProvided;
        [NullAllowed, Export("ownersProvided", ArgumentSemantic.Strong)]
        NSNumber OwnersProvided { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable taxID;
        [NullAllowed, Export("taxID")]
        string TaxID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable taxIDRegistrar;
        [NullAllowed, Export("taxIDRegistrar")]
        string TaxIDRegistrar { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable vatID;
        [NullAllowed, Export("vatID")]
        string VatID { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_1949 (STPConnectAccountCompanyParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConnectAccountCompanyParams))]
    partial interface STPConnectAccountCompanyParams : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConnectAccountIndividualParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe33STPConnectAccountIndividualParams")]
    partial interface STPConnectAccountIndividualParams
    {
        // @property (nonatomic, strong) STPConnectAccountAddress * _Nullable address;
        [NullAllowed, Export("address", ArgumentSemantic.Strong)]
        STPConnectAccountAddress Address { get; set; }

        // @property (nonatomic, strong) STPConnectAccountAddress * _Nullable kanaAddress;
        [NullAllowed, Export("kanaAddress", ArgumentSemantic.Strong)]
        STPConnectAccountAddress KanaAddress { get; set; }

        // @property (nonatomic, strong) STPConnectAccountAddress * _Nullable kanjiAddress;
        [NullAllowed, Export("kanjiAddress", ArgumentSemantic.Strong)]
        STPConnectAccountAddress KanjiAddress { get; set; }

        // @property (copy, nonatomic) NSDateComponents * _Nullable dateOfBirth;
        [NullAllowed, Export("dateOfBirth", ArgumentSemantic.Copy)]
        NSDateComponents DateOfBirth { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable firstName;
        [NullAllowed, Export("firstName")]
        string FirstName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable kanaFirstName;
        [NullAllowed, Export("kanaFirstName")]
        string KanaFirstName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable kanjiFirstName;
        [NullAllowed, Export("kanjiFirstName")]
        string KanjiFirstName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable gender;
        [NullAllowed, Export("gender")]
        string Gender { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable idNumber;
        [NullAllowed, Export("idNumber")]
        string IdNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable lastName;
        [NullAllowed, Export("lastName")]
        string LastName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable kanaLastName;
        [NullAllowed, Export("kanaLastName")]
        string KanaLastName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable kanjiLastName;
        [NullAllowed, Export("kanjiLastName")]
        string KanjiLastName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable maidenName;
        [NullAllowed, Export("maidenName")]
        string MaidenName { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nullable metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary Metadata { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable ssnLast4;
        [NullAllowed, Export("ssnLast4")]
        string SsnLast4 { get; set; }

        // @property (nonatomic, strong) STPConnectAccountIndividualVerification * _Nullable verification;
        [NullAllowed, Export("verification", ArgumentSemantic.Strong)]
        STPConnectAccountIndividualVerification Verification { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_2011 (STPConnectAccountIndividualParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConnectAccountIndividualParams))]
    partial interface STPConnectAccountIndividualParams : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConnectAccountIndividualVerification : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe39STPConnectAccountIndividualVerification")]
    partial interface STPConnectAccountIndividualVerification
    {
        // @property (nonatomic, strong) STPConnectAccountVerificationDocument * _Nullable document;
        [NullAllowed, Export("document", ArgumentSemantic.Strong)]
        STPConnectAccountVerificationDocument Document { get; set; }

        // @property (nonatomic, strong) STPConnectAccountVerificationDocument * _Nullable additionalDocument;
        [NullAllowed, Export("additionalDocument", ArgumentSemantic.Strong)]
        STPConnectAccountVerificationDocument AdditionalDocument { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }
    }

    // // @interface Stripe_Swift_2030 (STPConnectAccountIndividualVerification) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConnectAccountIndividualVerification))]
    partial interface STPConnectAccountIndividualVerification : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPConnectAccountParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPConnectAccountParams")]
    [DisableDefaultCtor]
    partial interface STPConnectAccountParams
    {
        // @property (readonly, nonatomic, strong) NSNumber * _Nullable tosShownAndAccepted;
        [NullAllowed, Export("tosShownAndAccepted", ArgumentSemantic.Strong)]
        NSNumber TosShownAndAccepted { get; }

        // @property (readonly, nonatomic) enum STPConnectAccountBusinessType businessType;
        [Export("businessType")]
        STPConnectAccountBusinessType BusinessType { get; }

        // @property (readonly, nonatomic, strong) STPConnectAccountIndividualParams * _Nullable individual;
        [NullAllowed, Export("individual", ArgumentSemantic.Strong)]
        STPConnectAccountIndividualParams Individual { get; }

        // @property (readonly, nonatomic, strong) STPConnectAccountCompanyParams * _Nullable company;
        [NullAllowed, Export("company", ArgumentSemantic.Strong)]
        STPConnectAccountCompanyParams Company { get; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(instancetype _Nullable)initWithTosShownAndAccepted:(BOOL)wasAccepted individual:(STPConnectAccountIndividualParams * _Nonnull)individual __attribute__((objc_designated_initializer));
        [Export("initWithTosShownAndAccepted:individual:")]
        [DesignatedInitializer]
        IntPtr Constructor(bool wasAccepted, STPConnectAccountIndividualParams individual);

        // -(instancetype _Nullable)initWithTosShownAndAccepted:(BOOL)wasAccepted company:(STPConnectAccountCompanyParams * _Nonnull)company __attribute__((objc_designated_initializer));
        [Export("initWithTosShownAndAccepted:company:")]
        [DesignatedInitializer]
        IntPtr Constructor(bool wasAccepted, STPConnectAccountCompanyParams company);

        // -(instancetype _Nonnull)initWithIndividual:(STPConnectAccountIndividualParams * _Nonnull)individual __attribute__((objc_designated_initializer));
        [Export("initWithIndividual:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPConnectAccountIndividualParams individual);

        // -(instancetype _Nonnull)initWithCompany:(STPConnectAccountCompanyParams * _Nonnull)company __attribute__((objc_designated_initializer));
        [Export("initWithCompany:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPConnectAccountCompanyParams company);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_2088 (STPConnectAccountParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConnectAccountParams))]
    partial interface STPConnectAccountParams : STPFormEncodable
    {
        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPConnectAccountVerificationDocument : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe37STPConnectAccountVerificationDocument")]
    partial interface STPConnectAccountVerificationDocument
    {
        // @property (copy, nonatomic) NSString * _Nullable back;
        [NullAllowed, Export("back")]
        string Back { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable front;
        [NullAllowed, Export("front")]
        string Front { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }
    }

    // // @interface Stripe_Swift_2110 (STPConnectAccountVerificationDocument) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPConnectAccountVerificationDocument))]
    partial interface STPConnectAccountVerificationDocument : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPContactField : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe15STPContactField")]
    [DisableDefaultCtor]
    interface STPContactField
    {
        // @property (readonly, nonatomic, strong, class) STPContactField * _Nonnull postalAddress;
        [Static]
        [Export("postalAddress", ArgumentSemantic.Strong)]
        STPContactField PostalAddress { get; }

        // @property (readonly, nonatomic, strong, class) STPContactField * _Nonnull emailAddress;
        [Static]
        [Export("emailAddress", ArgumentSemantic.Strong)]
        STPContactField EmailAddress { get; }

        // @property (readonly, nonatomic, strong, class) STPContactField * _Nonnull phoneNumber;
        [Static]
        [Export("phoneNumber", ArgumentSemantic.Strong)]
        STPContactField PhoneNumber { get; }

        // @property (readonly, nonatomic, strong, class) STPContactField * _Nonnull name;
        [Static]
        [Export("name", ArgumentSemantic.Strong)]
        STPContactField Name { get; }
    }

    // @interface STPCustomer : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe11STPCustomer")]
    [DisableDefaultCtor]
    partial interface STPCustomer
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
        [Export("stripeID")]
        string StripeID { get; }

        // @property (readonly, nonatomic, strong) id<STPSourceProtocol> _Nullable defaultSource;
        [NullAllowed, Export("defaultSource", ArgumentSemantic.Strong)]
        STPSourceProtocol DefaultSource { get; }

        // @property (readonly, copy, nonatomic) NSArray<id<STPSourceProtocol>> * _Nonnull sources;
        [Export("sources", ArgumentSemantic.Copy)]
        STPSourceProtocol[] Sources { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; }

        // @property (nonatomic, strong) STPAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress", ArgumentSemantic.Strong)]
        STPAddress ShippingAddress { get; set; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // -(instancetype _Nonnull)initWithStripeID:(NSString * _Nonnull)stripeID defaultSource:(id<STPSourceProtocol> _Nullable)defaultSource sources:(NSArray<id<STPSourceProtocol>> * _Nonnull)sources;
        [Export("initWithStripeID:defaultSource:sources:")]
        IntPtr Constructor(string stripeID, [NullAllowed] STPSourceProtocol defaultSource, STPSourceProtocol[] sources);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(void)updateSourcesFilteringApplePay:(BOOL)filteringApplePay;
        [Export("updateSourcesFilteringApplePay:")]
        void UpdateSourcesFilteringApplePay(bool filteringApplePay);
    }

    //// @interface Stripe_Swift_2178 (STPCustomer) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPCustomer))]
    partial interface STPCustomer //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPCustomer DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPCustomerContext : NSObject <STPBackendAPIAdapter>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe18STPCustomerContext")]
    [DisableDefaultCtor]
    interface STPCustomerContext : STPBackendAPIAdapter
    {
        // -(instancetype _Nonnull)initWithKeyProvider:(id<STPCustomerEphemeralKeyProvider> _Nonnull)keyProvider;
        [Export("initWithKeyProvider:")]
        IntPtr Constructor(STPCustomerEphemeralKeyProvider keyProvider);

        // -(instancetype _Nonnull)initWithKeyProvider:(id<STPCustomerEphemeralKeyProvider> _Nullable)keyProvider apiClient:(STPAPIClient * _Nonnull)apiClient;
        [Export("initWithKeyProvider:apiClient:")]
        IntPtr Constructor([NullAllowed] STPCustomerEphemeralKeyProvider keyProvider, STPAPIClient apiClient);

        // -(void)clearCache;
        [Export("clearCache")]
        void ClearCache();

        // @property (nonatomic) BOOL includeApplePayPaymentMethods;
        [Export("includeApplePayPaymentMethods")]
        bool IncludeApplePayPaymentMethods { get; set; }

        // -(void)retrieveCustomer:(void (^ _Nullable)(STPCustomer * _Nullable, NSError * _Nullable))completion;
        [Export("retrieveCustomer:")]
        void RetrieveCustomer([NullAllowed] Action<STPCustomer, NSError> completion);

        // -(void)updateCustomerWithShippingAddress:(STPAddress * _Nonnull)shipping completion:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("updateCustomerWithShippingAddress:completion:")]
        void UpdateCustomerWithShippingAddress(STPAddress shipping, [NullAllowed] Action<NSError> completion);

        // -(void)attachPaymentMethodToCustomerWithPaymentMethodId:(NSString * _Nonnull)paymentMethodId completion:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("attachPaymentMethodToCustomerWithPaymentMethodId:completion:")]
        void AttachPaymentMethodToCustomerWithPaymentMethodId(string paymentMethodId, [NullAllowed] Action<NSError> completion);

        // -(void)attachPaymentMethodToCustomer:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("attachPaymentMethodToCustomer:completion:")]
        void AttachPaymentMethodToCustomer(STPPaymentMethod paymentMethod, [NullAllowed] Action<NSError> completion);

        // -(void)detachPaymentMethodFromCustomerWithPaymentMethodId:(NSString * _Nonnull)paymentMethodId completion:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("detachPaymentMethodFromCustomerWithPaymentMethodId:completion:")]
        void DetachPaymentMethodFromCustomerWithPaymentMethodId(string paymentMethodId, [NullAllowed] Action<NSError> completion);

        // -(void)detachPaymentMethodFromCustomer:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nullable)(NSError * _Nullable))completion;
        [Export("detachPaymentMethodFromCustomer:completion:")]
        void DetachPaymentMethodFromCustomer(STPPaymentMethod paymentMethod, [NullAllowed] Action<NSError> completion);

        // -(void)listPaymentMethodsForCustomerWithCompletion:(void (^ _Nullable)(NSArray<STPPaymentMethod *> * _Nullable, NSError * _Nullable))completion;
        [Export("listPaymentMethodsForCustomerWithCompletion:")]
        void ListPaymentMethodsForCustomerWithCompletion([NullAllowed] Action<NSArray, NSError> completion);
    }

    // @interface STPCustomerDeserializer : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPCustomerDeserializer")]
    [DisableDefaultCtor]
    interface STPCustomerDeserializer
    {
        // @property (readonly, nonatomic, strong) STPCustomer * _Nullable customer;
        [NullAllowed, Export("customer", ArgumentSemantic.Strong)]
        STPCustomer Customer { get; }

        // @property (readonly, nonatomic) NSError * _Nullable error;
        [NullAllowed, Export("error")]
        NSError Error { get; }

        // -(instancetype _Nonnull)initWithData:(NSData * _Nullable)data urlResponse:(NSUrlResponse * _Nullable)urlResponse error:(NSError * _Nullable)error;
        [Export("initWithData:urlResponse:error:")]
        IntPtr Constructor([NullAllowed] NSData data, [NullAllowed] NSUrlResponse urlResponse, [NullAllowed] NSError error);

        // -(instancetype _Nonnull)initWithJsonResponse:(id _Nullable)json;
        [Export("initWithJsonResponse:")]
        IntPtr Constructor([NullAllowed] NSObject json);
    }

    // @protocol STPCustomerEphemeralKeyProvider <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe31STPCustomerEphemeralKeyProvider_")]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe31STPCustomerEphemeralKeyProvider_")]
    interface STPCustomerEphemeralKeyProvider
    {
        // @required -(void)createCustomerKeyWithAPIVersion:(NSString * _Nonnull)apiVersion completion:(void (^ _Nonnull)(NSDictionary * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("createCustomerKeyWithAPIVersion:completion:")]
        void Completion(string apiVersion, Action<NSDictionary, NSError> completion);
    }

    // @interface STPDateOfBirth : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe14STPDateOfBirth")]
    partial interface STPDateOfBirth
    {
        // @property (nonatomic) NSInteger day;
        [Export("day")]
        nint Day { get; set; }

        // @property (nonatomic) NSInteger month;
        [Export("month")]
        nint Month { get; set; }

        // @property (nonatomic) NSInteger year;
        [Export("year")]
        nint Year { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }
    }

    // // @interface Stripe_Swift_2321 (STPDateOfBirth) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPDateOfBirth))]
    partial interface STPDateOfBirth : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @protocol STPEphemeralKeyProvider <STPCustomerEphemeralKeyProvider>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe23STPEphemeralKeyProvider_")]
    interface STPEphemeralKeyProvider : STPCustomerEphemeralKeyProvider
    {
    }

    // @interface STPFPXBank : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe10STPFPXBank")]
    interface STPFPXBank
    {
        // +(NSString * _Nullable)stringFrom:(enum STPFPXBankBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("stringFrom:")]
        [return: NullAllowed]
        string StringFrom(STPFPXBankBrand brand);

        // +(enum STPFPXBankBrand)brandFrom:(NSString * _Nullable)identifier __attribute__((warn_unused_result("")));
        [Static]
        [Export("brandFrom:")]
        STPFPXBankBrand BrandFrom([NullAllowed] string identifier);

        // +(NSString * _Nullable)identifierFrom:(enum STPFPXBankBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("identifierFrom:")]
        [return: NullAllowed]
        string IdentifierFrom(STPFPXBankBrand brand);

        // +(NSString * _Nullable)bankCodeFrom:(enum STPFPXBankBrand)brand :(BOOL)isBusiness __attribute__((warn_unused_result("")));
        [Static]
        [Export("bankCodeFrom::")]
        [return: NullAllowed]
        string BankCodeFrom(STPFPXBankBrand brand, bool isBusiness);
    }

    // @interface STPFakeAddPaymentPassViewController : UIViewController
    [BaseType(typeof(UIViewController), Name = "_TtC6Stripe35STPFakeAddPaymentPassViewController")]
    interface STPFakeAddPaymentPassViewController
    {
        // +(BOOL)canAddPaymentPass __attribute__((warn_unused_result("")));
        [Static]
        [Export("canAddPaymentPass")]
        bool CanAddPaymentPass { get; }

        // -(instancetype _Nullable)initWithRequestConfiguration:(PKAddPaymentPassRequestConfiguration * _Nonnull)configuration delegate:(id<PKAddPaymentPassViewControllerDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
        [Export("initWithRequestConfiguration:delegate:")]
        [DesignatedInitializer]
        IntPtr Constructor(PKAddPaymentPassRequestConfiguration configuration, [NullAllowed] PKAddPaymentPassViewControllerDelegate @delegate);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        PKAddPaymentPassViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<PKAddPaymentPassViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil;
        [Export("initWithNibName:bundle:")]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder;
        //[Export("initWithCoder:")]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();
    }

    // @interface STPFile : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe7STPFile")]
    [DisableDefaultCtor]
    interface STPFile //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable fileId;
        [NullAllowed, Export("fileId")]
        string FileId { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable created;
        [NullAllowed, Export("created", ArgumentSemantic.Copy)]
        NSDate Created { get; }

        // @property (readonly, nonatomic) enum STPFilePurpose purpose;
        [Export("purpose")]
        STPFilePurpose Purpose { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable size;
        [NullAllowed, Export("size", ArgumentSemantic.Strong)]
        NSNumber Size { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable type;
        [NullAllowed, Export("type")]
        string Type { get; }

        // +(NSString * _Nullable)stringFromPurpose:(enum STPFilePurpose)purpose __attribute__((warn_unused_result("")));
        [Static]
        [Export("stringFromPurpose:")]
        [return: NullAllowed]
        string StringFromPurpose(STPFilePurpose purpose);

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPFile DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPImageLibrary : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe15STPImageLibrary")]
    interface STPImageLibrary
    {
        // +(UIImage * _Nonnull)applePayCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("applePayCardImage")]
        UIImage ApplePayCardImage { get; }

        // +(UIImage * _Nonnull)amexCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("amexCardImage")]
        UIImage AmexCardImage { get; }

        // +(UIImage * _Nonnull)dinersClubCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("dinersClubCardImage")]
        UIImage DinersClubCardImage { get; }

        // +(UIImage * _Nonnull)discoverCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("discoverCardImage")]
        UIImage DiscoverCardImage { get; }

        // +(UIImage * _Nonnull)jcbCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("jcbCardImage")]
        UIImage JcbCardImage { get; }

        // +(UIImage * _Nonnull)mastercardCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("mastercardCardImage")]
        UIImage MastercardCardImage { get; }

        // +(UIImage * _Nonnull)unionPayCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("unionPayCardImage")]
        UIImage UnionPayCardImage { get; }

        // +(UIImage * _Nonnull)visaCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("visaCardImage")]
        UIImage VisaCardImage { get; }

        // +(UIImage * _Nonnull)unknownCardCardImage __attribute__((warn_unused_result("")));
        [Static]
        [Export("unknownCardCardImage")]
        UIImage UnknownCardCardImage { get; }

        // +(UIImage * _Nonnull)brandImageForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("brandImageForCardBrand:")]
        UIImage BrandImageForCardBrand(STPCardBrand brand);

        // +(UIImage * _Nonnull)brandImageForFPXBankBrand:(enum STPFPXBankBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("brandImageForFPXBankBrand:")]
        UIImage BrandImageForFPXBankBrand(STPFPXBankBrand brand);

        // +(UIImage * _Nonnull)fpxLogo __attribute__((warn_unused_result("")));
        [Static]
        [Export("fpxLogo")]
        UIImage FpxLogo { get; }

        // +(UIImage * _Nonnull)largeFpxLogo __attribute__((warn_unused_result("")));
        [Static]
        [Export("largeFpxLogo")]
        UIImage LargeFpxLogo { get; }

        // +(UIImage * _Nonnull)afterpayLogoWithLocale:(NSLocale * _Nonnull)locale __attribute__((warn_unused_result("")));
        [Static]
        [Export("afterpayLogoWithLocale:")]
        UIImage AfterpayLogoWithLocale(NSLocale locale);

        // +(UIImage * _Nonnull)affirmLogo __attribute__((warn_unused_result("")));
        [Static]
        [Export("affirmLogo")]
        UIImage AffirmLogo { get; }

        // +(UIImage * _Nonnull)templatedBrandImageForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("templatedBrandImageForCardBrand:")]
        UIImage TemplatedBrandImageForCardBrand(STPCardBrand brand);

        // +(UIImage * _Nonnull)cvcImageForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("cvcImageForCardBrand:")]
        UIImage CvcImageForCardBrand(STPCardBrand brand);

        // +(UIImage * _Nonnull)errorImageForCardBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("errorImageForCardBrand:")]
        UIImage ErrorImageForCardBrand(STPCardBrand brand);
    }

    // @interface STPIntentAction : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe15STPIntentAction")]
    [DisableDefaultCtor]
    partial interface STPIntentAction
    {
        // @property (readonly, nonatomic) enum STPIntentActionType type;
        [Export("type")]
        STPIntentActionType Type { get; }

        // @property (readonly, nonatomic, strong) STPIntentActionRedirectToURL * _Nullable redirectToURL;
        [NullAllowed, Export("redirectToURL", ArgumentSemantic.Strong)]
        STPIntentActionRedirectToURL RedirectToURL { get; }

        // @property (readonly, nonatomic, strong) STPIntentActionOXXODisplayDetails * _Nullable oxxoDisplayDetails;
        [NullAllowed, Export("oxxoDisplayDetails", ArgumentSemantic.Strong)]
        STPIntentActionOXXODisplayDetails OxxoDisplayDetails { get; }

        // @property (readonly, nonatomic, strong) STPIntentActionAlipayHandleRedirect * _Nullable alipayHandleRedirect;
        [NullAllowed, Export("alipayHandleRedirect", ArgumentSemantic.Strong)]
        STPIntentActionAlipayHandleRedirect AlipayHandleRedirect { get; }

        // @property (readonly, nonatomic, strong) STPIntentActionWechatPayRedirectToApp * _Nullable weChatPayRedirectToApp;
        [NullAllowed, Export("weChatPayRedirectToApp", ArgumentSemantic.Strong)]
        STPIntentActionWechatPayRedirectToApp WeChatPayRedirectToApp { get; }

        // @property (readonly, nonatomic, strong) STPIntentActionBoletoDisplayDetails * _Nullable boletoDisplayDetails;
        [NullAllowed, Export("boletoDisplayDetails", ArgumentSemantic.Strong)]
        STPIntentActionBoletoDisplayDetails BoletoDisplayDetails { get; }

        // @property (readonly, nonatomic, strong) STPIntentActionVerifyWithMicrodeposits * _Nullable verifyWithMicrodeposits;
        [NullAllowed, Export("verifyWithMicrodeposits", ArgumentSemantic.Strong)]
        STPIntentActionVerifyWithMicrodeposits VerifyWithMicrodeposits { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_2574 (STPIntentAction) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPIntentAction))]
    partial interface STPIntentAction// : STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPIntentAction DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    //// @interface Stripe_Swift_2579 (STPIntentAction)
    //[Category]
    //[BaseType(typeof(STPIntentAction))]
    partial interface STPIntentAction
    {
        // @property (readonly, nonatomic, strong) SWIFT_DEPRECATED_MSG("Use `redirectToURL` instead.", "redirectToURL") STPIntentActionRedirectToURL * authorizeWithURL __attribute__((deprecated("Use `redirectToURL` instead.", "redirectToURL")));
        [Export("authorizeWithURL", ArgumentSemantic.Strong)]
        STPIntentActionRedirectToURL AuthorizeWithURL { get; }
    }

    // @interface STPIntentActionAlipayHandleRedirect : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe35STPIntentActionAlipayHandleRedirect")]
    [DisableDefaultCtor]
    partial interface STPIntentActionAlipayHandleRedirect
    {
        // @property (readonly, copy, nonatomic) NSUrl * _Nullable nativeURL;
        [NullAllowed, Export("nativeURL", ArgumentSemantic.Copy)]
        NSUrl NativeURL { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nonnull returnURL;
        [Export("returnURL", ArgumentSemantic.Copy)]
        NSUrl ReturnURL { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nonnull url;
        [Export("url", ArgumentSemantic.Copy)]
        NSUrl Url { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_2605 (STPIntentActionAlipayHandleRedirect) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPIntentActionAlipayHandleRedirect))]
    partial interface STPIntentActionAlipayHandleRedirect //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPIntentActionAlipayHandleRedirect DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPIntentActionBoletoDisplayDetails : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe35STPIntentActionBoletoDisplayDetails")]
    [DisableDefaultCtor]
    interface STPIntentActionBoletoDisplayDetails //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull number;
        [Export("number")]
        string Number { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull expiresAt;
        [Export("expiresAt", ArgumentSemantic.Copy)]
        NSDate ExpiresAt { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nonnull hostedVoucherURL;
        [Export("hostedVoucherURL", ArgumentSemantic.Copy)]
        NSUrl HostedVoucherURL { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPIntentActionBoletoDisplayDetails DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPIntentActionOXXODisplayDetails : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe33STPIntentActionOXXODisplayDetails")]
    [DisableDefaultCtor]
    interface STPIntentActionOXXODisplayDetails //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDate * _Nonnull expiresAfter;
        [Export("expiresAfter", ArgumentSemantic.Copy)]
        NSDate ExpiresAfter { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nonnull hostedVoucherURL;
        [Export("hostedVoucherURL", ArgumentSemantic.Copy)]
        NSUrl HostedVoucherURL { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull number;
        [Export("number")]
        string Number { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPIntentActionOXXODisplayDetails DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }
    }

    // @interface STPIntentActionRedirectToURL : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPIntentActionRedirectToURL")]
    [DisableDefaultCtor]
    partial interface STPIntentActionRedirectToURL
    {
        // @property (readonly, copy, nonatomic) NSUrl * _Nonnull url;
        [Export("url", ArgumentSemantic.Copy)]
        NSUrl Url { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nullable returnURL;
        [NullAllowed, Export("returnURL", ArgumentSemantic.Copy)]
        NSUrl ReturnURL { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_2667 (STPIntentActionRedirectToURL) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPIntentActionRedirectToURL))]
    partial interface STPIntentActionRedirectToURL //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPIntentActionRedirectToURL DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPIntentActionVerifyWithMicrodeposits : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe38STPIntentActionVerifyWithMicrodeposits")]
    [DisableDefaultCtor]
    partial interface STPIntentActionVerifyWithMicrodeposits
    {
        // @property (readonly, copy, nonatomic) NSDate * _Nonnull arrivalDate;
        [Export("arrivalDate", ArgumentSemantic.Copy)]
        NSDate ArrivalDate { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nonnull hostedVerificationURL;
        [Export("hostedVerificationURL", ArgumentSemantic.Copy)]
        NSUrl HostedVerificationURL { get; }

        // @property (readonly, nonatomic) enum STPMicrodepositType microdepositType;
        [Export("microdepositType")]
        STPMicrodepositType MicrodepositType { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }
    }

    //// @interface Stripe_Swift_2717 (STPIntentActionVerifyWithMicrodeposits) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPIntentActionVerifyWithMicrodeposits))]
    partial interface STPIntentActionVerifyWithMicrodeposits //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPIntentActionVerifyWithMicrodeposits DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPIntentActionWechatPayRedirectToApp : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe37STPIntentActionWechatPayRedirectToApp")]
    [DisableDefaultCtor]
    partial interface STPIntentActionWechatPayRedirectToApp
    {
        // @property (readonly, copy, nonatomic) NSUrl * _Nullable nativeURL;
        [NullAllowed, Export("nativeURL", ArgumentSemantic.Copy)]
        NSUrl NativeURL { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_2737 (STPIntentActionWechatPayRedirectToApp) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPIntentActionWechatPayRedirectToApp))]
    partial interface STPIntentActionWechatPayRedirectToApp //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPIntentActionWechatPayRedirectToApp DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @protocol STPIssuingCardEphemeralKeyProvider <NSObject>
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol(Name = "_TtP6Stripe34STPIssuingCardEphemeralKeyProvider_")]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe34STPIssuingCardEphemeralKeyProvider_")]
    interface STPIssuingCardEphemeralKeyProvider
    {
        // @required -(void)createIssuingCardKeyWithAPIVersion:(NSString * _Nonnull)apiVersion completion:(void (^ _Nonnull)(NSDictionary * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("createIssuingCardKeyWithAPIVersion:completion:")]
        void Completion(string apiVersion, Action<NSDictionary, NSError> completion);
    }

    // @interface STPIssuingCardPin : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe17STPIssuingCardPin")]
    [DisableDefaultCtor]
    partial interface STPIssuingCardPin
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable pin;
        [NullAllowed, Export("pin")]
        string Pin { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable error;
        [NullAllowed, Export("error", ArgumentSemantic.Copy)]
        NSDictionary Error { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }
    }

    //// @interface Stripe_Swift_2780 (STPIssuingCardPin) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPIssuingCardPin))]
    partial interface STPIssuingCardPin //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPIssuingCardPin DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPKlarnaLineItem : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe17STPKlarnaLineItem")]
    [DisableDefaultCtor]
    interface STPKlarnaLineItem
    {
        // @property (nonatomic) enum STPKlarnaLineItemType itemType;
        [Export("itemType", ArgumentSemantic.Assign)]
        STPKlarnaLineItemType ItemType { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull itemDescription;
        [Export("itemDescription")]
        string ItemDescription { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nonnull quantity;
        [Export("quantity", ArgumentSemantic.Strong)]
        NSNumber Quantity { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nonnull totalAmount;
        [Export("totalAmount", ArgumentSemantic.Strong)]
        NSNumber TotalAmount { get; set; }

        // -(instancetype _Nonnull)initWithItemType:(enum STPKlarnaLineItemType)itemType itemDescription:(NSString * _Nonnull)itemDescription quantity:(NSNumber * _Nonnull)quantity totalAmount:(NSNumber * _Nonnull)totalAmount __attribute__((objc_designated_initializer));
        [Export("initWithItemType:itemDescription:quantity:totalAmount:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPKlarnaLineItemType itemType, string itemDescription, NSNumber quantity, NSNumber totalAmount);
    }

    // @interface STPMandateCustomerAcceptanceParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe34STPMandateCustomerAcceptanceParams")]
    interface STPMandateCustomerAcceptanceParams : STPFormEncodable
    {
        // @property (nonatomic) enum STPMandateCustomerAcceptanceType type;
        [Export("type", ArgumentSemantic.Assign)]
        STPMandateCustomerAcceptanceType Type { get; set; }

        // @property (nonatomic, strong) STPMandateOnlineParams * _Nullable onlineParams;
        [NullAllowed, Export("onlineParams", ArgumentSemantic.Strong)]
        STPMandateOnlineParams OnlineParams { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPMandateDataParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe20STPMandateDataParams")]
    [DisableDefaultCtor]
    partial interface STPMandateDataParams
    {
        // @property (readonly, nonatomic, strong) STPMandateCustomerAcceptanceParams * _Nonnull customerAcceptance;
        [Export("customerAcceptance", ArgumentSemantic.Strong)]
        STPMandateCustomerAcceptanceParams CustomerAcceptance { get; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(instancetype _Nonnull)initWithCustomerAcceptance:(STPMandateCustomerAcceptanceParams * _Nonnull)customerAcceptance __attribute__((objc_designated_initializer));
        [Export("initWithCustomerAcceptance:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPMandateCustomerAcceptanceParams customerAcceptance);
    }

    // // @interface Stripe_Swift_2880 (STPMandateDataParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPMandateDataParams))]
    partial interface STPMandateDataParams : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPMandateOnlineParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPMandateOnlineParams")]
    [DisableDefaultCtor]
    partial interface STPMandateOnlineParams
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull ipAddress;
        [Export("ipAddress")]
        string IpAddress { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull userAgent;
        [Export("userAgent")]
        string UserAgent { get; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(instancetype _Nonnull)initWithIPAddress:(NSString * _Nonnull)ipAddress userAgent:(NSString * _Nonnull)userAgent __attribute__((objc_designated_initializer));
        [Export("initWithIPAddress:userAgent:")]
        [DesignatedInitializer]
        IntPtr Constructor(string ipAddress, string userAgent);
    }

    // // @interface Stripe_Swift_2908 (STPMandateOnlineParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPMandateOnlineParams))]
    partial interface STPMandateOnlineParams : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPPaymentActivityIndicatorView : UIView
    [BaseType(typeof(UIView), Name = "_TtC6Stripe31STPPaymentActivityIndicatorView")]
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

        // @property (nonatomic, strong) UIColor * _Null_unspecified tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();
    }

    // @interface STPPaymentCardTextField : UIControl <UIKeyInput>
    [BaseType(typeof(UIControl), Name = "_TtC6Stripe23STPPaymentCardTextField")]
    interface STPPaymentCardTextField : IUIKeyInput
    {
        // -(BOOL)textField:(UITextField * _Nonnull)textField shouldChangeCharactersInRange:(NSRange)range replacementString:(NSString * _Nonnull)string __attribute__((warn_unused_result("")));
        [Export("textField:shouldChangeCharactersInRange:replacementString:")]
        bool TextField(UITextField textField, NSRange range, string @string);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPPaymentCardTextFieldDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<STPPaymentCardTextFieldDelegate> _Nullable delegate __attribute__((iboutlet));
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull font;
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull textErrorColor;
        [Export("textErrorColor", ArgumentSemantic.Strong)]
        UIColor TextErrorColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull placeholderColor;
        [Export("placeholderColor", ArgumentSemantic.Strong)]
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

        // @property (copy, nonatomic) NSString * _Nullable postalCodePlaceholder;
        [NullAllowed, Export("postalCodePlaceholder")]
        string PostalCodePlaceholder { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull cursorColor;
        [Export("cursorColor", ArgumentSemantic.Strong)]
        UIColor CursorColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable borderColor;
        [NullAllowed, Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // @property (nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic) UIKeyboardAppearance keyboardAppearance;
        [Export("keyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance KeyboardAppearance { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable inputView;
        [NullAllowed, Export("inputView", ArgumentSemantic.Strong)]
        UIView InputView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable inputAccessoryView;
        [NullAllowed, Export("inputAccessoryView", ArgumentSemantic.Strong)]
        UIView InputAccessoryView { get; set; }

        // @property (readonly, nonatomic, strong) UIImage * _Nullable brandImage;
        [NullAllowed, Export("brandImage", ArgumentSemantic.Strong)]
        UIImage BrandImage { get; }

        // @property (readonly, nonatomic) BOOL isValid;
        [Export("isValid")]
        bool IsValid { get; }

        // @property (getter = isEnabled, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled { [Bind("isEnabled")] get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable cardNumber;
        [NullAllowed, Export("cardNumber")]
        string CardNumber { get; }

        // @property (readonly, nonatomic) NSInteger expirationMonth;
        [Export("expirationMonth")]
        nint ExpirationMonth { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable formattedExpirationMonth;
        [NullAllowed, Export("formattedExpirationMonth")]
        string FormattedExpirationMonth { get; }

        // @property (readonly, nonatomic) NSInteger expirationYear;
        [Export("expirationYear")]
        nint ExpirationYear { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable formattedExpirationYear;
        [NullAllowed, Export("formattedExpirationYear")]
        string FormattedExpirationYear { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable cvc;
        [NullAllowed, Export("cvc")]
        string Cvc { get; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (nonatomic) BOOL postalCodeEntryEnabled;
        [Export("postalCodeEntryEnabled")]
        bool PostalCodeEntryEnabled { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable countryCode;
        [NullAllowed, Export("countryCode")]
        string CountryCode { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodCardParams * _Nonnull cardParams;
        [Export("cardParams", ArgumentSemantic.Strong)]
        STPPaymentMethodCardParams CardParams { get; set; }

        // -(BOOL)becomeFirstResponder;
        [Export("becomeFirstResponder")]
        bool BecomeFirstResponder();

        // -(BOOL)resignFirstResponder;
        [Export("resignFirstResponder")]
        bool ResignFirstResponder();

        // -(void)clear;
        [Export("clear")]
        void Clear();

        // +(UIImage * _Nullable)cvcImageForCardBrand:(enum STPCardBrand)cardBrand __attribute__((warn_unused_result("")));
        [Static]
        [Export("cvcImageForCardBrand:")]
        [return: NullAllowed]
        UIImage CvcImageForCardBrand(STPCardBrand cardBrand);

        // +(UIImage * _Nullable)brandImageForCardBrand:(enum STPCardBrand)cardBrand __attribute__((warn_unused_result("")));
        [Static]
        [Export("brandImageForCardBrand:")]
        [return: NullAllowed]
        UIImage BrandImageForCardBrand(STPCardBrand cardBrand);

        // +(UIImage * _Nullable)errorImageForCardBrand:(enum STPCardBrand)cardBrand __attribute__((warn_unused_result("")));
        [Static]
        [Export("errorImageForCardBrand:")]
        [return: NullAllowed]
        UIImage ErrorImageForCardBrand(STPCardBrand cardBrand);

        // -(CGRect)brandImageRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
        [Export("brandImageRectForBounds:")]
        CGRect BrandImageRectForBounds(CGRect bounds);

        // -(CGRect)fieldsRectForBounds:(CGRect)bounds __attribute__((warn_unused_result("")));
        [Export("fieldsRectForBounds:")]
        CGRect FieldsRectForBounds(CGRect bounds);

        //// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
        //[Export("initWithCoder:")]
        //[DesignatedInitializer]
        //IntPtr Constructor(NSCoder aDecoder);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
        [Export("traitCollectionDidChange:")]
        void TraitCollectionDidChange([NullAllowed] UITraitCollection previousTraitCollection);

        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic) UIControlContentVerticalAlignment contentVerticalAlignment;
        [Export("contentVerticalAlignment", ArgumentSemantic.Assign)]
        UIControlContentVerticalAlignment ContentVerticalAlignment { get; set; }

        // @property (readonly, nonatomic) BOOL isFirstResponder;
        [Export("isFirstResponder")]
        bool IsFirstResponder { get; }

        // @property (readonly, nonatomic) BOOL canBecomeFirstResponder;
        [Export("canBecomeFirstResponder")]
        bool CanBecomeFirstResponder { get; }

        // @property (readonly, nonatomic) BOOL canResignFirstResponder;
        [Export("canResignFirstResponder")]
        bool CanResignFirstResponder { get; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(BOOL)textFieldShouldBeginEditing:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
        [Export("textFieldShouldBeginEditing:")]
        bool TextFieldShouldBeginEditing(UITextField textField);

        // -(void)textFieldDidBeginEditing:(UITextField * _Nonnull)textField;
        [Export("textFieldDidBeginEditing:")]
        void TextFieldDidBeginEditing(UITextField textField);

        // -(BOOL)textFieldShouldEndEditing:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
        [Export("textFieldShouldEndEditing:")]
        bool TextFieldShouldEndEditing(UITextField textField);

        // -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
        [Export("textFieldDidEndEditing:")]
        void TextFieldDidEndEditing(UITextField textField);

        // -(BOOL)textFieldShouldReturn:(UITextField * _Nonnull)textField __attribute__((warn_unused_result("")));
        [Export("textFieldShouldReturn:")]
        bool TextFieldShouldReturn(UITextField textField);

        // @property (readonly, nonatomic) BOOL hasText;
        [Export("hasText")]
        bool HasText { get; }

        // -(void)insertText:(NSString * _Nonnull)text;
        [Export("insertText:")]
        void InsertText(string text);

        // -(void)deleteBackward;
        [Export("deleteBackward")]
        void DeleteBackward();

        // +(NSSet<NSString *> * _Nonnull)keyPathsForValuesAffectingIsValid __attribute__((warn_unused_result("")));
        [Static]
        [Export("keyPathsForValuesAffectingIsValid")]
        NSSet<NSString> KeyPathsForValuesAffectingIsValid { get; }
    }

    // @interface STPPaymentConfiguration : NSObject <NSCopying>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPPaymentConfiguration")]
    interface STPPaymentConfiguration : INSCopying
    {
        // @property (nonatomic, strong, class) STPPaymentConfiguration * _Nonnull sharedConfiguration;
        [Static]
        [Export("sharedConfiguration", ArgumentSemantic.Strong)]
        STPPaymentConfiguration SharedConfiguration { get; set; }

        // @property (nonatomic) BOOL applePayEnabled;
        [Export("applePayEnabled")]
        bool ApplePayEnabled { get; set; }

        // @property (nonatomic) BOOL fpxEnabled;
        [Export("fpxEnabled")]
        bool FpxEnabled { get; set; }

        // @property (nonatomic) enum STPBillingAddressFields requiredBillingAddressFields;
        [Export("requiredBillingAddressFields", ArgumentSemantic.Assign)]
        STPBillingAddressFields RequiredBillingAddressFields { get; set; }

        // @property (copy, nonatomic) NSSet<STPContactField *> * _Nullable requiredShippingAddressFields;
        [NullAllowed, Export("requiredShippingAddressFields", ArgumentSemantic.Copy)]
        NSSet RequiredShippingAddressFields { get; set; }

        // @property (nonatomic) BOOL verifyPrefilledShippingAddress;
        [Export("verifyPrefilledShippingAddress")]
        bool VerifyPrefilledShippingAddress { get; set; }

        // @property (nonatomic) enum STPShippingType shippingType;
        [Export("shippingType", ArgumentSemantic.Assign)]
        STPShippingType ShippingType { get; set; }

        // @property (copy, nonatomic) NSSet<NSString *> * _Nonnull availableCountries;
        [Export("availableCountries", ArgumentSemantic.Copy)]
        NSSet<NSString> AvailableCountries { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull companyName;
        [Export("companyName")]
        string CompanyName { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable appleMerchantIdentifier;
        [NullAllowed, Export("appleMerchantIdentifier")]
        string AppleMerchantIdentifier { get; set; }

        // @property (nonatomic) BOOL canDeletePaymentOptions;
        [Export("canDeletePaymentOptions")]
        bool CanDeletePaymentOptions { get; set; }

        // @property (nonatomic) BOOL cardScanningEnabled;
        [Export("cardScanningEnabled")]
        bool CardScanningEnabled { get; set; }

        // @property (nonatomic) NSInteger additionalPaymentOptions __attribute__((deprecated("additionalPaymentOptions has been removed. Set applePayEnabled and fpxEnabled on STPPaymentConfiguration instead.")));
        [Export("additionalPaymentOptions")]
        nint AdditionalPaymentOptions { get; set; }

        // @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("If you used STPPaymentConfiguration.shared.publishableKey, use STPAPIClient.shared.publishableKey instead. If you passed a STPPaymentConfiguration instance to an SDK component, create an STPAPIClient, set publishableKey on it, and set the SDK component's APIClient property.") NSString * publishableKey __attribute__((deprecated("If you used STPPaymentConfiguration.shared.publishableKey, use STPAPIClient.shared.publishableKey instead. If you passed a STPPaymentConfiguration instance to an SDK component, create an STPAPIClient, set publishableKey on it, and set the SDK component's APIClient property.")));
        [Export("publishableKey")]
        string PublishableKey { get; set; }

        // @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("If you used STPPaymentConfiguration.shared.stripeAccount, use STPAPIClient.shared.stripeAccount instead. If you passed a STPPaymentConfiguration instance to an SDK component, create an STPAPIClient, set stripeAccount on it, and set the SDK component's APIClient property.") NSString * stripeAccount __attribute__((deprecated("If you used STPPaymentConfiguration.shared.stripeAccount, use STPAPIClient.shared.stripeAccount instead. If you passed a STPPaymentConfiguration instance to an SDK component, create an STPAPIClient, set stripeAccount on it, and set the SDK component's APIClient property.")));
        [Export("stripeAccount")]
        string StripeAccount { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // @protocol STPShippingAddressViewControllerDelegate <NSObject>
    [Protocol(Name = "_TtP6Stripe40STPShippingAddressViewControllerDelegate_"), Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe40STPShippingAddressViewControllerDelegate_")]
    interface STPShippingAddressViewControllerDelegate
    {
        // @required -(void)shippingAddressViewControllerDidCancel:(STPShippingAddressViewController * _Nonnull)addressViewController;
        [Abstract]
        [Export("shippingAddressViewControllerDidCancel:")]
        void ShippingAddressViewControllerDidCancel(STPShippingAddressViewController addressViewController);

        // @required -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didEnterAddress:(STPAddress * _Nonnull)address completion:(void (^ _Nonnull)(enum STPShippingStatus, NSError * _Nullable, NSArray<PKShippingMethod *> * _Nullable, PKShippingMethod * _Nullable))completion;
        [Abstract]
        [Export("shippingAddressViewController:didEnterAddress:completion:")]
        void ShippingAddressViewController(STPShippingAddressViewController addressViewController, STPAddress address, Action<STPShippingStatus, NSError, NSArray<PKShippingMethod>, PKShippingMethod> completion);

        // @required -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didFinishWithAddress:(STPAddress * _Nonnull)address shippingMethod:(PKShippingMethod * _Nullable)method;
        [Abstract]
        [Export("shippingAddressViewController:didFinishWithAddress:shippingMethod:")]
        void ShippingAddressViewController(STPShippingAddressViewController addressViewController, STPAddress address, [NullAllowed] PKShippingMethod method);
    }

    // @protocol STPPaymentOptionsViewControllerDelegate <NSObject>
    [Protocol(Name = "_TtP6Stripe39STPPaymentOptionsViewControllerDelegate_"), Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe39STPPaymentOptionsViewControllerDelegate_")]
    interface STPPaymentOptionsViewControllerDelegate
    {
        // @required -(void)paymentOptionsViewController:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController didFailToLoadWithError:(NSError * _Nonnull)error;
        [Abstract]
        [Export("paymentOptionsViewController:didFailToLoadWithError:")]
        void PaymentOptionsViewController(STPPaymentOptionsViewController paymentOptionsViewController, NSError error);

        // @required -(void)paymentOptionsViewControllerDidFinish:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController;
        [Abstract]
        [Export("paymentOptionsViewControllerDidFinish:")]
        void PaymentOptionsViewControllerDidFinish(STPPaymentOptionsViewController paymentOptionsViewController);

        // @required -(void)paymentOptionsViewControllerDidCancel:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController;
        [Abstract]
        [Export("paymentOptionsViewControllerDidCancel:")]
        void PaymentOptionsViewControllerDidCancel(STPPaymentOptionsViewController paymentOptionsViewController);

        // @optional -(void)paymentOptionsViewController:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController didSelectPaymentOption:(id<STPPaymentOption> _Nonnull)paymentOption;
        [Export("paymentOptionsViewController:didSelectPaymentOption:")]
        void PaymentOptionsViewController(STPPaymentOptionsViewController paymentOptionsViewController, STPPaymentOption paymentOption);
    }

    // @interface STPPaymentContext : NSObject <STPAuthenticationContext, STPPaymentOptionsViewControllerDelegate, STPShippingAddressViewControllerDelegate>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPPaymentContext : STPAuthenticationContext, STPPaymentOptionsViewControllerDelegate, STPShippingAddressViewControllerDelegate
    {
        // -(instancetype _Nonnull)initWithCustomerContext:(STPCustomerContext * _Nonnull)customerContext;
        [Export("initWithCustomerContext:")]
        IntPtr Constructor(STPCustomerContext customerContext);

        // -(instancetype _Nonnull)initWithCustomerContext:(STPCustomerContext * _Nonnull)customerContext configuration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme;
        [Export("initWithCustomerContext:configuration:theme:")]
        IntPtr Constructor(STPCustomerContext customerContext, STPPaymentConfiguration configuration, STPTheme theme);

        // -(instancetype _Nonnull)initWithApiAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter;
        [Export("initWithApiAdapter:")]
        IntPtr Constructor(STPBackendAPIAdapter apiAdapter);

        // -(instancetype _Nonnull)initWithApiAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter configuration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme __attribute__((objc_designated_initializer));
        [Export("initWithApiAdapter:configuration:theme:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPBackendAPIAdapter apiAdapter, STPPaymentConfiguration configuration, STPTheme theme);

        // @property (readonly, nonatomic, strong) id<STPBackendAPIAdapter> _Nonnull apiAdapter;
        [Export("apiAdapter", ArgumentSemantic.Strong)]
        STPBackendAPIAdapter ApiAdapter { get; }

        // @property (readonly, nonatomic, strong) STPPaymentConfiguration * _Nonnull configuration;
        [Export("configuration", ArgumentSemantic.Strong)]
        STPPaymentConfiguration Configuration { get; }

        // @property (readonly, nonatomic, strong) STPTheme * _Nonnull theme;
        [Export("theme", ArgumentSemantic.Strong)]
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

        // @property (copy, nonatomic) NSString * _Nullable defaultPaymentMethod;
        [NullAllowed, Export("defaultPaymentMethod")]
        string DefaultPaymentMethod { get; set; }

        // @property (readonly, nonatomic, strong) id<STPPaymentOption> _Nullable selectedPaymentOption;
        [NullAllowed, Export("selectedPaymentOption", ArgumentSemantic.Strong)]
        STPPaymentOption SelectedPaymentOption { get; }

        // @property (readonly, copy, nonatomic) NSArray<id<STPPaymentOption>> * _Nullable paymentOptions;
        [NullAllowed, Export("paymentOptions", ArgumentSemantic.Copy)]
        STPPaymentOption[] PaymentOptions { get; }

        // @property (readonly, nonatomic, strong) PKShippingMethod * _Nullable selectedShippingMethod;
        [NullAllowed, Export("selectedShippingMethod", ArgumentSemantic.Strong)]
        PKShippingMethod SelectedShippingMethod { get; }

        // @property (readonly, copy, nonatomic) NSArray<PKShippingMethod *> * _Nullable shippingMethods;
        [NullAllowed, Export("shippingMethods", ArgumentSemantic.Copy)]
        PKShippingMethod[] ShippingMethods { get; }

        // @property (readonly, nonatomic, strong) STPAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress", ArgumentSemantic.Strong)]
        STPAddress ShippingAddress { get; }

        // @property (nonatomic) NSInteger paymentAmount;
        [Export("paymentAmount")]
        nint PaymentAmount { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull paymentCurrency;
        [Export("paymentCurrency")]
        string PaymentCurrency { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull paymentCountry;
        [Export("paymentCountry")]
        string PaymentCountry { get; set; }

        // @property (copy, nonatomic) NSArray<PKPaymentSummaryItem *> * _Nonnull paymentSummaryItems;
        [Export("paymentSummaryItems", ArgumentSemantic.Copy)]
        PKPaymentSummaryItem[] PaymentSummaryItems { get; set; }

        // @property (nonatomic) UIModalPresentationStyle modalPresentationStyle;
        [Export("modalPresentationStyle", ArgumentSemantic.Assign)]
        UIModalPresentationStyle ModalPresentationStyle { get; set; }

        // @property (nonatomic) UINavigationItemLargeTitleDisplayMode largeTitleDisplayMode;
        [Export("largeTitleDisplayMode", ArgumentSemantic.Assign)]
        UINavigationItemLargeTitleDisplayMode LargeTitleDisplayMode { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable paymentOptionsViewControllerFooterView;
        [NullAllowed, Export("paymentOptionsViewControllerFooterView", ArgumentSemantic.Strong)]
        UIView PaymentOptionsViewControllerFooterView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable addCardViewControllerFooterView;
        [NullAllowed, Export("addCardViewControllerFooterView", ArgumentSemantic.Strong)]
        UIView AddCardViewControllerFooterView { get; set; }

        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }

        // -(void)retryLoading;
        [Export("retryLoading")]
        void RetryLoading();

        // -(void)presentPaymentOptionsViewController;
        [Export("presentPaymentOptionsViewController")]
        void PresentPaymentOptionsViewController();

        // -(void)pushPaymentOptionsViewController;
        [Export("pushPaymentOptionsViewController")]
        void PushPaymentOptionsViewController();

        // -(void)presentShippingViewController;
        [Export("presentShippingViewController")]
        void PresentShippingViewController();

        // -(void)pushShippingViewController;
        [Export("pushShippingViewController")]
        void PushShippingViewController();

        // -(void)requestPayment;
        [Export("requestPayment")]
        void RequestPayment();

        // -(void)paymentOptionsViewController:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController didSelectPaymentOption:(id<STPPaymentOption> _Nonnull)paymentOption;
        [Export("paymentOptionsViewController:didSelectPaymentOption:")]
        void PaymentOptionsViewController(STPPaymentOptionsViewController paymentOptionsViewController, STPPaymentOption paymentOption);

        // -(void)paymentOptionsViewControllerDidFinish:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController;
        [Export("paymentOptionsViewControllerDidFinish:")]
        void PaymentOptionsViewControllerDidFinish(STPPaymentOptionsViewController paymentOptionsViewController);

        // -(void)paymentOptionsViewControllerDidCancel:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController;
        [Export("paymentOptionsViewControllerDidCancel:")]
        void PaymentOptionsViewControllerDidCancel(STPPaymentOptionsViewController paymentOptionsViewController);

        // -(void)paymentOptionsViewController:(STPPaymentOptionsViewController * _Nonnull)paymentOptionsViewController didFailToLoadWithError:(NSError * _Nonnull)error;
        [Export("paymentOptionsViewController:didFailToLoadWithError:")]
        void PaymentOptionsViewController(STPPaymentOptionsViewController paymentOptionsViewController, NSError error);

        // -(void)shippingAddressViewControllerDidCancel:(STPShippingAddressViewController * _Nonnull)addressViewController;
        [Export("shippingAddressViewControllerDidCancel:")]
        void ShippingAddressViewControllerDidCancel(STPShippingAddressViewController addressViewController);

        // -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didEnterAddress:(STPAddress * _Nonnull)address completion:(void (^ _Nonnull)(enum STPShippingStatus, NSError * _Nullable, NSArray<PKShippingMethod *> * _Nullable, PKShippingMethod * _Nullable))completion;
        [Export("shippingAddressViewController:didEnterAddress:completion:")]
        void ShippingAddressViewController(STPShippingAddressViewController addressViewController, STPAddress address, Action<STPShippingStatus, NSError, NSArray<PKShippingMethod>, PKShippingMethod> completion);

        // -(void)shippingAddressViewController:(STPShippingAddressViewController * _Nonnull)addressViewController didFinishWithAddress:(STPAddress * _Nonnull)address shippingMethod:(PKShippingMethod * _Nullable)method;
        [Export("shippingAddressViewController:didFinishWithAddress:shippingMethod:")]
        void ShippingAddressViewController(STPShippingAddressViewController addressViewController, STPAddress address, [NullAllowed] PKShippingMethod method);

        // -(UIViewController * _Nonnull)authenticationPresentingViewController __attribute__((warn_unused_result("")));
        [Export("authenticationPresentingViewController")]
        UIViewController AuthenticationPresentingViewController { get; }

        // -(void)prepareAuthenticationContextForPresentation:(void (^ _Nonnull)(void))completion;
        [Export("prepareAuthenticationContextForPresentation:")]
        void PrepareAuthenticationContextForPresentation(Action completion);
    }

    // @protocol STPPaymentContextDelegate <NSObject>
    [Protocol(Name = "_TtP6Stripe25STPPaymentContextDelegate_"), Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject), Name = "_TtP6Stripe25STPPaymentContextDelegate_")]
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

        // @required -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didCreatePaymentResult:(STPPaymentResult * _Nonnull)paymentResult completion:(void (^ _Nonnull)(enum STPPaymentStatus, NSError * _Nullable))completion;
        [Abstract]
        [Export("paymentContext:didCreatePaymentResult:completion:")]
        void PaymentContext(STPPaymentContext paymentContext, STPPaymentResult paymentResult, Action<STPPaymentStatus, NSError> completion);

        // @required -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didFinishWith:(enum STPPaymentStatus)status error:(NSError * _Nullable)error;
        [Abstract]
        [Export("paymentContext:didFinishWith:error:")]
        void PaymentContext(STPPaymentContext paymentContext, STPPaymentStatus status, [NullAllowed] NSError error);

        // @optional -(void)paymentContext:(STPPaymentContext * _Nonnull)paymentContext didUpdateShippingAddress:(STPAddress * _Nonnull)address completion:(void (^ _Nonnull)(enum STPShippingStatus, NSError * _Nullable, NSArray<PKShippingMethod *> * _Nullable, PKShippingMethod * _Nullable))completion;
        [Export("paymentContext:didUpdateShippingAddress:completion:")]
        void PaymentContext(STPPaymentContext paymentContext, STPAddress address, Action<STPShippingStatus, NSError, NSArray<PKShippingMethod>, PKShippingMethod> completion);
    }

    // @interface STPPaymentHandler : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe17STPPaymentHandler")]
    [DisableDefaultCtor]
    partial interface STPPaymentHandler
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull errorDomain;
        [Static]
        [Export("errorDomain")]
        string ErrorDomain { get; }

        // @property (readonly, nonatomic, strong, class) STPPaymentHandler * _Nonnull sharedHandler;
        [Static]
        [Export("sharedHandler", ArgumentSemantic.Strong)]
        STPPaymentHandler SharedHandler { get; }

        // +(STPPaymentHandler * _Nonnull)shared __attribute__((warn_unused_result("")));
        [Static]
        [Export("shared")]
        STPPaymentHandler Shared { get; }

        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }

        // @property (nonatomic, strong) STPThreeDSCustomizationSettings * _Nonnull threeDSCustomizationSettings;
        [Export("threeDSCustomizationSettings", ArgumentSemantic.Strong)]
        STPThreeDSCustomizationSettings ThreeDSCustomizationSettings { get; set; }

        // @property (nonatomic) BOOL simulateAppToAppRedirect;
        [Export("simulateAppToAppRedirect")]
        bool SimulateAppToAppRedirect { get; set; }

        // -(void)confirmPayment:(STPPaymentIntentParams * _Nonnull)paymentParams withAuthenticationContext:(id<STPAuthenticationContext> _Nonnull)authenticationContext completion:(void (^ _Nonnull)(enum STPPaymentHandlerActionStatus, STPPaymentIntent * _Nullable, NSError * _Nullable))completion __attribute__((availability(ios_app_extension, unavailable)));
        // [Unavailable (PlatformName.iOSAppExtension)]
        [Export("confirmPayment:withAuthenticationContext:completion:")]
        void ConfirmPayment(STPPaymentIntentParams paymentParams, STPAuthenticationContext authenticationContext, Action<STPPaymentHandlerActionStatus, STPPaymentIntent, NSError> completion);

        // -(void)handleNextActionForPayment:(NSString * _Nonnull)paymentIntentClientSecret withAuthenticationContext:(id<STPAuthenticationContext> _Nonnull)authenticationContext returnURL:(NSString * _Nullable)returnURL completion:(void (^ _Nonnull)(enum STPPaymentHandlerActionStatus, STPPaymentIntent * _Nullable, NSError * _Nullable))completion __attribute__((availability(ios_app_extension, unavailable)));
        // [Unavailable (PlatformName.iOSAppExtension)]
        [Export("handleNextActionForPayment:withAuthenticationContext:returnURL:completion:")]
        void HandleNextActionForPayment(string paymentIntentClientSecret, STPAuthenticationContext authenticationContext, [NullAllowed] string returnURL, Action<STPPaymentHandlerActionStatus, STPPaymentIntent, NSError> completion);

        // -(void)confirmSetupIntent:(STPSetupIntentConfirmParams * _Nonnull)setupIntentConfirmParams withAuthenticationContext:(id<STPAuthenticationContext> _Nonnull)authenticationContext completion:(void (^ _Nonnull)(enum STPPaymentHandlerActionStatus, STPSetupIntent * _Nullable, NSError * _Nullable))completion __attribute__((availability(ios_app_extension, unavailable)));
        // [Unavailable (PlatformName.iOSAppExtension)]
        [Export("confirmSetupIntent:withAuthenticationContext:completion:")]
        void ConfirmSetupIntent(STPSetupIntentConfirmParams setupIntentConfirmParams, STPAuthenticationContext authenticationContext, Action<STPPaymentHandlerActionStatus, STPSetupIntent, NSError> completion);

        // -(void)handleNextActionForSetupIntent:(NSString * _Nonnull)setupIntentClientSecret withAuthenticationContext:(id<STPAuthenticationContext> _Nonnull)authenticationContext returnURL:(NSString * _Nullable)returnURL completion:(void (^ _Nonnull)(enum STPPaymentHandlerActionStatus, STPSetupIntent * _Nullable, NSError * _Nullable))completion __attribute__((availability(ios_app_extension, unavailable)));
        // [Unavailable (PlatformName.iOSAppExtension)]
        [Export("handleNextActionForSetupIntent:withAuthenticationContext:returnURL:completion:")]
        void HandleNextActionForSetupIntent(string setupIntentClientSecret, STPAuthenticationContext authenticationContext, [NullAllowed] string returnURL, Action<STPPaymentHandlerActionStatus, STPSetupIntent, NSError> completion);
    }

    //// @interface Stripe_Swift_3713 (STPPaymentHandler) <SFSafariViewControllerDelegate>
    //// [Unavailable (PlatformName.iOSAppExtension)]
    //[Category]
    //[BaseType(typeof(STPPaymentHandler))]
    partial interface STPPaymentHandler : ISFSafariViewControllerDelegate
    {
        // -(void)safariViewControllerDidFinish:(SFSafariViewController * _Nonnull)controller;
        [Export("safariViewControllerDidFinish:")]
        void SafariViewControllerDidFinish(SFSafariViewController controller);
    }

    //// @interface Stripe_Swift_3720 (STPPaymentHandler)
    //// [Unavailable (PlatformName.iOSAppExtension)]
    //[Category]
    //[BaseType(typeof(STPPaymentHandler))]
    partial interface STPPaymentHandler
    {
        // -(BOOL)handleURLCallback:(NSUrl * _Nonnull)url __attribute__((warn_unused_result("")));
        [Export("handleURLCallback:")]
        bool HandleURLCallback(NSUrl url);
    }

    // @interface STPPaymentIntent : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe16STPPaymentIntent")]
    [DisableDefaultCtor]
    partial interface STPPaymentIntent
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull stripeId;
        [Export("stripeId")]
        string StripeId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull clientSecret;
        [Export("clientSecret")]
        string ClientSecret { get; }

        // @property (readonly, nonatomic) NSInteger amount;
        [Export("amount")]
        nint Amount { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable canceledAt;
        [NullAllowed, Export("canceledAt", ArgumentSemantic.Copy)]
        NSDate CanceledAt { get; }

        // @property (readonly, nonatomic) enum STPPaymentIntentCaptureMethod captureMethod;
        [Export("captureMethod")]
        STPPaymentIntentCaptureMethod CaptureMethod { get; }

        // @property (readonly, nonatomic) enum STPPaymentIntentConfirmationMethod confirmationMethod;
        [Export("confirmationMethod")]
        STPPaymentIntentConfirmationMethod ConfirmationMethod { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
        [Export("created", ArgumentSemantic.Copy)]
        NSDate Created { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull currency;
        [Export("currency")]
        string Currency { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable stripeDescription;
        [NullAllowed, Export("stripeDescription")]
        string StripeDescription { get; }

        // @property (readonly, nonatomic) BOOL livemode;
        [Export("livemode")]
        bool Livemode { get; }

        // @property (readonly, nonatomic, strong) STPIntentAction * _Nullable nextAction;
        [NullAllowed, Export("nextAction", ArgumentSemantic.Strong)]
        STPIntentAction NextAction { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable receiptEmail;
        [NullAllowed, Export("receiptEmail")]
        string ReceiptEmail { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable sourceId;
        [NullAllowed, Export("sourceId")]
        string SourceId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable paymentMethodId;
        [NullAllowed, Export("paymentMethodId")]
        string PaymentMethodId { get; }

        // @property (readonly, nonatomic) enum STPPaymentIntentStatus status;
        [Export("status")]
        STPPaymentIntentStatus Status { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull paymentMethodTypes;
        [Export("paymentMethodTypes", ArgumentSemantic.Copy)]
        NSNumber[] PaymentMethodTypes { get; }

        // @property (readonly, nonatomic) enum STPPaymentIntentSetupFutureUsage setupFutureUsage;
        [Export("setupFutureUsage")]
        STPPaymentIntentSetupFutureUsage SetupFutureUsage { get; }

        // @property (readonly, nonatomic, strong) STPPaymentIntentLastPaymentError * _Nullable lastPaymentError;
        [NullAllowed, Export("lastPaymentError", ArgumentSemantic.Strong)]
        STPPaymentIntentLastPaymentError LastPaymentError { get; }

        // @property (readonly, nonatomic, strong) STPPaymentIntentShippingDetails * _Nullable shipping;
        [NullAllowed, Export("shipping", ArgumentSemantic.Strong)]
        STPPaymentIntentShippingDetails Shipping { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
        [NullAllowed, Export("paymentMethod", ArgumentSemantic.Strong)]
        STPPaymentMethod PaymentMethod { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_3829 (STPPaymentIntent)
    //[Category]
    //[BaseType (typeof(STPPaymentIntent))]
    partial interface STPPaymentIntent
    {
        // @property (readonly, nonatomic, strong) SWIFT_DEPRECATED_MSG("Use nextAction instead", "nextAction") STPIntentAction * nextSourceAction __attribute__((deprecated("Use nextAction instead", "nextAction")));
        [Export("nextSourceAction", ArgumentSemantic.Strong)]
        STPIntentAction NextSourceAction { get; }
    }

    //// @interface Stripe_Swift_3837 (STPPaymentIntent) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPPaymentIntent))]
    partial interface STPPaymentIntent //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentIntent DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentIntentAction : STPIntentAction
    [BaseType(typeof(STPIntentAction), Name = "_TtC6Stripe22STPPaymentIntentAction")]
    interface STPPaymentIntentAction
    {
    }

    // @interface STPPaymentIntentLastPaymentError : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe32STPPaymentIntentLastPaymentError")]
    [DisableDefaultCtor]
    partial interface STPPaymentIntentLastPaymentError
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull ErrorCodeAuthenticationFailure;
        [Static]
        [Export("ErrorCodeAuthenticationFailure")]
        string ErrorCodeAuthenticationFailure { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable code;
        [NullAllowed, Export("code")]
        string Code { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable declineCode;
        [NullAllowed, Export("declineCode")]
        string DeclineCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable docURL;
        [NullAllowed, Export("docURL")]
        string DocURL { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable message;
        [NullAllowed, Export("message")]
        string Message { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable param;
        [NullAllowed, Export("param")]
        string Param { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
        [NullAllowed, Export("paymentMethod", ArgumentSemantic.Strong)]
        STPPaymentMethod PaymentMethod { get; }

        // @property (readonly, nonatomic) enum STPPaymentIntentLastPaymentErrorType type;
        [Export("type")]
        STPPaymentIntentLastPaymentErrorType Type { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_3933 (STPPaymentIntentLastPaymentError) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPPaymentIntentLastPaymentError))]
    partial interface STPPaymentIntentLastPaymentError //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentIntentLastPaymentError DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentIntentParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPPaymentIntentParams")]
    [DisableDefaultCtor]
    partial interface STPPaymentIntentParams
    {
        // -(instancetype _Nonnull)initWithClientSecret:(NSString * _Nonnull)clientSecret __attribute__((objc_designated_initializer));
        [Export("initWithClientSecret:")]
        [DesignatedInitializer]
        IntPtr Constructor(string clientSecret);

        // -(instancetype _Nonnull)initWithClientSecret:(NSString * _Nonnull)clientSecret paymentMethodType:(enum STPPaymentMethodType)paymentMethodType __attribute__((objc_designated_initializer));
        [Export("initWithClientSecret:paymentMethodType:")]
        [DesignatedInitializer]
        IntPtr Constructor(string clientSecret, STPPaymentMethodType paymentMethodType);

        // @property (readonly, copy, nonatomic) NSString * _Nullable stripeId;
        [NullAllowed, Export("stripeId")]
        string StripeId { get; }

        // @property (copy, nonatomic) NSString * _Nonnull clientSecret;
        [Export("clientSecret")]
        string ClientSecret { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodParams * _Nullable paymentMethodParams;
        [NullAllowed, Export("paymentMethodParams", ArgumentSemantic.Strong)]
        STPPaymentMethodParams PaymentMethodParams { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable paymentMethodId;
        [NullAllowed, Export("paymentMethodId")]
        string PaymentMethodId { get; set; }

        // @property (nonatomic, strong) STPSourceParams * _Nullable sourceParams;
        [NullAllowed, Export("sourceParams", ArgumentSemantic.Strong)]
        STPSourceParams SourceParams { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sourceId;
        [NullAllowed, Export("sourceId")]
        string SourceId { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable receiptEmail;
        [NullAllowed, Export("receiptEmail")]
        string ReceiptEmail { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable savePaymentMethod;
        [NullAllowed, Export("savePaymentMethod", ArgumentSemantic.Strong)]
        NSNumber SavePaymentMethod { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable returnURL;
        [NullAllowed, Export("returnURL")]
        string ReturnURL { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable setupFutureUsage;
        [NullAllowed, Export("setupFutureUsage", ArgumentSemantic.Strong)]
        NSNumber SetupFutureUsage { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable useStripeSDK;
        [NullAllowed, Export("useStripeSDK", ArgumentSemantic.Strong)]
        NSNumber UseStripeSDK { get; set; }

        // @property (nonatomic, strong) STPMandateDataParams * _Nullable mandateData;
        [NullAllowed, Export("mandateData", ArgumentSemantic.Strong)]
        STPMandateDataParams MandateData { get; set; }

        // @property (nonatomic, strong) STPConfirmPaymentMethodOptions * _Nullable paymentMethodOptions;
        [NullAllowed, Export("paymentMethodOptions", ArgumentSemantic.Strong)]
        STPConfirmPaymentMethodOptions PaymentMethodOptions { get; set; }

        // @property (nonatomic, strong) STPPaymentIntentShippingDetailsParams * _Nullable shipping;
        [NullAllowed, Export("shipping", ArgumentSemantic.Strong)]
        STPPaymentIntentShippingDetailsParams Shipping { get; set; }

        // @property (copy, nonatomic) SWIFT_DEPRECATED_MSG("", "returnURL") NSString * returnUrl __attribute__((deprecated("", "returnURL")));
        [Export("returnUrl")]
        string ReturnUrl { get; set; }

        // @property (nonatomic, strong) SWIFT_DEPRECATED_MSG("", "savePaymentMethod") NSNumber * saveSourceToCustomer __attribute__((deprecated("", "savePaymentMethod")));
        [Export("saveSourceToCustomer", ArgumentSemantic.Strong)]
        NSNumber SaveSourceToCustomer { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(void)configureWith:(STPPaymentResult * _Nonnull)paymentResult;
        [Export("configureWith:")]
        void ConfigureWith(STPPaymentResult paymentResult);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_4063 (STPPaymentIntentParams) <NSCopying>
    //[Category]
    //[BaseType (typeof(STPPaymentIntentParams))]
    partial interface STPPaymentIntentParams : INSCopying
    {
        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // // @interface Stripe_Swift_4069 (STPPaymentIntentParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPPaymentIntentParams))]
    partial interface STPPaymentIntentParams : STPFormEncodable
    {
        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentIntentShippingDetails : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe31STPPaymentIntentShippingDetails")]
    [DisableDefaultCtor]
    partial interface STPPaymentIntentShippingDetails
    {
        // @property (readonly, nonatomic, strong) STPPaymentIntentShippingDetailsAddress * _Nullable address;
        [NullAllowed, Export("address", ArgumentSemantic.Strong)]
        STPPaymentIntentShippingDetailsAddress Address { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable carrier;
        [NullAllowed, Export("carrier")]
        string Carrier { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable trackingNumber;
        [NullAllowed, Export("trackingNumber")]
        string TrackingNumber { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_4117 (STPPaymentIntentShippingDetails) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPPaymentIntentShippingDetails))]
    partial interface STPPaymentIntentShippingDetails //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentIntentShippingDetails DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentIntentShippingDetailsAddress : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe38STPPaymentIntentShippingDetailsAddress")]
    [DisableDefaultCtor]
    partial interface STPPaymentIntentShippingDetailsAddress
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable city;
        [NullAllowed, Export("city")]
        string City { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable line1;
        [NullAllowed, Export("line1")]
        string Line1 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable line2;
        [NullAllowed, Export("line2")]
        string Line2 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable state;
        [NullAllowed, Export("state")]
        string State { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    //// @interface Stripe_Swift_4150 (STPPaymentIntentShippingDetailsAddress) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPPaymentIntentShippingDetailsAddress))]
    partial interface STPPaymentIntentShippingDetailsAddress //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentIntentShippingDetailsAddress DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentIntentShippingDetailsAddressParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe44STPPaymentIntentShippingDetailsAddressParams")]
    [DisableDefaultCtor]
    partial interface STPPaymentIntentShippingDetailsAddressParams
    {
        // @property (copy, nonatomic) NSString * _Nullable city;
        [NullAllowed, Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull line1;
        [Export("line1")]
        string Line1 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable line2;
        [NullAllowed, Export("line2")]
        string Line2 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable state;
        [NullAllowed, Export("state")]
        string State { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(instancetype _Nonnull)initWithLine1:(NSString * _Nonnull)line1 __attribute__((objc_designated_initializer));
        [Export("initWithLine1:")]
        [DesignatedInitializer]
        IntPtr Constructor(string line1);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_4182 (STPPaymentIntentShippingDetailsAddressParams) <NSCopying>
    // [Category]
    // [BaseType (typeof(STPPaymentIntentShippingDetailsAddressParams))]
    partial interface STPPaymentIntentShippingDetailsAddressParams : INSCopying
    {
        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // // @interface Stripe_Swift_4188 (STPPaymentIntentShippingDetailsAddressParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPPaymentIntentShippingDetailsAddressParams))]
    partial interface STPPaymentIntentShippingDetailsAddressParams : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPPaymentIntentShippingDetailsParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe37STPPaymentIntentShippingDetailsParams")]
    [DisableDefaultCtor]
    partial interface STPPaymentIntentShippingDetailsParams
    {
        // @property (nonatomic, strong) STPPaymentIntentShippingDetailsAddressParams * _Nonnull address;
        [Export("address", ArgumentSemantic.Strong)]
        STPPaymentIntentShippingDetailsAddressParams Address { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable carrier;
        [NullAllowed, Export("carrier")]
        string Carrier { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable trackingNumber;
        [NullAllowed, Export("trackingNumber")]
        string TrackingNumber { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(instancetype _Nonnull)initWithAddress:(STPPaymentIntentShippingDetailsAddressParams * _Nonnull)address name:(NSString * _Nonnull)name __attribute__((objc_designated_initializer));
        [Export("initWithAddress:name:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPPaymentIntentShippingDetailsAddressParams address, string name);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // // @interface Stripe_Swift_4220 (STPPaymentIntentShippingDetailsParams) <NSCopying>
    // [Category]
    // [BaseType (typeof(STPPaymentIntentShippingDetailsParams))]
    partial interface STPPaymentIntentShippingDetailsParams : INSCopying
    {
        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // // @interface Stripe_Swift_4226 (STPPaymentIntentShippingDetailsParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPPaymentIntentShippingDetailsParams))]
    partial interface STPPaymentIntentShippingDetailsParams : STPFormEncodable
    {
        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }
    }

    // @interface STPPaymentMethod : NSObject <STPAPIResponseDecodable, STPPaymentOption>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe16STPPaymentMethod")]
    [DisableDefaultCtor]
    interface STPPaymentMethod : /*STPAPIResponseDecodable,*/ STPPaymentOption
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull stripeId;
        [Export("stripeId")]
        string StripeId { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable created;
        [NullAllowed, Export("created", ArgumentSemantic.Copy)]
        NSDate Created { get; }

        // @property (readonly, nonatomic) BOOL liveMode;
        [Export("liveMode")]
        bool LiveMode { get; }

        // @property (readonly, nonatomic) enum STPPaymentMethodType type;
        [Export("type")]
        STPPaymentMethodType Type { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodBillingDetails * _Nullable billingDetails;
        [NullAllowed, Export("billingDetails", ArgumentSemantic.Strong)]
        STPPaymentMethodBillingDetails BillingDetails { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodAlipay * _Nullable alipay;
        [NullAllowed, Export("alipay", ArgumentSemantic.Strong)]
        STPPaymentMethodAlipay Alipay { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodGrabPay * _Nullable grabPay;
        [NullAllowed, Export("grabPay", ArgumentSemantic.Strong)]
        STPPaymentMethodGrabPay GrabPay { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodCard * _Nullable card;
        [NullAllowed, Export("card", ArgumentSemantic.Strong)]
        STPPaymentMethodCard Card { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodiDEAL * _Nullable iDEAL;
        [NullAllowed, Export("iDEAL", ArgumentSemantic.Strong)]
        STPPaymentMethodiDEAL IDEAL { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodFPX * _Nullable fpx;
        [NullAllowed, Export("fpx", ArgumentSemantic.Strong)]
        STPPaymentMethodFPX Fpx { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodCardPresent * _Nullable cardPresent;
        [NullAllowed, Export("cardPresent", ArgumentSemantic.Strong)]
        STPPaymentMethodCardPresent CardPresent { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodSEPADebit * _Nullable sepaDebit;
        [NullAllowed, Export("sepaDebit", ArgumentSemantic.Strong)]
        STPPaymentMethodSEPADebit SepaDebit { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodBacsDebit * _Nullable bacsDebit;
        [NullAllowed, Export("bacsDebit", ArgumentSemantic.Strong)]
        STPPaymentMethodBacsDebit BacsDebit { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodAUBECSDebit * _Nullable auBECSDebit;
        [NullAllowed, Export("auBECSDebit", ArgumentSemantic.Strong)]
        STPPaymentMethodAUBECSDebit AuBECSDebit { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodGiropay * _Nullable giropay;
        [NullAllowed, Export("giropay", ArgumentSemantic.Strong)]
        STPPaymentMethodGiropay Giropay { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodEPS * _Nullable eps;
        [NullAllowed, Export("eps", ArgumentSemantic.Strong)]
        STPPaymentMethodEPS Eps { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodPrzelewy24 * _Nullable przelewy24;
        [NullAllowed, Export("przelewy24", ArgumentSemantic.Strong)]
        STPPaymentMethodPrzelewy24 Przelewy24 { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodBancontact * _Nullable bancontact;
        [NullAllowed, Export("bancontact", ArgumentSemantic.Strong)]
        STPPaymentMethodBancontact Bancontact { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodNetBanking * _Nullable netBanking;
        [NullAllowed, Export("netBanking", ArgumentSemantic.Strong)]
        STPPaymentMethodNetBanking NetBanking { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodOXXO * _Nullable oxxo;
        [NullAllowed, Export("oxxo", ArgumentSemantic.Strong)]
        STPPaymentMethodOXXO Oxxo { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodSofort * _Nullable sofort;
        [NullAllowed, Export("sofort", ArgumentSemantic.Strong)]
        STPPaymentMethodSofort Sofort { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodUPI * _Nullable upi;
        [NullAllowed, Export("upi", ArgumentSemantic.Strong)]
        STPPaymentMethodUPI Upi { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodPayPal * _Nullable payPal;
        [NullAllowed, Export("payPal", ArgumentSemantic.Strong)]
        STPPaymentMethodPayPal PayPal { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodAfterpayClearpay * _Nullable afterpayClearpay;
        [NullAllowed, Export("afterpayClearpay", ArgumentSemantic.Strong)]
        STPPaymentMethodAfterpayClearpay AfterpayClearpay { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodBLIK * _Nullable blik;
        [NullAllowed, Export("blik", ArgumentSemantic.Strong)]
        STPPaymentMethodBLIK Blik { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodBoleto * _Nullable boleto;
        [NullAllowed, Export("boleto", ArgumentSemantic.Strong)]
        STPPaymentMethodBoleto Boleto { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodLink * _Nullable link;
        [NullAllowed, Export("link", ArgumentSemantic.Strong)]
        STPPaymentMethodLink Link { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodKlarna * _Nullable klarna;
        [NullAllowed, Export("klarna", ArgumentSemantic.Strong)]
        STPPaymentMethodKlarna Klarna { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodAffirm * _Nullable affirm;
        [NullAllowed, Export("affirm", ArgumentSemantic.Strong)]
        STPPaymentMethodAffirm Affirm { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodUSBankAccount * _Nullable usBankAccount;
        [NullAllowed, Export("usBankAccount", ArgumentSemantic.Strong)]
        STPPaymentMethodUSBankAccount UsBankAccount { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable customerId;
        [NullAllowed, Export("customerId")]
        string CustomerId { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.") NSDictionary<NSString *,NSString *> * metadata __attribute__((deprecated("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
        [Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Metadata { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethod DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
        [Export("templateImage", ArgumentSemantic.Strong)]
        UIImage TemplateImage { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull label;
        [Export("label")]
        string Label { get; }

        // @property (readonly, nonatomic) BOOL isReusable;
        [Export("isReusable")]
        bool IsReusable { get; }
    }

    // @interface STPPaymentMethodAUBECSDebit : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe27STPPaymentMethodAUBECSDebit")]
    [DisableDefaultCtor]
    interface STPPaymentMethodAUBECSDebit //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull bsbNumber;
        [Export("bsbNumber")]
        string BsbNumber { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull fingerprint;
        [Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull last4;
        [Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodAUBECSDebit DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodAUBECSDebitParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe33STPPaymentMethodAUBECSDebitParams")]
    interface STPPaymentMethodAUBECSDebitParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accountNumber;
        [NullAllowed, Export("accountNumber")]
        string AccountNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable bsbNumber;
        [NullAllowed, Export("bsbNumber")]
        string BsbNumber { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodAddress : NSObject <STPAPIResponseDecodable, STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPPaymentMethodAddress")]
    interface STPPaymentMethodAddress : /*STPAPIResponseDecodable,*/ STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable city;
        [NullAllowed, Export("city")]
        string City { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable line1;
        [NullAllowed, Export("line1")]
        string Line1 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable line2;
        [NullAllowed, Export("line2")]
        string Line2 { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable postalCode;
        [NullAllowed, Export("postalCode")]
        string PostalCode { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable state;
        [NullAllowed, Export("state")]
        string State { get; set; }

        // -(instancetype _Nonnull)initWithAddress:(STPAddress * _Nonnull)address __attribute__((objc_designated_initializer));
        [Export("initWithAddress:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPAddress address);

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodAddress DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodAffirm : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPPaymentMethodAffirm")]
    [DisableDefaultCtor]
    interface STPPaymentMethodAffirm //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodAffirm DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodAffirmParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPPaymentMethodAffirmParams")]
    interface STPPaymentMethodAffirmParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodAfterpayClearpay : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe32STPPaymentMethodAfterpayClearpay")]
    [DisableDefaultCtor]
    interface STPPaymentMethodAfterpayClearpay //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodAfterpayClearpay DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodAfterpayClearpayParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe38STPPaymentMethodAfterpayClearpayParams")]
    interface STPPaymentMethodAfterpayClearpayParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodAlipay : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPPaymentMethodAlipay")]
    [DisableDefaultCtor]
    interface STPPaymentMethodAlipay //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodAlipay DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodAlipayParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPPaymentMethodAlipayParams")]
    interface STPPaymentMethodAlipayParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodBLIK : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe20STPPaymentMethodBLIK")]
    [DisableDefaultCtor]
    interface STPPaymentMethodBLIK //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodBLIK DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodBLIKParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodBLIKParams")]
    interface STPPaymentMethodBLIKParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodBacsDebit : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe25STPPaymentMethodBacsDebit")]
    [DisableDefaultCtor]
    interface STPPaymentMethodBacsDebit// : STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
        [NullAllowed, Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable sortCode;
        [NullAllowed, Export("sortCode")]
        string SortCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodBacsDebit DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodBacsDebitParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe31STPPaymentMethodBacsDebitParams")]
    interface STPPaymentMethodBacsDebitParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accountNumber;
        [NullAllowed, Export("accountNumber")]
        string AccountNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable sortCode;
        [NullAllowed, Export("sortCode")]
        string SortCode { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodBancontact : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodBancontact")]
    [DisableDefaultCtor]
    interface STPPaymentMethodBancontact //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodBancontact DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodBancontactParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe32STPPaymentMethodBancontactParams")]
    interface STPPaymentMethodBancontactParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodBillingDetails : NSObject <STPAPIResponseDecodable, STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe30STPPaymentMethodBillingDetails")]
    interface STPPaymentMethodBillingDetails : /*STPAPIResponseDecodable,*/ STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodAddress * _Nullable address;
        [NullAllowed, Export("address", ArgumentSemantic.Strong)]
        STPPaymentMethodAddress Address { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; set; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodBillingDetails DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodBoleto : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPPaymentMethodBoleto")]
    [DisableDefaultCtor]
    interface STPPaymentMethodBoleto //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull taxID;
        [Export("taxID")]
        string TaxID { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodBoleto DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodBoletoParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPPaymentMethodBoletoParams")]
    interface STPPaymentMethodBoletoParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSString * _Nullable taxID;
        [NullAllowed, Export("taxID")]
        string TaxID { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodCard : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe20STPPaymentMethodCard")]
    [DisableDefaultCtor]
    interface STPPaymentMethodCard //: STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) enum STPCardBrand brand;
        [Export("brand")]
        STPCardBrand Brand { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodCardChecks * _Nullable checks;
        [NullAllowed, Export("checks", ArgumentSemantic.Strong)]
        STPPaymentMethodCardChecks Checks { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, nonatomic) NSInteger expMonth;
        [Export("expMonth")]
        nint ExpMonth { get; }

        // @property (readonly, nonatomic) NSInteger expYear;
        [Export("expYear")]
        nint ExpYear { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable funding;
        [NullAllowed, Export("funding")]
        string Funding { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
        [NullAllowed, Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodCardNetworks * _Nullable networks;
        [NullAllowed, Export("networks", ArgumentSemantic.Strong)]
        STPPaymentMethodCardNetworks Networks { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodThreeDSecureUsage * _Nullable threeDSecureUsage;
        [NullAllowed, Export("threeDSecureUsage", ArgumentSemantic.Strong)]
        STPPaymentMethodThreeDSecureUsage ThreeDSecureUsage { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodCardWallet * _Nullable wallet;
        [NullAllowed, Export("wallet", ArgumentSemantic.Strong)]
        STPPaymentMethodCardWallet Wallet { get; }

        // +(NSString * _Nonnull)stringFromBrand:(enum STPCardBrand)brand __attribute__((warn_unused_result("")));
        [Static]
        [Export("stringFromBrand:")]
        string StringFromBrand(STPCardBrand brand);

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodCard DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodCardChecks : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodCardChecks")]
    [DisableDefaultCtor]
    interface STPPaymentMethodCardChecks //: STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) enum STPPaymentMethodCardCheckResult addressLine1Check __attribute__((deprecated("Card check values are no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
        [Export("addressLine1Check")]
        STPPaymentMethodCardCheckResult AddressLine1Check { get; }

        // @property (readonly, nonatomic) enum STPPaymentMethodCardCheckResult addressPostalCodeCheck __attribute__((deprecated("Card check values are no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
        [Export("addressPostalCodeCheck")]
        STPPaymentMethodCardCheckResult AddressPostalCodeCheck { get; }

        // @property (readonly, nonatomic) enum STPPaymentMethodCardCheckResult cvcCheck __attribute__((deprecated("Card check values are no longer returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
        [Export("cvcCheck")]
        STPPaymentMethodCardCheckResult CvcCheck { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodCardChecks DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodCardNetworks : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPPaymentMethodCardNetworks")]
    [DisableDefaultCtor]
    interface STPPaymentMethodCardNetworks //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull available;
        [Export("available", ArgumentSemantic.Copy)]
        string[] Available { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable preferred;
        [NullAllowed, Export("preferred")]
        string Preferred { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodCardNetworks DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodCardParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodCardParams")]
    interface STPPaymentMethodCardParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(instancetype _Nonnull)initWithCardSourceParams:(STPCardParams * _Nonnull)cardSourceParams;
        [Export("initWithCardSourceParams:")]
        IntPtr Constructor(STPCardParams cardSourceParams);

        // @property (copy, nonatomic) NSString * _Nullable number;
        [NullAllowed, Export("number")]
        string Number { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable expMonth;
        [NullAllowed, Export("expMonth", ArgumentSemantic.Strong)]
        NSNumber ExpMonth { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable expYear;
        [NullAllowed, Export("expYear", ArgumentSemantic.Strong)]
        NSNumber ExpYear { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable token;
        [NullAllowed, Export("token")]
        string Token { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable cvc;
        [NullAllowed, Export("cvc")]
        string Cvc { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // -(BOOL)isEqual:(id _Nullable)other __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject other);
    }

    // @interface STPPaymentMethodCardPresent : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe27STPPaymentMethodCardPresent")]
    [DisableDefaultCtor]
    interface STPPaymentMethodCardPresent //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodCardPresent DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodCardWallet : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodCardWallet")]
    [DisableDefaultCtor]
    interface STPPaymentMethodCardWallet //: STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) enum STPPaymentMethodCardWalletType type;
        [Export("type")]
        STPPaymentMethodCardWalletType Type { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodCardWalletMasterpass * _Nullable masterpass;
        [NullAllowed, Export("masterpass", ArgumentSemantic.Strong)]
        STPPaymentMethodCardWalletMasterpass Masterpass { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodCardWalletVisaCheckout * _Nullable visaCheckout;
        [NullAllowed, Export("visaCheckout", ArgumentSemantic.Strong)]
        STPPaymentMethodCardWalletVisaCheckout VisaCheckout { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodCardWallet DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodCardWalletMasterpass : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe36STPPaymentMethodCardWalletMasterpass")]
    [DisableDefaultCtor]
    interface STPPaymentMethodCardWalletMasterpass //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nullable billingAddress;
        [NullAllowed, Export("billingAddress", ArgumentSemantic.Strong)]
        STPPaymentMethodAddress BillingAddress { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress", ArgumentSemantic.Strong)]
        STPPaymentMethodAddress ShippingAddress { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodCardWalletMasterpass DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodCardWalletVisaCheckout : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe38STPPaymentMethodCardWalletVisaCheckout")]
    [DisableDefaultCtor]
    interface STPPaymentMethodCardWalletVisaCheckout //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nullable billingAddress;
        [NullAllowed, Export("billingAddress", ArgumentSemantic.Strong)]
        STPPaymentMethodAddress BillingAddress { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress", ArgumentSemantic.Strong)]
        STPPaymentMethodAddress ShippingAddress { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodCardWalletVisaCheckout DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodEPS : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe19STPPaymentMethodEPS")]
    [DisableDefaultCtor]
    interface STPPaymentMethodEPS //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodEPS DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodEPSParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe25STPPaymentMethodEPSParams")]
    interface STPPaymentMethodEPSParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodFPX : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe19STPPaymentMethodFPX")]
    [DisableDefaultCtor]
    interface STPPaymentMethodFPX //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable bankIdentifierCode;
        [NullAllowed, Export("bankIdentifierCode")]
        string BankIdentifierCode { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodFPX DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodFPXParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe25STPPaymentMethodFPXParams")]
    interface STPPaymentMethodFPXParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (nonatomic) enum STPFPXBankBrand bank;
        [Export("bank", ArgumentSemantic.Assign)]
        STPFPXBankBrand Bank { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable rawBankString;
        [NullAllowed, Export("rawBankString")]
        string RawBankString { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodGiropay : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPPaymentMethodGiropay")]
    [DisableDefaultCtor]
    interface STPPaymentMethodGiropay //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodGiropay DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodGiropayParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe29STPPaymentMethodGiropayParams")]
    interface STPPaymentMethodGiropayParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodGrabPay : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPPaymentMethodGrabPay")]
    [DisableDefaultCtor]
    interface STPPaymentMethodGrabPay //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodGrabPay DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodGrabPayParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe29STPPaymentMethodGrabPayParams")]
    interface STPPaymentMethodGrabPayParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodKlarna : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPPaymentMethodKlarna")]
    [DisableDefaultCtor]
    interface STPPaymentMethodKlarna //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodKlarna DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodKlarnaParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPPaymentMethodKlarnaParams")]
    interface STPPaymentMethodKlarnaParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodLink : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe20STPPaymentMethodLink")]
    [DisableDefaultCtor]
    interface STPPaymentMethodLink //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodLink DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodLinkParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodLinkParams")]
    interface STPPaymentMethodLinkParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodNetBanking : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodNetBanking")]
    [DisableDefaultCtor]
    interface STPPaymentMethodNetBanking //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull bank;
        [Export("bank")]
        string Bank { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodNetBanking DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodNetBankingParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe32STPPaymentMethodNetBankingParams")]
    interface STPPaymentMethodNetBankingParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable bank;
        [NullAllowed, Export("bank")]
        string Bank { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodOXXO : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe20STPPaymentMethodOXXO")]
    [DisableDefaultCtor]
    interface STPPaymentMethodOXXO //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodOXXO DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodOXXOParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodOXXOParams")]
    interface STPPaymentMethodOXXOParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodParams : NSObject <STPFormEncodable, STPPaymentOption>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPPaymentMethodParams")]
    interface STPPaymentMethodParams : STPFormEncodable, STPPaymentOption
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (nonatomic) enum STPPaymentMethodType type;
        [Export("type", ArgumentSemantic.Assign)]
        STPPaymentMethodType Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable rawTypeString;
        [NullAllowed, Export("rawTypeString")]
        string RawTypeString { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodBillingDetails * _Nullable billingDetails;
        [NullAllowed, Export("billingDetails", ArgumentSemantic.Strong)]
        STPPaymentMethodBillingDetails BillingDetails { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodCardParams * _Nullable card;
        [NullAllowed, Export("card", ArgumentSemantic.Strong)]
        STPPaymentMethodCardParams Card { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodAlipayParams * _Nullable alipay;
        [NullAllowed, Export("alipay", ArgumentSemantic.Strong)]
        STPPaymentMethodAlipayParams Alipay { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodiDEALParams * _Nullable iDEAL;
        [NullAllowed, Export("iDEAL", ArgumentSemantic.Strong)]
        STPPaymentMethodiDEALParams IDEAL { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodFPXParams * _Nullable fpx;
        [NullAllowed, Export("fpx", ArgumentSemantic.Strong)]
        STPPaymentMethodFPXParams Fpx { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodSEPADebitParams * _Nullable sepaDebit;
        [NullAllowed, Export("sepaDebit", ArgumentSemantic.Strong)]
        STPPaymentMethodSEPADebitParams SepaDebit { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodBacsDebitParams * _Nullable bacsDebit;
        [NullAllowed, Export("bacsDebit", ArgumentSemantic.Strong)]
        STPPaymentMethodBacsDebitParams BacsDebit { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodAUBECSDebitParams * _Nullable auBECSDebit;
        [NullAllowed, Export("auBECSDebit", ArgumentSemantic.Strong)]
        STPPaymentMethodAUBECSDebitParams AuBECSDebit { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodGiropayParams * _Nullable giropay;
        [NullAllowed, Export("giropay", ArgumentSemantic.Strong)]
        STPPaymentMethodGiropayParams Giropay { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodPayPalParams * _Nullable payPal;
        [NullAllowed, Export("payPal", ArgumentSemantic.Strong)]
        STPPaymentMethodPayPalParams PayPal { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodPrzelewy24Params * _Nullable przelewy24;
        [NullAllowed, Export("przelewy24", ArgumentSemantic.Strong)]
        STPPaymentMethodPrzelewy24Params Przelewy24 { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodEPSParams * _Nullable eps;
        [NullAllowed, Export("eps", ArgumentSemantic.Strong)]
        STPPaymentMethodEPSParams Eps { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodBancontactParams * _Nullable bancontact;
        [NullAllowed, Export("bancontact", ArgumentSemantic.Strong)]
        STPPaymentMethodBancontactParams Bancontact { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodNetBankingParams * _Nullable netBanking;
        [NullAllowed, Export("netBanking", ArgumentSemantic.Strong)]
        STPPaymentMethodNetBankingParams NetBanking { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodOXXOParams * _Nullable oxxo;
        [NullAllowed, Export("oxxo", ArgumentSemantic.Strong)]
        STPPaymentMethodOXXOParams Oxxo { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodSofortParams * _Nullable sofort;
        [NullAllowed, Export("sofort", ArgumentSemantic.Strong)]
        STPPaymentMethodSofortParams Sofort { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodUPIParams * _Nullable upi;
        [NullAllowed, Export("upi", ArgumentSemantic.Strong)]
        STPPaymentMethodUPIParams Upi { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodGrabPayParams * _Nullable grabPay;
        [NullAllowed, Export("grabPay", ArgumentSemantic.Strong)]
        STPPaymentMethodGrabPayParams GrabPay { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodAfterpayClearpayParams * _Nullable afterpayClearpay;
        [NullAllowed, Export("afterpayClearpay", ArgumentSemantic.Strong)]
        STPPaymentMethodAfterpayClearpayParams AfterpayClearpay { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodBLIKParams * _Nullable blik;
        [NullAllowed, Export("blik", ArgumentSemantic.Strong)]
        STPPaymentMethodBLIKParams Blik { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodBoletoParams * _Nullable boleto;
        [NullAllowed, Export("boleto", ArgumentSemantic.Strong)]
        STPPaymentMethodBoletoParams Boleto { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodLinkParams * _Nullable link;
        [NullAllowed, Export("link", ArgumentSemantic.Strong)]
        STPPaymentMethodLinkParams Link { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodKlarnaParams * _Nullable klarna;
        [NullAllowed, Export("klarna", ArgumentSemantic.Strong)]
        STPPaymentMethodKlarnaParams Klarna { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodAffirmParams * _Nullable affirm;
        [NullAllowed, Export("affirm", ArgumentSemantic.Strong)]
        STPPaymentMethodAffirmParams Affirm { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodUSBankAccountParams * _Nullable usBankAccount;
        [NullAllowed, Export("usBankAccount", ArgumentSemantic.Strong)]
        STPPaymentMethodUSBankAccountParams UsBankAccount { get; set; }

        // @property (copy, nonatomic) NSDictionary<NSString *,NSString *> * _Nullable metadata;
        [NullAllowed, Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Metadata { get; set; }

        // -(instancetype _Nonnull)initWithCard:(STPPaymentMethodCardParams * _Nonnull)card billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithCard:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodCardParams card, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithIDEAL:(STPPaymentMethodiDEALParams * _Nonnull)iDEAL billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithIDEAL:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodiDEALParams iDEAL, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithFpx:(STPPaymentMethodFPXParams * _Nonnull)fpx billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithFpx:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodFPXParams fpx, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithSepaDebit:(STPPaymentMethodSEPADebitParams * _Nonnull)sepaDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithSepaDebit:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodSEPADebitParams sepaDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithBacsDebit:(STPPaymentMethodBacsDebitParams * _Nonnull)bacsDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithBacsDebit:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodBacsDebitParams bacsDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithAubecsDebit:(STPPaymentMethodAUBECSDebitParams * _Nonnull)auBECSDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithAubecsDebit:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodAUBECSDebitParams auBECSDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithGiropay:(STPPaymentMethodGiropayParams * _Nonnull)giropay billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithGiropay:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodGiropayParams giropay, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithEps:(STPPaymentMethodEPSParams * _Nonnull)eps billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithEps:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodEPSParams eps, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithPrzelewy24:(STPPaymentMethodPrzelewy24Params * _Nonnull)przelewy24 billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithPrzelewy24:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodPrzelewy24Params przelewy24, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithBancontact:(STPPaymentMethodBancontactParams * _Nonnull)bancontact billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithBancontact:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodBancontactParams bancontact, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithNetBanking:(STPPaymentMethodNetBankingParams * _Nonnull)netBanking billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithNetBanking:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodNetBankingParams netBanking, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithGrabPay:(STPPaymentMethodGrabPayParams * _Nonnull)grabPay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithGrabPay:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodGrabPayParams grabPay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithOxxo:(STPPaymentMethodOXXOParams * _Nonnull)oxxo billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithOxxo:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodOXXOParams oxxo, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithSofort:(STPPaymentMethodSofortParams * _Nonnull)sofort billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithSofort:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodSofortParams sofort, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithUpi:(STPPaymentMethodUPIParams * _Nonnull)upi billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithUpi:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodUPIParams upi, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithAlipay:(STPPaymentMethodAlipayParams * _Nonnull)alipay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithAlipay:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodAlipayParams alipay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithPayPal:(STPPaymentMethodPayPalParams * _Nonnull)payPal billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithPayPal:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodPayPalParams payPal, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithAfterpayClearpay:(STPPaymentMethodAfterpayClearpayParams * _Nonnull)afterpayClearpay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithAfterpayClearpay:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodAfterpayClearpayParams afterpayClearpay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithBlik:(STPPaymentMethodBLIKParams * _Nonnull)blik billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithBlik:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodBLIKParams blik, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithBoleto:(STPPaymentMethodBoletoParams * _Nonnull)boleto billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithBoleto:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodBoletoParams boleto, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithKlarna:(STPPaymentMethodKlarnaParams * _Nonnull)klarna billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithKlarna:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodKlarnaParams klarna, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithAffirm:(STPPaymentMethodAffirmParams * _Nonnull)affirm metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithAffirm:metadata:")]
        IntPtr Constructor(STPPaymentMethodAffirmParams affirm, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nonnull)initWithUsBankAccount:(STPPaymentMethodUSBankAccountParams * _Nonnull)usBankAccount billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata;
        [Export("initWithUsBankAccount:billingDetails:metadata:")]
        IntPtr Constructor(STPPaymentMethodUSBankAccountParams usBankAccount, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // -(instancetype _Nullable)initWithSingleUsePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod;
        [Export("initWithSingleUsePaymentMethod:")]
        IntPtr Constructor(STPPaymentMethod paymentMethod);

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
        [Export("templateImage", ArgumentSemantic.Strong)]
        UIImage TemplateImage { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull label;
        [Export("label")]
        string Label { get; }

        // @property (readonly, nonatomic) BOOL isReusable;
        [Export("isReusable")]
        bool IsReusable { get; }
    }

    // @interface Stripe_Swift_5418 (STPPaymentMethodParams)
    [Category]
    [BaseType(typeof(STPPaymentMethodParams))]
    interface STPPaymentMethodParams_Stripe_Swift_5418
    {
        // +(STPPaymentMethodParams * _Nonnull)paramsWithCard:(STPPaymentMethodCardParams * _Nonnull)card billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithCard:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithCard(STPPaymentMethodCardParams card, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithiDEAL:(STPPaymentMethodiDEALParams * _Nonnull)iDEAL billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithiDEAL:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithiDEAL(STPPaymentMethodiDEALParams iDEAL, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithFPX:(STPPaymentMethodFPXParams * _Nonnull)fpx billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithFPX:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithFPX(STPPaymentMethodFPXParams fpx, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithSEPADebit:(STPPaymentMethodSEPADebitParams * _Nonnull)sepaDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithSEPADebit:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithSEPADebit(STPPaymentMethodSEPADebitParams sepaDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithBacsDebit:(STPPaymentMethodBacsDebitParams * _Nonnull)bacsDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithBacsDebit:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithBacsDebit(STPPaymentMethodBacsDebitParams bacsDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithAUBECSDebit:(STPPaymentMethodAUBECSDebitParams * _Nonnull)auBECSDebit billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithAUBECSDebit:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithAUBECSDebit(STPPaymentMethodAUBECSDebitParams auBECSDebit, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithGiropay:(STPPaymentMethodGiropayParams * _Nonnull)giropay billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithGiropay:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithGiropay(STPPaymentMethodGiropayParams giropay, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithEPS:(STPPaymentMethodEPSParams * _Nonnull)eps billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithEPS:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithEPS(STPPaymentMethodEPSParams eps, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithPrzelewy24:(STPPaymentMethodPrzelewy24Params * _Nonnull)przelewy24 billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithPrzelewy24:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithPrzelewy24(STPPaymentMethodPrzelewy24Params przelewy24, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithBancontact:(STPPaymentMethodBancontactParams * _Nonnull)bancontact billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithBancontact:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithBancontact(STPPaymentMethodBancontactParams bancontact, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithNetBanking:(STPPaymentMethodNetBankingParams * _Nonnull)netBanking billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithNetBanking:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithNetBanking(STPPaymentMethodNetBankingParams netBanking, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithOXXO:(STPPaymentMethodOXXOParams * _Nonnull)oxxo billingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithOXXO:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithOXXO(STPPaymentMethodOXXOParams oxxo, STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithGrabPay:(STPPaymentMethodGrabPayParams * _Nonnull)grabPay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithGrabPay:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithGrabPay(STPPaymentMethodGrabPayParams grabPay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithSofort:(STPPaymentMethodSofortParams * _Nonnull)sofort billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithSofort:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithSofort(STPPaymentMethodSofortParams sofort, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithUPI:(STPPaymentMethodUPIParams * _Nonnull)upi billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithUPI:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithUPI(STPPaymentMethodUPIParams upi, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithAlipay:(STPPaymentMethodAlipayParams * _Nonnull)alipay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithAlipay:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithAlipay(STPPaymentMethodAlipayParams alipay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithPayPal:(STPPaymentMethodPayPalParams * _Nonnull)payPal billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithPayPal:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithPayPal(STPPaymentMethodPayPalParams payPal, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithAfterpayClearpay:(STPPaymentMethodAfterpayClearpayParams * _Nonnull)afterpayClearpay billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithAfterpayClearpay:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithAfterpayClearpay(STPPaymentMethodAfterpayClearpayParams afterpayClearpay, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithBLIK:(STPPaymentMethodBLIKParams * _Nonnull)blik billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithBLIK:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithBLIK(STPPaymentMethodBLIKParams blik, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithKlarna:(STPPaymentMethodKlarnaParams * _Nonnull)klarna billingDetails:(STPPaymentMethodBillingDetails * _Nullable)billingDetails metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithKlarna:billingDetails:metadata:")]
        STPPaymentMethodParams ParamsWithKlarna(STPPaymentMethodKlarnaParams klarna, [NullAllowed] STPPaymentMethodBillingDetails billingDetails, [NullAllowed] NSDictionary<NSString, NSString> metadata);

        // +(STPPaymentMethodParams * _Nonnull)paramsWithAffirm:(STPPaymentMethodAffirmParams * _Nonnull)affirm metadata:(NSDictionary<NSString *,NSString *> * _Nullable)metadata __attribute__((warn_unused_result("")));
        [Static]
        [Export("paramsWithAffirm:metadata:")]
        STPPaymentMethodParams ParamsWithAffirm(STPPaymentMethodAffirmParams affirm, [NullAllowed] NSDictionary<NSString, NSString> metadata);
    }

    // @interface STPPaymentMethodPayPal : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPPaymentMethodPayPal")]
    [DisableDefaultCtor]
    interface STPPaymentMethodPayPal //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodPayPal DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodPayPalParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPPaymentMethodPayPalParams")]
    interface STPPaymentMethodPayPalParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodPrzelewy24 : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPaymentMethodPrzelewy24")]
    [DisableDefaultCtor]
    interface STPPaymentMethodPrzelewy24 //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodPrzelewy24 DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodPrzelewy24Params : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe32STPPaymentMethodPrzelewy24Params")]
    interface STPPaymentMethodPrzelewy24Params : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodSEPADebit : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe25STPPaymentMethodSEPADebit")]
    [DisableDefaultCtor]
    interface STPPaymentMethodSEPADebit //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable bankCode;
        [NullAllowed, Export("bankCode")]
        string BankCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable branchCode;
        [NullAllowed, Export("branchCode")]
        string BranchCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
        [NullAllowed, Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mandate;
        [NullAllowed, Export("mandate")]
        string Mandate { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodSEPADebit DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodSEPADebitParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe31STPPaymentMethodSEPADebitParams")]
    interface STPPaymentMethodSEPADebitParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable iban;
        [NullAllowed, Export("iban")]
        string Iban { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodSofort : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPPaymentMethodSofort")]
    [DisableDefaultCtor]
    interface STPPaymentMethodSofort //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodSofort DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodSofortParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPPaymentMethodSofortParams")]
    interface STPPaymentMethodSofortParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodThreeDSecureUsage : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe33STPPaymentMethodThreeDSecureUsage")]
    [DisableDefaultCtor]
    interface STPPaymentMethodThreeDSecureUsage //: STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic) BOOL supported;
        [Export("supported")]
        bool Supported { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodThreeDSecureUsage DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodUPI : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe19STPPaymentMethodUPI")]
    [DisableDefaultCtor]
    interface STPPaymentMethodUPI //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull vpa;
        [Export("vpa")]
        string Vpa { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodUPI DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodUPIParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe25STPPaymentMethodUPIParams")]
    interface STPPaymentMethodUPIParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable vpa;
        [NullAllowed, Export("vpa")]
        string Vpa { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodUSBankAccount : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe29STPPaymentMethodUSBankAccount")]
    [DisableDefaultCtor]
    partial interface STPPaymentMethodUSBankAccount
    {
        // @property (readonly, nonatomic) enum STPPaymentMethodUSBankAccountHolderType accountHolderType;
        [Export("accountHolderType")]
        STPPaymentMethodUSBankAccountHolderType AccountHolderType { get; }

        // @property (readonly, nonatomic) enum STPPaymentMethodUSBankAccountType accountType;
        [Export("accountType")]
        STPPaymentMethodUSBankAccountType AccountType { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull bankName;
        [Export("bankName")]
        string BankName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull fingerprint;
        [Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull last4;
        [Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable linkedAccount;
        [NullAllowed, Export("linkedAccount")]
        string LinkedAccount { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodUSBankAccountNetworks * _Nullable networks;
        [NullAllowed, Export("networks", ArgumentSemantic.Strong)]
        STPPaymentMethodUSBankAccountNetworks Networks { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull routingNumber;
        [Export("routingNumber")]
        string RoutingNumber { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }
    }

    //// @interface Stripe_Swift_5835 (STPPaymentMethodUSBankAccount) <STPAPIResponseDecodable>
    //[Category]
    //[BaseType (typeof(STPPaymentMethodUSBankAccount))]
    partial interface STPPaymentMethodUSBankAccount //: STPAPIResponseDecodable
    {
        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodUSBankAccount DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodUSBankAccountNetworks : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe37STPPaymentMethodUSBankAccountNetworks")]
    [DisableDefaultCtor]
    interface STPPaymentMethodUSBankAccountNetworks
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable preferred;
        [NullAllowed, Export("preferred")]
        string Preferred { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull supported;
        [Export("supported", ArgumentSemantic.Copy)]
        string[] Supported { get; }
    }

    // @interface STPPaymentMethodUSBankAccountParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe35STPPaymentMethodUSBankAccountParams")]
    partial interface STPPaymentMethodUSBankAccountParams
    {
        // @property (copy, nonatomic) NSString * _Nullable accountHolderTypeString;
        [NullAllowed, Export("accountHolderTypeString")]
        string AccountHolderTypeString { get; set; }

        // @property (nonatomic) enum STPPaymentMethodUSBankAccountHolderType accountHolderType;
        [Export("accountHolderType", ArgumentSemantic.Assign)]
        STPPaymentMethodUSBankAccountHolderType AccountHolderType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accountNumber;
        [NullAllowed, Export("accountNumber")]
        string AccountNumber { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accountTypeString;
        [NullAllowed, Export("accountTypeString")]
        string AccountTypeString { get; set; }

        // @property (nonatomic) enum STPPaymentMethodUSBankAccountType accountType;
        [Export("accountType", ArgumentSemantic.Assign)]
        STPPaymentMethodUSBankAccountType AccountType { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable routingNumber;
        [NullAllowed, Export("routingNumber")]
        string RoutingNumber { get; set; }

        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }
    }

    // // @interface Stripe_Swift_5894 (STPPaymentMethodUSBankAccountParams) <STPFormEncodable>
    // [Category]
    // [BaseType (typeof(STPPaymentMethodUSBankAccountParams))]
    partial interface STPPaymentMethodUSBankAccountParams : STPFormEncodable
    {
        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentMethodiDEAL : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe21STPPaymentMethodiDEAL")]
    [DisableDefaultCtor]
    interface STPPaymentMethodiDEAL //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable bankName;
        [NullAllowed, Export("bankName")]
        string BankName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable bankIdentifierCode;
        [NullAllowed, Export("bankIdentifierCode")]
        string BankIdentifierCode { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPPaymentMethodiDEAL DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPPaymentMethodiDEALParams : NSObject <STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe27STPPaymentMethodiDEALParams")]
    interface STPPaymentMethodiDEALParams : STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable bankName;
        [NullAllowed, Export("bankName")]
        string BankName { get; set; }

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPPaymentOptionsViewController : STPCoreViewController <STPAddCardViewControllerDelegate>
    [BaseType(typeof(STPCoreViewController), Name = "_TtC6Stripe31STPPaymentOptionsViewController")]
    interface STPPaymentOptionsViewController : STPAddCardViewControllerDelegate
    {
        // -(instancetype _Nonnull)initWithPaymentContext:(STPPaymentContext * _Nonnull)paymentContext;
        [Export("initWithPaymentContext:")]
        IntPtr Constructor(STPPaymentContext paymentContext);

        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme customerContext:(STPCustomerContext * _Nonnull)customerContext delegate:(id<STPPaymentOptionsViewControllerDelegate> _Nonnull)delegate;
        [Export("initWithConfiguration:theme:customerContext:delegate:")]
        IntPtr Constructor(STPPaymentConfiguration configuration, STPTheme theme, STPCustomerContext customerContext, STPPaymentOptionsViewControllerDelegate @delegate);

        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme apiAdapter:(id<STPBackendAPIAdapter> _Nonnull)apiAdapter delegate:(id<STPPaymentOptionsViewControllerDelegate> _Nonnull)delegate __attribute__((objc_designated_initializer));
        [Export("initWithConfiguration:theme:apiAdapter:delegate:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPPaymentConfiguration configuration, STPTheme theme, STPBackendAPIAdapter apiAdapter, STPPaymentOptionsViewControllerDelegate @delegate);

        // @property (nonatomic, strong) STPUserInformation * _Nullable prefilledInformation;
        [NullAllowed, Export("prefilledInformation", ArgumentSemantic.Strong)]
        STPUserInformation PrefilledInformation { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable defaultPaymentMethod;
        [NullAllowed, Export("defaultPaymentMethod")]
        string DefaultPaymentMethod { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable paymentOptionsViewControllerFooterView;
        [NullAllowed, Export("paymentOptionsViewControllerFooterView", ArgumentSemantic.Strong)]
        UIView PaymentOptionsViewControllerFooterView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable addCardViewControllerFooterView;
        [NullAllowed, Export("addCardViewControllerFooterView", ArgumentSemantic.Strong)]
        UIView AddCardViewControllerFooterView { get; set; }

        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }

        // -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
        [Export("dismissWithCompletion:")]
        void DismissWithCompletion([NullAllowed] Action completion);

        // -(void)viewDidLayoutSubviews;
        [Export("viewDidLayoutSubviews")]
        void ViewDidLayoutSubviews();

        // -(void)viewDidAppear:(BOOL)animated;
        [Export("viewDidAppear:")]
        void ViewDidAppear(bool animated);

        // -(void)addCardViewControllerDidCancel:(STPAddCardViewController * _Nonnull)addCardViewController;
        [Export("addCardViewControllerDidCancel:")]
        void AddCardViewControllerDidCancel(STPAddCardViewController addCardViewController);

        // -(void)addCardViewController:(STPAddCardViewController * _Nonnull)addCardViewController didCreatePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod completion:(void (^ _Nonnull)(NSError * _Nullable))completion;
        [Export("addCardViewController:didCreatePaymentMethod:completion:")]
        void AddCardViewController(STPAddCardViewController addCardViewController, STPPaymentMethod paymentMethod, Action<NSError> completion);
    }

    // @interface STPPaymentResult : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe16STPPaymentResult")]
    [DisableDefaultCtor]
    interface STPPaymentResult
    {
        // @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
        [NullAllowed, Export("paymentMethod", ArgumentSemantic.Strong)]
        STPPaymentMethod PaymentMethod { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethodParams * _Nullable paymentMethodParams;
        [NullAllowed, Export("paymentMethodParams", ArgumentSemantic.Strong)]
        STPPaymentMethodParams PaymentMethodParams { get; }

        // @property (readonly, nonatomic, weak) id<STPPaymentOption> _Nullable paymentOption;
        [NullAllowed, Export("paymentOption", ArgumentSemantic.Weak)]
        STPPaymentOption PaymentOption { get; }

        // -(instancetype _Nonnull)initWithPaymentOption:(id<STPPaymentOption> _Nullable)paymentOption __attribute__((objc_designated_initializer));
        [Export("initWithPaymentOption:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] STPPaymentOption paymentOption);
    }

    // @interface STPPinManagementService : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe23STPPinManagementService")]
    [DisableDefaultCtor]
    interface STPPinManagementService
    {
        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }

        // -(instancetype _Nonnull)initWithKeyProvider:(id<STPIssuingCardEphemeralKeyProvider> _Nonnull)keyProvider __attribute__((objc_designated_initializer));
        [Export("initWithKeyProvider:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPIssuingCardEphemeralKeyProvider keyProvider);

        // -(void)retrievePin:(NSString * _Nonnull)cardId verificationId:(NSString * _Nonnull)verificationId oneTimeCode:(NSString * _Nonnull)oneTimeCode completion:(void (^ _Nonnull)(STPIssuingCardPin * _Nullable, enum STPPinStatus, NSError * _Nullable))completion;
        [Export("retrievePin:verificationId:oneTimeCode:completion:")]
        void RetrievePin(string cardId, string verificationId, string oneTimeCode, Action<STPIssuingCardPin, STPPinStatus, NSError> completion);

        // -(void)updatePin:(NSString * _Nonnull)cardId newPin:(NSString * _Nonnull)newPin verificationId:(NSString * _Nonnull)verificationId oneTimeCode:(NSString * _Nonnull)oneTimeCode completion:(void (^ _Nonnull)(STPIssuingCardPin * _Nullable, enum STPPinStatus, NSError * _Nullable))completion;
        [Export("updatePin:newPin:verificationId:oneTimeCode:completion:")]
        void UpdatePin(string cardId, string newPin, string verificationId, string oneTimeCode, Action<STPIssuingCardPin, STPPinStatus, NSError> completion);
    }

    // @interface STPPushProvisioningContext : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe26STPPushProvisioningContext")]
    [DisableDefaultCtor]
    interface STPPushProvisioningContext
    {
        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }

        // +(PKAddPaymentPassRequestConfiguration * _Nonnull)requestConfigurationWithName:(NSString * _Nonnull)name description:(NSString * _Nullable)description last4:(NSString * _Nullable)last4 brand:(enum STPCardBrand)brand __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `requestConfiguration(withName:description:last4:brand:primaryAccountIdentifier:)` instead.", "requestConfigurationWithName:description:last4:brand:primaryAccountIdentifier:")));
        [Static]
        [Export("requestConfigurationWithName:description:last4:brand:")]
        PKAddPaymentPassRequestConfiguration RequestConfigurationWithName(string name, [NullAllowed] string description, [NullAllowed] string last4, STPCardBrand brand);

        // +(PKAddPaymentPassRequestConfiguration * _Nonnull)requestConfigurationWithName:(NSString * _Nonnull)name description:(NSString * _Nullable)description last4:(NSString * _Nullable)last4 brand:(enum STPCardBrand)brand primaryAccountIdentifier:(NSString * _Nullable)primaryAccountIdentifier __attribute__((warn_unused_result("")));
        [Static]
        [Export("requestConfigurationWithName:description:last4:brand:primaryAccountIdentifier:")]
        PKAddPaymentPassRequestConfiguration RequestConfigurationWithName(string name, [NullAllowed] string description, [NullAllowed] string last4, STPCardBrand brand, [NullAllowed] string primaryAccountIdentifier);

        // -(instancetype _Nonnull)initWithKeyProvider:(id<STPIssuingCardEphemeralKeyProvider> _Nonnull)keyProvider __attribute__((objc_designated_initializer));
        [Export("initWithKeyProvider:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPIssuingCardEphemeralKeyProvider keyProvider);

        // -(void)addPaymentPassViewController:(PKAddPaymentPassViewController * _Nonnull)controller generateRequestWithCertificateChain:(NSArray<NSData *> * _Nonnull)certificates nonce:(NSData * _Nonnull)nonce nonceSignature:(NSData * _Nonnull)nonceSignature completionHandler:(void (^ _Nonnull)(PKAddPaymentPassRequest * _Nonnull))handler;
        [Export("addPaymentPassViewController:generateRequestWithCertificateChain:nonce:nonceSignature:completionHandler:")]
        void AddPaymentPassViewController(PKAddPaymentPassViewController controller, NSData[] certificates, NSData nonce, NSData nonceSignature, Action<PKAddPaymentPassRequest> handler);
    }

    // @interface STPPushProvisioningDetailsParams : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe32STPPushProvisioningDetailsParams")]
    [DisableDefaultCtor]
    interface STPPushProvisioningDetailsParams
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull cardId;
        [Export("cardId")]
        string CardId { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSData *> * _Nonnull certificates;
        [Export("certificates", ArgumentSemantic.Copy)]
        NSData[] Certificates { get; }

        // @property (readonly, copy, nonatomic) NSData * _Nonnull nonce;
        [Export("nonce", ArgumentSemantic.Copy)]
        NSData Nonce { get; }

        // @property (readonly, copy, nonatomic) NSData * _Nonnull nonceSignature;
        [Export("nonceSignature", ArgumentSemantic.Copy)]
        NSData NonceSignature { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSString *> * _Nonnull certificatesBase64;
        [Export("certificatesBase64", ArgumentSemantic.Copy)]
        string[] CertificatesBase64 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull nonceHex;
        [Export("nonceHex")]
        string NonceHex { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull nonceSignatureHex;
        [Export("nonceSignatureHex")]
        string NonceSignatureHex { get; }

        // -(instancetype _Nonnull)initWithCardId:(NSString * _Nonnull)cardId certificates:(NSArray<NSData *> * _Nonnull)certificates nonce:(NSData * _Nonnull)nonce nonceSignature:(NSData * _Nonnull)nonceSignature __attribute__((objc_designated_initializer));
        [Export("initWithCardId:certificates:nonce:nonceSignature:")]
        [DesignatedInitializer]
        IntPtr Constructor(string cardId, NSData[] certificates, NSData nonce, NSData nonceSignature);
    }

    // @interface STPRadarSession : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe15STPRadarSession")]
    [DisableDefaultCtor]
    interface STPRadarSession //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // +(STPRadarSession * _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPRadarSession DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPRedirectContext : NSObject <SFSafariViewControllerDelegate, UIViewControllerTransitioningDelegate>
    // [Unavailable (PlatformName.iOSAppExtension)]
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe18STPRedirectContext")]
    [DisableDefaultCtor]
    interface STPRedirectContext : ISFSafariViewControllerDelegate, IUIViewControllerTransitioningDelegate
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull STPRedirectContextErrorDomain;
        [Static]
        [Export("STPRedirectContextErrorDomain")]
        string STPRedirectContextErrorDomain { get; }

        // @property (readonly, nonatomic) enum STPRedirectContextState state;
        [Export("state")]
        STPRedirectContextState State { get; }

        // -(instancetype _Nullable)initWithSource:(STPSource * _Nonnull)source completion:(void (^ _Nonnull)(NSString * _Nonnull, NSString * _Nullable, NSError * _Nullable))completion;
        [Export("initWithSource:completion:")]
        IntPtr Constructor(STPSource source, Action<NSString, NSString, NSError> completion);

        // -(instancetype _Nullable)initWithPaymentIntent:(STPPaymentIntent * _Nonnull)paymentIntent completion:(void (^ _Nonnull)(NSString * _Nonnull, NSError * _Nullable))completion;
        [Export("initWithPaymentIntent:completion:")]
        IntPtr Constructor(STPPaymentIntent paymentIntent, Action<NSString, NSError> completion);

        // -(void)startRedirectFlowFromViewController:(UIViewController * _Nonnull)presentingViewController;
        [Export("startRedirectFlowFromViewController:")]
        void StartRedirectFlowFromViewController(UIViewController presentingViewController);

        // -(void)startSafariViewControllerRedirectFlowFromViewController:(UIViewController * _Nonnull)presentingViewController;
        [Export("startSafariViewControllerRedirectFlowFromViewController:")]
        void StartSafariViewControllerRedirectFlowFromViewController(UIViewController presentingViewController);

        // -(void)startSafariAppRedirectFlow;
        [Export("startSafariAppRedirectFlow")]
        void StartSafariAppRedirectFlow();

        // -(void)cancel;
        [Export("cancel")]
        void Cancel();

        // -(void)safariViewControllerDidFinish:(SFSafariViewController * _Nonnull)controller;
        [Export("safariViewControllerDidFinish:")]
        void SafariViewControllerDidFinish(SFSafariViewController controller);

        // -(void)safariViewController:(SFSafariViewController * _Nonnull)controller didCompleteInitialLoad:(BOOL)didLoadSuccessfully;
        [Export("safariViewController:didCompleteInitialLoad:")]
        void SafariViewController(SFSafariViewController controller, bool didLoadSuccessfully);

        // -(void)safariViewController:(SFSafariViewController * _Nonnull)controller initialLoadDidRedirectToURL:(NSUrl * _Nonnull)URL;
        [Export("safariViewController:initialLoadDidRedirectToURL:")]
        void SafariViewController(SFSafariViewController controller, NSUrl URL);

        // -(UIPresentationController * _Nullable)presentationControllerForPresentedViewController:(UIViewController * _Nonnull)presented presentingViewController:(UIViewController * _Nullable)presenting sourceViewController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
        [Export("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:")]
        [return: NullAllowed]
        UIPresentationController PresentationControllerForPresentedViewController(UIViewController presented, [NullAllowed] UIViewController presenting, UIViewController source);
    }

    // @interface Stripe_Swift_6317 (STPRedirectContext)
    // [Unavailable (PlatformName.iOSAppExtension)]
    [Category]
    [BaseType(typeof(STPRedirectContext))]
    interface STPRedirectContext_Stripe_Swift_6317
    {
        // -(BOOL)handleURLCallback:(NSUrl * _Nonnull)url __attribute__((warn_unused_result("")));
        [Export("handleURLCallback:")]
        bool HandleURLCallback(NSUrl url);
    }

    // @interface STPSetupIntent : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe14STPSetupIntent")]
    [DisableDefaultCtor]
    interface STPSetupIntent //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
        [Export("stripeID")]
        string StripeID { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull clientSecret;
        [Export("clientSecret")]
        string ClientSecret { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nonnull created;
        [Export("created", ArgumentSemantic.Copy)]
        NSDate Created { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable customerID;
        [NullAllowed, Export("customerID")]
        string CustomerID { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable stripeDescription;
        [NullAllowed, Export("stripeDescription")]
        string StripeDescription { get; }

        // @property (readonly, nonatomic) BOOL livemode;
        [Export("livemode")]
        bool Livemode { get; }

        // @property (readonly, nonatomic, strong) STPIntentAction * _Nullable nextAction;
        [NullAllowed, Export("nextAction", ArgumentSemantic.Strong)]
        STPIntentAction NextAction { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable paymentMethodID;
        [NullAllowed, Export("paymentMethodID")]
        string PaymentMethodID { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
        [NullAllowed, Export("paymentMethod", ArgumentSemantic.Strong)]
        STPPaymentMethod PaymentMethod { get; }

        // @property (readonly, copy, nonatomic) NSArray<NSNumber *> * _Nonnull paymentMethodTypes;
        [Export("paymentMethodTypes", ArgumentSemantic.Copy)]
        NSNumber[] PaymentMethodTypes { get; }

        // @property (readonly, nonatomic) enum STPSetupIntentStatus status;
        [Export("status")]
        STPSetupIntentStatus Status { get; }

        // @property (readonly, nonatomic) enum STPSetupIntentUsage usage;
        [Export("usage")]
        STPSetupIntentUsage Usage { get; }

        // @property (readonly, nonatomic, strong) STPSetupIntentLastSetupError * _Nullable lastSetupError;
        [NullAllowed, Export("lastSetupError", ArgumentSemantic.Strong)]
        STPSetupIntentLastSetupError LastSetupError { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Metadata is not returned to clients using publishable keys. Retrieve them on your server using your secret key instead.") NSDictionary<NSString *,NSString *> * metadata __attribute__((deprecated("Metadata is not returned to clients using publishable keys. Retrieve them on your server using your secret key instead.")));
        [Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Metadata { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSetupIntent DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPSetupIntentConfirmParams : NSObject <NSCopying, STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe27STPSetupIntentConfirmParams")]
    [DisableDefaultCtor]
    interface STPSetupIntentConfirmParams : INSCopying, STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // -(instancetype _Nonnull)initWithClientSecret:(NSString * _Nonnull)clientSecret __attribute__((objc_designated_initializer));
        [Export("initWithClientSecret:")]
        [DesignatedInitializer]
        IntPtr Constructor(string clientSecret);

        // -(instancetype _Nonnull)initWithClientSecret:(NSString * _Nonnull)clientSecret paymentMethodType:(enum STPPaymentMethodType)paymentMethodType __attribute__((objc_designated_initializer));
        [Export("initWithClientSecret:paymentMethodType:")]
        [DesignatedInitializer]
        IntPtr Constructor(string clientSecret, STPPaymentMethodType paymentMethodType);

        // @property (copy, nonatomic) NSString * _Nonnull clientSecret;
        [Export("clientSecret")]
        string ClientSecret { get; set; }

        // @property (nonatomic, strong) STPPaymentMethodParams * _Nullable paymentMethodParams;
        [NullAllowed, Export("paymentMethodParams", ArgumentSemantic.Strong)]
        STPPaymentMethodParams PaymentMethodParams { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable paymentMethodID;
        [NullAllowed, Export("paymentMethodID")]
        string PaymentMethodID { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable returnURL;
        [NullAllowed, Export("returnURL")]
        string ReturnURL { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable useStripeSDK;
        [NullAllowed, Export("useStripeSDK", ArgumentSemantic.Strong)]
        NSNumber UseStripeSDK { get; set; }

        // @property (nonatomic, strong) STPMandateDataParams * _Nullable mandateData;
        [NullAllowed, Export("mandateData", ArgumentSemantic.Strong)]
        STPMandateDataParams MandateData { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }
    }

    // @interface STPSetupIntentLastSetupError : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPSetupIntentLastSetupError")]
    [DisableDefaultCtor]
    partial interface STPSetupIntentLastSetupError //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable code;
        [NullAllowed, Export("code")]
        string Code { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable declineCode;
        [NullAllowed, Export("declineCode")]
        string DeclineCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable docURL;
        [NullAllowed, Export("docURL")]
        string DocURL { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable message;
        [NullAllowed, Export("message")]
        string Message { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable param;
        [NullAllowed, Export("param")]
        string Param { get; }

        // @property (readonly, nonatomic, strong) STPPaymentMethod * _Nullable paymentMethod;
        [NullAllowed, Export("paymentMethod", ArgumentSemantic.Strong)]
        STPPaymentMethod PaymentMethod { get; }

        // @property (readonly, nonatomic) enum STPSetupIntentLastSetupErrorType type;
        [Export("type")]
        STPSetupIntentLastSetupErrorType Type { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSetupIntentLastSetupError DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    //// @interface Stripe_Swift_6480 (STPSetupIntentLastSetupError)
    //[Category]
    //[BaseType (typeof(STPSetupIntentLastSetupError))]
    partial interface STPSetupIntentLastSetupError
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull CodeAuthenticationFailure;
        [Export("CodeAuthenticationFailure")]
        string CodeAuthenticationFailure { get; }
    }

    // @interface STPShippingAddressViewController : STPCoreTableViewController
    [BaseType(typeof(STPCoreTableViewController), Name = "_TtC6Stripe32STPShippingAddressViewController")]
    partial interface STPShippingAddressViewController
    {
        // -(instancetype _Nonnull)initWithPaymentContext:(STPPaymentContext * _Nonnull)paymentContext;
        [Export("initWithPaymentContext:")]
        IntPtr Constructor(STPPaymentContext paymentContext);

        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration theme:(STPTheme * _Nonnull)theme currency:(NSString * _Nullable)currency shippingAddress:(STPAddress * _Nullable)shippingAddress selectedShippingMethod:(PKShippingMethod * _Nullable)selectedShippingMethod prefilledInformation:(STPUserInformation * _Nullable)prefilledInformation __attribute__((objc_designated_initializer));
        [Export("initWithConfiguration:theme:currency:shippingAddress:selectedShippingMethod:prefilledInformation:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPPaymentConfiguration configuration, STPTheme theme, [NullAllowed] string currency, [NullAllowed] STPAddress shippingAddress, [NullAllowed] PKShippingMethod selectedShippingMethod, [NullAllowed] STPUserInformation prefilledInformation);

        [Wrap("WeakDelegate")]
        [NullAllowed]
        STPShippingAddressViewControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<STPShippingAddressViewControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
        [Export("dismissWithCompletion:")]
        void DismissWithCompletion([NullAllowed] Action completion);

        // -(void)viewDidAppear:(BOOL)animated;
        [Export("viewDidAppear:")]
        void ViewDidAppear(bool animated);

        // -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        [Export("tableView:heightForHeaderInSection:")]
        nfloat TableView(UITableView tableView, nint section);
    }

    //// @interface Stripe_Swift_6586 (STPShippingAddressViewController) <UITableViewDataSource, UITableViewDelegate>
    //[Category]
    //[BaseType(typeof(STPShippingAddressViewController))]
    partial interface STPShippingAddressViewController : IUITableViewDataSource, IUITableViewDelegate
    {
        // -(NSInteger)numberOfSectionsInTableView:(UITableView * _Nonnull)tableView __attribute__((warn_unused_result("")));
        [Export("numberOfSectionsInTableView:")]
        nint NumberOfSectionsInTableView(UITableView tableView);

        //// -(NSInteger)tableView:(UITableView * _Nonnull)tableView numberOfRowsInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:numberOfRowsInSection:")]
        //nint TableView(UITableView tableView, nint section);

        // -(UITableViewCell * _Nonnull)tableView:(UITableView * _Nonnull)tableView cellForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((warn_unused_result("")));
        [Export("tableView:cellForRowAtIndexPath:")]
        UITableViewCell TableView(UITableView tableView, NSIndexPath indexPath);

        // -(void)tableView:(UITableView * _Nonnull)tableView willDisplayCell:(UITableViewCell * _Nonnull)cell forRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
        [Export("tableView:willDisplayCell:forRowAtIndexPath:")]
        void TableView(UITableView tableView, UITableViewCell cell, NSIndexPath indexPath);

        //// -(CGFloat)tableView:(UITableView * _Nonnull)tableView heightForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:heightForFooterInSection:")]
        //nfloat TableView(UITableView tableView, nint section);

        //// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForFooterInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:viewForFooterInSection:")]
        //[return: NullAllowed]
        //UIView TableView(UITableView tableView, nint section);

        //// -(UIView * _Nullable)tableView:(UITableView * _Nonnull)tableView viewForHeaderInSection:(NSInteger)section __attribute__((warn_unused_result("")));
        //[Export("tableView:viewForHeaderInSection:")]
        //[return: NullAllowed]
        //UIView TableView(UITableView tableView, nint section);
    }

    // @interface STPSource : NSObject <STPAPIResponseDecodable, STPPaymentOption, STPSourceProtocol>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe9STPSource")]
    [DisableDefaultCtor]
    interface STPSource : /*STPAPIResponseDecodable,*/ STPPaymentOption, STPSourceProtocol
    {
        // @property (readonly, nonatomic, strong) NSNumber * _Nullable amount;
        [NullAllowed, Export("amount", ArgumentSemantic.Strong)]
        NSNumber Amount { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable clientSecret;
        [NullAllowed, Export("clientSecret")]
        string ClientSecret { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable created;
        [NullAllowed, Export("created", ArgumentSemantic.Copy)]
        NSDate Created { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; }

        // @property (readonly, nonatomic) enum STPSourceFlow flow;
        [Export("flow")]
        STPSourceFlow Flow { get; }

        // @property (readonly, nonatomic) BOOL livemode;
        [Export("livemode")]
        bool Livemode { get; }

        // @property (readonly, nonatomic, strong) STPSourceOwner * _Nullable owner;
        [NullAllowed, Export("owner", ArgumentSemantic.Strong)]
        STPSourceOwner Owner { get; }

        // @property (readonly, nonatomic, strong) STPSourceReceiver * _Nullable receiver;
        [NullAllowed, Export("receiver", ArgumentSemantic.Strong)]
        STPSourceReceiver Receiver { get; }

        // @property (readonly, nonatomic, strong) STPSourceRedirect * _Nullable redirect;
        [NullAllowed, Export("redirect", ArgumentSemantic.Strong)]
        STPSourceRedirect Redirect { get; }

        // @property (readonly, nonatomic) enum STPSourceStatus status;
        [Export("status")]
        STPSourceStatus Status { get; }

        // @property (readonly, nonatomic) enum STPSourceType type;
        [Export("type")]
        STPSourceType Type { get; }

        // @property (readonly, nonatomic) enum STPSourceUsage usage;
        [Export("usage")]
        STPSourceUsage Usage { get; }

        // @property (readonly, nonatomic, strong) STPSourceVerification * _Nullable verification;
        [NullAllowed, Export("verification", ArgumentSemantic.Strong)]
        STPSourceVerification Verification { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nullable details;
        [NullAllowed, Export("details", ArgumentSemantic.Copy)]
        NSDictionary Details { get; }

        // @property (readonly, nonatomic, strong) STPSourceCardDetails * _Nullable cardDetails;
        [NullAllowed, Export("cardDetails", ArgumentSemantic.Strong)]
        STPSourceCardDetails CardDetails { get; }

        // @property (readonly, nonatomic, strong) STPSourceKlarnaDetails * _Nullable klarnaDetails;
        [NullAllowed, Export("klarnaDetails", ArgumentSemantic.Strong)]
        STPSourceKlarnaDetails KlarnaDetails { get; }

        // @property (readonly, nonatomic, strong) STPSourceSEPADebitDetails * _Nullable sepaDebitDetails;
        [NullAllowed, Export("sepaDebitDetails", ArgumentSemantic.Strong)]
        STPSourceSEPADebitDetails SepaDebitDetails { get; }

        // @property (readonly, nonatomic, strong) STPSourceWeChatPayDetails * _Nullable weChatPayDetails;
        [NullAllowed, Export("weChatPayDetails", ArgumentSemantic.Strong)]
        STPSourceWeChatPayDetails WeChatPayDetails { get; }

        // @property (readonly, copy, nonatomic) SWIFT_DEPRECATED_MSG("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using yoursecret key instead.") NSDictionary<NSString *,NSString *> * metadata __attribute__((deprecated("Metadata is no longer returned to clients using publishable keys. Retrieve them on your server using yoursecret key instead.")));
        [Export("metadata", ArgumentSemantic.Copy)]
        NSDictionary<NSString, NSString> Metadata { get; }

        // @property (copy, nonatomic) NSString * _Nonnull stripeID;
        [Export("stripeID")]
        string StripeID { get; set; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSource DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull image;
        [Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nonnull templateImage;
        [Export("templateImage", ArgumentSemantic.Strong)]
        UIImage TemplateImage { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull label;
        [Export("label")]
        string Label { get; }

        // @property (readonly, nonatomic) BOOL isReusable;
        [Export("isReusable")]
        bool IsReusable { get; }
    }

    // @interface STPSourceCardDetails : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe20STPSourceCardDetails")]
    [DisableDefaultCtor]
    interface STPSourceCardDetails //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, nonatomic) NSUInteger expMonth;
        [Export("expMonth")]
        nuint ExpMonth { get; }

        // @property (readonly, nonatomic) NSUInteger expYear;
        [Export("expYear")]
        nuint ExpYear { get; }

        // @property (readonly, nonatomic) enum STPCardBrand brand;
        [Export("brand")]
        STPCardBrand Brand { get; }

        // @property (readonly, nonatomic) enum STPCardFundingType funding;
        [Export("funding")]
        STPCardFundingType Funding { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, nonatomic) enum STPSourceCard3DSecureStatus threeDSecure;
        [Export("threeDSecure")]
        STPSourceCard3DSecureStatus ThreeDSecure { get; }

        // @property (readonly, nonatomic) BOOL isApplePayCard;
        [Export("isApplePayCard")]
        bool IsApplePayCard { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSourceCardDetails DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }
    }

    // @interface STPSourceKlarnaDetails : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPSourceKlarnaDetails")]
    [DisableDefaultCtor]
    interface STPSourceKlarnaDetails //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable clientToken;
        [NullAllowed, Export("clientToken")]
        string ClientToken { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable purchaseCountry;
        [NullAllowed, Export("purchaseCountry")]
        string PurchaseCountry { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSourceKlarnaDetails DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPSourceOwner : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe14STPSourceOwner")]
    [DisableDefaultCtor]
    interface STPSourceOwner //: STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic, strong) STPAddress * _Nullable address;
        [NullAllowed, Export("address", ArgumentSemantic.Strong)]
        STPAddress Address { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable email;
        [NullAllowed, Export("email")]
        string Email { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable name;
        [NullAllowed, Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable phone;
        [NullAllowed, Export("phone")]
        string Phone { get; }

        // @property (readonly, nonatomic, strong) STPAddress * _Nullable verifiedAddress;
        [NullAllowed, Export("verifiedAddress", ArgumentSemantic.Strong)]
        STPAddress VerifiedAddress { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable verifiedEmail;
        [NullAllowed, Export("verifiedEmail")]
        string VerifiedEmail { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable verifiedName;
        [NullAllowed, Export("verifiedName")]
        string VerifiedName { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable verifiedPhone;
        [NullAllowed, Export("verifiedPhone")]
        string VerifiedPhone { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSourceOwner DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPSourceParams : NSObject <NSCopying, STPFormEncodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe15STPSourceParams")]
    interface STPSourceParams : INSCopying, STPFormEncodable
    {
        // @property (copy, nonatomic) NSDictionary * _Nonnull additionalAPIParameters;
        [Export("additionalAPIParameters", ArgumentSemantic.Copy)]
        NSDictionary AdditionalAPIParameters { get; set; }

        // @property (nonatomic) enum STPSourceType type;
        [Export("type", ArgumentSemantic.Assign)]
        STPSourceType Type { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable rawTypeString;
        [NullAllowed, Export("rawTypeString")]
        string RawTypeString { get; set; }

        // @property (nonatomic, strong) NSNumber * _Nullable amount;
        [NullAllowed, Export("amount", ArgumentSemantic.Strong)]
        NSNumber Amount { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable currency;
        [NullAllowed, Export("currency")]
        string Currency { get; set; }

        // @property (nonatomic) enum STPSourceFlow flow;
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

        // @property (nonatomic) enum STPSourceUsage usage;
        [Export("usage", ArgumentSemantic.Assign)]
        STPSourceUsage Usage { get; set; }

        // +(STPSourceParams * _Nonnull)bancontactParamsWithAmount:(NSInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
        [Export("bancontactParamsWithAmount:name:returnURL:statementDescriptor:")]
        STPSourceParams BancontactParamsWithAmount(nint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

        // +(STPSourceParams * _Nonnull)cardParamsWithCard:(STPCardParams * _Nonnull)card __attribute__((warn_unused_result("")));
        [Export("cardParamsWithCard:")]
        STPSourceParams CardParamsWithCard(STPCardParams card);

        // +(STPSourceParams * _Nonnull)giropayParamsWithAmount:(NSInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
        [Export("giropayParamsWithAmount:name:returnURL:statementDescriptor:")]
        STPSourceParams GiropayParamsWithAmount(nint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

        // +(STPSourceParams * _Nonnull)idealParamsWithAmount:(NSInteger)amount name:(NSString * _Nullable)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor bank:(NSString * _Nullable)bank __attribute__((warn_unused_result("")));
        [Export("idealParamsWithAmount:name:returnURL:statementDescriptor:bank:")]
        STPSourceParams IdealParamsWithAmount(nint amount, [NullAllowed] string name, string returnURL, [NullAllowed] string statementDescriptor, [NullAllowed] string bank);

        // +(STPSourceParams * _Nonnull)sepaDebitParamsWithName:(NSString * _Nonnull)name iban:(NSString * _Nonnull)iban addressLine1:(NSString * _Nullable)addressLine1 city:(NSString * _Nullable)city postalCode:(NSString * _Nullable)postalCode country:(NSString * _Nullable)country __attribute__((warn_unused_result("")));
        [Export("sepaDebitParamsWithName:iban:addressLine1:city:postalCode:country:")]
        STPSourceParams SepaDebitParamsWithName(string name, string iban, [NullAllowed] string addressLine1, [NullAllowed] string city, [NullAllowed] string postalCode, [NullAllowed] string country);

        // +(STPSourceParams * _Nonnull)sofortParamsWithAmount:(NSInteger)amount returnURL:(NSString * _Nonnull)returnURL country:(NSString * _Nonnull)country statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
        [Export("sofortParamsWithAmount:returnURL:country:statementDescriptor:")]
        STPSourceParams SofortParamsWithAmount(nint amount, string returnURL, string country, [NullAllowed] string statementDescriptor);

        // +(STPSourceParams * _Nonnull)klarnaParamsWithReturnURL:(NSString * _Nonnull)returnURL currency:(NSString * _Nonnull)currency purchaseCountry:(NSString * _Nonnull)purchaseCountry items:(NSArray<STPKlarnaLineItem *> * _Nonnull)items customPaymentMethods:(NSArray<NSNumber *> * _Nonnull)customPaymentMethods billingAddress:(STPAddress * _Nullable)address billingFirstName:(NSString * _Nullable)firstName billingLastName:(NSString * _Nullable)lastName billingDOB:(STPDateOfBirth * _Nullable)dateOfBirth __attribute__((warn_unused_result("")));
        [Export("klarnaParamsWithReturnURL:currency:purchaseCountry:items:customPaymentMethods:billingAddress:billingFirstName:billingLastName:billingDOB:")]
        STPSourceParams KlarnaParamsWithReturnURL(string returnURL, string currency, string purchaseCountry, STPKlarnaLineItem[] items, NSNumber[] customPaymentMethods, [NullAllowed] STPAddress address, [NullAllowed] string firstName, [NullAllowed] string lastName, [NullAllowed] STPDateOfBirth dateOfBirth);

        // +(STPSourceParams * _Nonnull)klarnaParamsWithReturnURL:(NSString * _Nonnull)returnURL currency:(NSString * _Nonnull)currency purchaseCountry:(NSString * _Nonnull)purchaseCountry items:(NSArray<STPKlarnaLineItem *> * _Nonnull)items customPaymentMethods:(NSArray<NSNumber *> * _Nonnull)customPaymentMethods __attribute__((warn_unused_result("")));
        [Export("klarnaParamsWithReturnURL:currency:purchaseCountry:items:customPaymentMethods:")]
        STPSourceParams KlarnaParamsWithReturnURL(string returnURL, string currency, string purchaseCountry, STPKlarnaLineItem[] items, NSNumber[] customPaymentMethods);

        // +(STPSourceParams * _Nonnull)threeDSecureParamsWithAmount:(NSInteger)amount currency:(NSString * _Nonnull)currency returnURL:(NSString * _Nonnull)returnURL card:(NSString * _Nonnull)card __attribute__((warn_unused_result("")));
        [Export("threeDSecureParamsWithAmount:currency:returnURL:card:")]
        STPSourceParams ThreeDSecureParamsWithAmount(nint amount, string currency, string returnURL, string card);

        // +(STPSourceParams * _Nonnull)alipayParamsWithAmount:(NSInteger)amount currency:(NSString * _Nonnull)currency returnURL:(NSString * _Nonnull)returnURL __attribute__((warn_unused_result("")));
        [Export("alipayParamsWithAmount:currency:returnURL:")]
        STPSourceParams AlipayParamsWithAmount(nint amount, string currency, string returnURL);

        // +(STPSourceParams * _Nonnull)alipayReusableParamsWithCurrency:(NSString * _Nonnull)currency returnURL:(NSString * _Nonnull)returnURL __attribute__((warn_unused_result("")));
        [Export("alipayReusableParamsWithCurrency:returnURL:")]
        STPSourceParams AlipayReusableParamsWithCurrency(string currency, string returnURL);

        // +(STPSourceParams * _Nonnull)p24ParamsWithAmount:(NSInteger)amount currency:(NSString * _Nonnull)currency email:(NSString * _Nonnull)email name:(NSString * _Nullable)name returnURL:(NSString * _Nonnull)returnURL __attribute__((warn_unused_result("")));
        [Export("p24ParamsWithAmount:currency:email:name:returnURL:")]
        STPSourceParams P24ParamsWithAmount(nint amount, string currency, string email, [NullAllowed] string name, string returnURL);

        // +(STPSourceParams * _Nonnull)visaCheckoutParamsWithCallId:(NSString * _Nonnull)callId __attribute__((warn_unused_result("")));
        [Export("visaCheckoutParamsWithCallId:")]
        STPSourceParams VisaCheckoutParamsWithCallId(string callId);

        // +(STPSourceParams * _Nonnull)masterpassParamsWithCartId:(NSString * _Nonnull)cartId transactionId:(NSString * _Nonnull)transactionId __attribute__((warn_unused_result("")));
        [Export("masterpassParamsWithCartId:transactionId:")]
        STPSourceParams MasterpassParamsWithCartId(string cartId, string transactionId);

        // +(STPSourceParams * _Nonnull)epsParamsWithAmount:(NSInteger)amount name:(NSString * _Nonnull)name returnURL:(NSString * _Nonnull)returnURL statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
        [Export("epsParamsWithAmount:name:returnURL:statementDescriptor:")]
        STPSourceParams EpsParamsWithAmount(nint amount, string name, string returnURL, [NullAllowed] string statementDescriptor);

        // +(STPSourceParams * _Nonnull)multibancoParamsWithAmount:(NSInteger)amount returnURL:(NSString * _Nonnull)returnURL email:(NSString * _Nonnull)email __attribute__((warn_unused_result("")));
        [Export("multibancoParamsWithAmount:returnURL:email:")]
        STPSourceParams MultibancoParamsWithAmount(nint amount, string returnURL, string email);

        // +(STPSourceParams * _Nonnull)wechatPayParamsWithAmount:(NSInteger)amount currency:(NSString * _Nonnull)currency appId:(NSString * _Nonnull)appId statementDescriptor:(NSString * _Nullable)statementDescriptor __attribute__((warn_unused_result("")));
        [Export("wechatPayParamsWithAmount:currency:appId:statementDescriptor:")]
        STPSourceParams WechatPayParamsWithAmount(nint amount, string currency, string appId, [NullAllowed] string statementDescriptor);

        // -(NSDictionary * _Nonnull)redirectDictionaryWithMerchantNameIfNecessary __attribute__((warn_unused_result("")));
        [Export("redirectDictionaryWithMerchantNameIfNecessary")]
        NSDictionary RedirectDictionaryWithMerchantNameIfNecessary();

        // +(NSString * _Nullable)rootObjectName __attribute__((warn_unused_result("")));
        [NullAllowed, Export("rootObjectName")]
        string RootObjectName { get; }

        // +(NSDictionary<NSString *,NSString *> * _Nonnull)propertyNamesToFormFieldNamesMapping __attribute__((warn_unused_result("")));
        [Export("propertyNamesToFormFieldNamesMapping")]
        NSDictionary<NSString, NSString> PropertyNamesToFormFieldNamesMapping { get; }

        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // @interface STPSourceReceiver : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe17STPSourceReceiver")]
    [DisableDefaultCtor]
    interface STPSourceReceiver //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable address;
        [NullAllowed, Export("address")]
        string Address { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable amountCharged;
        [NullAllowed, Export("amountCharged", ArgumentSemantic.Strong)]
        NSNumber AmountCharged { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable amountReceived;
        [NullAllowed, Export("amountReceived", ArgumentSemantic.Strong)]
        NSNumber AmountReceived { get; }

        // @property (readonly, nonatomic, strong) NSNumber * _Nullable amountReturned;
        [NullAllowed, Export("amountReturned", ArgumentSemantic.Strong)]
        NSNumber AmountReturned { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSourceReceiver DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPSourceRedirect : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe17STPSourceRedirect")]
    [DisableDefaultCtor]
    interface STPSourceRedirect //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSUrl * _Nonnull returnURL;
        [Export("returnURL", ArgumentSemantic.Copy)]
        NSUrl ReturnURL { get; }

        // @property (readonly, nonatomic) enum STPSourceRedirectStatus status;
        [Export("status")]
        STPSourceRedirectStatus Status { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nonnull url;
        [Export("url", ArgumentSemantic.Copy)]
        NSUrl Url { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSourceRedirect DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPSourceSEPADebitDetails : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe25STPSourceSEPADebitDetails")]
    [DisableDefaultCtor]
    interface STPSourceSEPADebitDetails //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable last4;
        [NullAllowed, Export("last4")]
        string Last4 { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable bankCode;
        [NullAllowed, Export("bankCode")]
        string BankCode { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable country;
        [NullAllowed, Export("country")]
        string Country { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable fingerprint;
        [NullAllowed, Export("fingerprint")]
        string Fingerprint { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable mandateReference;
        [NullAllowed, Export("mandateReference")]
        string MandateReference { get; }

        // @property (readonly, copy, nonatomic) NSUrl * _Nullable mandateURL;
        [NullAllowed, Export("mandateURL", ArgumentSemantic.Copy)]
        NSUrl MandateURL { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSourceSEPADebitDetails DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPSourceVerification : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe21STPSourceVerification")]
    [DisableDefaultCtor]
    interface STPSourceVerification //: STPAPIResponseDecodable
    {
        // @property (readonly, nonatomic, strong) NSNumber * _Nullable attemptsRemaining;
        [NullAllowed, Export("attemptsRemaining", ArgumentSemantic.Strong)]
        NSNumber AttemptsRemaining { get; }

        // @property (readonly, nonatomic) enum STPSourceVerificationStatus status;
        [Export("status")]
        STPSourceVerificationStatus Status { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSourceVerification DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPSourceWeChatPayDetails : NSObject <STPAPIResponseDecodable>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe25STPSourceWeChatPayDetails")]
    [DisableDefaultCtor]
    interface STPSourceWeChatPayDetails //: STPAPIResponseDecodable
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable weChatAppURL;
        [NullAllowed, Export("weChatAppURL")]
        string WeChatAppURL { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPSourceWeChatPayDetails DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPStringFromCardBrand : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe22STPStringFromCardBrand")]
    interface STPStringFromCardBrand
    {
    }

    // @interface STPTheme : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe8STPTheme")]
    partial interface STPTheme
    {
        // @property (readonly, nonatomic, strong, class) STPTheme * _Nonnull defaultTheme;
        [Static]
        [Export("defaultTheme", ArgumentSemantic.Strong)]
        STPTheme DefaultTheme { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull primaryBackgroundColor;
        [Export("primaryBackgroundColor", ArgumentSemantic.Strong)]
        UIColor PrimaryBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secondaryBackgroundColor;
        [Export("secondaryBackgroundColor", ArgumentSemantic.Strong)]
        UIColor SecondaryBackgroundColor { get; set; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull tertiaryBackgroundColor;
        [Export("tertiaryBackgroundColor", ArgumentSemantic.Strong)]
        UIColor TertiaryBackgroundColor { get; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull quaternaryBackgroundColor;
        [Export("quaternaryBackgroundColor", ArgumentSemantic.Strong)]
        UIColor QuaternaryBackgroundColor { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull primaryForegroundColor;
        [Export("primaryForegroundColor", ArgumentSemantic.Strong)]
        UIColor PrimaryForegroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secondaryForegroundColor;
        [Export("secondaryForegroundColor", ArgumentSemantic.Strong)]
        UIColor SecondaryForegroundColor { get; set; }

        // @property (readonly, nonatomic, strong) UIColor * _Nonnull tertiaryForegroundColor;
        [Export("tertiaryForegroundColor", ArgumentSemantic.Strong)]
        UIColor TertiaryForegroundColor { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull accentColor;
        [Export("accentColor", ArgumentSemantic.Strong)]
        UIColor AccentColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull errorColor;
        [Export("errorColor", ArgumentSemantic.Strong)]
        UIColor ErrorColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull font;
        [Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull emphasisFont;
        [Export("emphasisFont", ArgumentSemantic.Strong)]
        UIFont EmphasisFont { get; set; }

        // @property (nonatomic) UIBarStyle barStyle;
        [Export("barStyle", ArgumentSemantic.Assign)]
        UIBarStyle BarStyle { get; set; }

        // @property (nonatomic) BOOL translucentNavigationBar;
        [Export("translucentNavigationBar")]
        bool TranslucentNavigationBar { get; set; }

        // @property (readonly, nonatomic, strong) UIFont * _Nonnull smallFont;
        [Export("smallFont", ArgumentSemantic.Strong)]
        UIFont SmallFont { get; }

        // @property (readonly, nonatomic, strong) UIFont * _Nonnull largeFont;
        [Export("largeFont", ArgumentSemantic.Strong)]
        UIFont LargeFont { get; }
    }

    //// @interface Stripe_Swift_7409 (STPTheme) <NSCopying>
    //[Category]
    //[BaseType(typeof(STPTheme))]
    partial interface STPTheme : INSCopying
    {
        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // @interface STPThreeDSButtonCustomization : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe29STPThreeDSButtonCustomization")]
    [DisableDefaultCtor]
    interface STPThreeDSButtonCustomization
    {
        // +(STPThreeDSButtonCustomization * _Nonnull)defaultSettingsForButtonType:(enum STPThreeDSCustomizationButtonType)type __attribute__((warn_unused_result("")));
        [Static]
        [Export("defaultSettingsForButtonType:")]
        STPThreeDSButtonCustomization DefaultSettingsForButtonType(STPThreeDSCustomizationButtonType type);

        // -(instancetype _Nonnull)initWithBackgroundColor:(UIColor * _Nonnull)backgroundColor cornerRadius:(CGFloat)cornerRadius __attribute__((objc_designated_initializer));
        [Export("initWithBackgroundColor:cornerRadius:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIColor backgroundColor, nfloat cornerRadius);

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic) enum STPThreeDSButtonTitleStyle titleStyle;
        [Export("titleStyle", ArgumentSemantic.Assign)]
        STPThreeDSButtonTitleStyle TitleStyle { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable font;
        [NullAllowed, Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textColor;
        [NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }
    }

    // @interface STPThreeDSCustomizationSettings : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe31STPThreeDSCustomizationSettings")]
    interface STPThreeDSCustomizationSettings
    {
        // +(STPThreeDSCustomizationSettings * _Nonnull)defaultSettings __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use STPThreeDSCustomizationSettings() instead of STPThreeDSCustomizationSettings.defaultSettings().")));
        [Static]
        [Export("defaultSettings")]
        STPThreeDSCustomizationSettings DefaultSettings { get; }

        // @property (nonatomic, strong) STPThreeDSUICustomization * _Nonnull uiCustomization;
        [Export("uiCustomization", ArgumentSemantic.Strong)]
        STPThreeDSUICustomization UiCustomization { get; set; }

        // @property (nonatomic) NSInteger authenticationTimeout;
        [Export("authenticationTimeout")]
        nint AuthenticationTimeout { get; set; }
    }

    // @interface STPThreeDSFooterCustomization : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe29STPThreeDSFooterCustomization")]
    interface STPThreeDSFooterCustomization
    {
        // +(STPThreeDSFooterCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
        [Static]
        [Export("defaultSettings")]
        STPThreeDSFooterCustomization DefaultSettings { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull chevronColor;
        [Export("chevronColor", ArgumentSemantic.Strong)]
        UIColor ChevronColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull headingTextColor;
        [Export("headingTextColor", ArgumentSemantic.Strong)]
        UIColor HeadingTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nonnull headingFont;
        [Export("headingFont", ArgumentSemantic.Strong)]
        UIFont HeadingFont { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable font;
        [NullAllowed, Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textColor;
        [NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }
    }

    // @interface STPThreeDSLabelCustomization : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe28STPThreeDSLabelCustomization")]
    interface STPThreeDSLabelCustomization
    {
        // +(STPThreeDSLabelCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
        [Static]
        [Export("defaultSettings")]
        STPThreeDSLabelCustomization DefaultSettings { get; }

        // @property (nonatomic, strong) UIFont * _Nonnull headingFont;
        [Export("headingFont", ArgumentSemantic.Strong)]
        UIFont HeadingFont { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull headingTextColor;
        [Export("headingTextColor", ArgumentSemantic.Strong)]
        UIColor HeadingTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable font;
        [NullAllowed, Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textColor;
        [NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }
    }

    // @interface STPThreeDSNavigationBarCustomization : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe36STPThreeDSNavigationBarCustomization")]
    interface STPThreeDSNavigationBarCustomization
    {
        // +(STPThreeDSNavigationBarCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
        [Static]
        [Export("defaultSettings")]
        STPThreeDSNavigationBarCustomization DefaultSettings { get; }

        // @property (nonatomic, strong) UIColor * _Nullable barTintColor;
        [NullAllowed, Export("barTintColor", ArgumentSemantic.Strong)]
        UIColor BarTintColor { get; set; }

        // @property (nonatomic) UIBarStyle barStyle;
        [Export("barStyle", ArgumentSemantic.Assign)]
        UIBarStyle BarStyle { get; set; }

        // @property (nonatomic) BOOL translucent;
        [Export("translucent")]
        bool Translucent { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull headerText;
        [Export("headerText")]
        string HeaderText { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull buttonText;
        [Export("buttonText")]
        string ButtonText { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable font;
        [NullAllowed, Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textColor;
        [NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }
    }

    // @interface STPThreeDSSelectionCustomization : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe32STPThreeDSSelectionCustomization")]
    interface STPThreeDSSelectionCustomization
    {
        // +(STPThreeDSSelectionCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
        [Static]
        [Export("defaultSettings")]
        STPThreeDSSelectionCustomization DefaultSettings { get; }

        // @property (nonatomic, strong) UIColor * _Nonnull primarySelectedColor;
        [Export("primarySelectedColor", ArgumentSemantic.Strong)]
        UIColor PrimarySelectedColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull secondarySelectedColor;
        [Export("secondarySelectedColor", ArgumentSemantic.Strong)]
        UIColor SecondarySelectedColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull unselectedBackgroundColor;
        [Export("unselectedBackgroundColor", ArgumentSemantic.Strong)]
        UIColor UnselectedBackgroundColor { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull unselectedBorderColor;
        [Export("unselectedBorderColor", ArgumentSemantic.Strong)]
        UIColor UnselectedBorderColor { get; set; }
    }

    // @interface STPThreeDSTextFieldCustomization : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe32STPThreeDSTextFieldCustomization")]
    interface STPThreeDSTextFieldCustomization
    {
        // +(STPThreeDSTextFieldCustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
        [Static]
        [Export("defaultSettings")]
        STPThreeDSTextFieldCustomization DefaultSettings { get; }

        // @property (nonatomic) CGFloat borderWidth;
        [Export("borderWidth")]
        nfloat BorderWidth { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull borderColor;
        [Export("borderColor", ArgumentSemantic.Strong)]
        UIColor BorderColor { get; set; }

        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (nonatomic) UIKeyboardAppearance keyboardAppearance;
        [Export("keyboardAppearance", ArgumentSemantic.Assign)]
        UIKeyboardAppearance KeyboardAppearance { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull placeholderTextColor;
        [Export("placeholderTextColor", ArgumentSemantic.Strong)]
        UIColor PlaceholderTextColor { get; set; }

        // @property (nonatomic, strong) UIFont * _Nullable font;
        [NullAllowed, Export("font", ArgumentSemantic.Strong)]
        UIFont Font { get; set; }

        // @property (nonatomic, strong) UIColor * _Nullable textColor;
        [NullAllowed, Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }
    }

    // @interface STPThreeDSUICustomization : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe25STPThreeDSUICustomization")]
    interface STPThreeDSUICustomization
    {
        // +(STPThreeDSUICustomization * _Nonnull)defaultSettings __attribute__((warn_unused_result("")));
        [Static]
        [Export("defaultSettings")]
        STPThreeDSUICustomization DefaultSettings { get; }

        // @property (nonatomic, strong) STPThreeDSNavigationBarCustomization * _Nonnull navigationBarCustomization;
        [Export("navigationBarCustomization", ArgumentSemantic.Strong)]
        STPThreeDSNavigationBarCustomization NavigationBarCustomization { get; set; }

        // @property (nonatomic, strong) STPThreeDSLabelCustomization * _Nonnull labelCustomization;
        [Export("labelCustomization", ArgumentSemantic.Strong)]
        STPThreeDSLabelCustomization LabelCustomization { get; set; }

        // @property (nonatomic, strong) STPThreeDSTextFieldCustomization * _Nonnull textFieldCustomization;
        [Export("textFieldCustomization", ArgumentSemantic.Strong)]
        STPThreeDSTextFieldCustomization TextFieldCustomization { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic, strong) STPThreeDSFooterCustomization * _Nonnull footerCustomization;
        [Export("footerCustomization", ArgumentSemantic.Strong)]
        STPThreeDSFooterCustomization FooterCustomization { get; set; }

        // -(void)setButtonCustomization:(STPThreeDSButtonCustomization * _Nonnull)buttonCustomization forType:(enum STPThreeDSCustomizationButtonType)buttonType;
        [Export("setButtonCustomization:forType:")]
        void SetButtonCustomization(STPThreeDSButtonCustomization buttonCustomization, STPThreeDSCustomizationButtonType buttonType);

        // -(STPThreeDSButtonCustomization * _Nonnull)buttonCustomizationForButtonType:(enum STPThreeDSCustomizationButtonType)buttonType __attribute__((warn_unused_result("")));
        [Export("buttonCustomizationForButtonType:")]
        STPThreeDSButtonCustomization ButtonCustomizationForButtonType(STPThreeDSCustomizationButtonType buttonType);

        // @property (nonatomic, strong) STPThreeDSSelectionCustomization * _Nonnull selectionCustomization;
        [Export("selectionCustomization", ArgumentSemantic.Strong)]
        STPThreeDSSelectionCustomization SelectionCustomization { get; set; }

        // @property (nonatomic) UIActivityIndicatorViewStyle activityIndicatorViewStyle;
        [Export("activityIndicatorViewStyle", ArgumentSemantic.Assign)]
        UIActivityIndicatorViewStyle ActivityIndicatorViewStyle { get; set; }

        // @property (nonatomic) UIBlurEffectStyle blurStyle;
        [Export("blurStyle", ArgumentSemantic.Assign)]
        UIBlurEffectStyle BlurStyle { get; set; }
    }

    // @interface STPToken : NSObject <STPAPIResponseDecodable, STPSourceProtocol>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe8STPToken")]
    [DisableDefaultCtor]
    interface STPToken : /*STPAPIResponseDecodable,*/ STPSourceProtocol
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull tokenId;
        [Export("tokenId")]
        string TokenId { get; }

        // @property (readonly, nonatomic) BOOL livemode;
        [Export("livemode")]
        bool Livemode { get; }

        // @property (readonly, nonatomic) enum STPTokenType type;
        [Export("type")]
        STPTokenType Type { get; }

        // @property (readonly, nonatomic, strong) STPCard * _Nullable card;
        [NullAllowed, Export("card", ArgumentSemantic.Strong)]
        STPCard Card { get; }

        // @property (readonly, nonatomic, strong) STPBankAccount * _Nullable bankAccount;
        [NullAllowed, Export("bankAccount", ArgumentSemantic.Strong)]
        STPBankAccount BankAccount { get; }

        // @property (readonly, copy, nonatomic) NSDate * _Nullable created;
        [NullAllowed, Export("created", ArgumentSemantic.Copy)]
        NSDate Created { get; }

        // @property (readonly, copy, nonatomic) NSDictionary * _Nonnull allResponseFields;
        [Export("allResponseFields", ArgumentSemantic.Copy)]
        NSDictionary AllResponseFields { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull description;
        [Export("description")]
        string Description { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
        [Export("debugDescription")]
        string DebugDescription { get; }

        // -(BOOL)isEqual:(id _Nullable)object __attribute__((warn_unused_result("")));
        [Export("isEqual:")]
        bool IsEqual([NullAllowed] NSObject @object);

        // @property (readonly, nonatomic) NSUInteger hash;
        [Export("hash")]
        nuint Hash { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull stripeID;
        [Export("stripeID")]
        string StripeID { get; }

        // +(instancetype _Nullable)decodedObjectFromAPIResponse:(NSDictionary * _Nullable)response __attribute__((warn_unused_result("")));
        [Static]
        [Export("decodedObjectFromAPIResponse:")]
        [return: NullAllowed]
        STPToken DecodedObjectFromAPIResponse([NullAllowed] NSDictionary response);
    }

    // @interface STPUserInformation : NSObject <NSCopying>
    [BaseType(typeof(NSObject), Name = "_TtC6Stripe18STPUserInformation")]
    interface STPUserInformation : INSCopying
    {
        // @property (nonatomic, strong) STPAddress * _Nullable billingAddress;
        [NullAllowed, Export("billingAddress", ArgumentSemantic.Strong)]
        STPAddress BillingAddress { get; set; }

        // @property (nonatomic, strong) STPAddress * _Nullable shippingAddress;
        [NullAllowed, Export("shippingAddress", ArgumentSemantic.Strong)]
        STPAddress ShippingAddress { get; set; }

        // -(void)setBillingAddressWithBillingDetails:(STPPaymentMethodBillingDetails * _Nonnull)billingDetails;
        [Export("setBillingAddressWithBillingDetails:")]
        void SetBillingAddressWithBillingDetails(STPPaymentMethodBillingDetails billingDetails);

        // -(id _Nonnull)copyWithZone:(struct _NSZone * _Nullable)zone __attribute__((warn_unused_result("")));
        [Export("copyWithZone:")]
        unsafe NSObject CopyWithZone([NullAllowed] NSZone zone);
    }

    // @interface Stripe_Swift_7746 (UINavigationBar)
    [Category]
    [BaseType(typeof(UINavigationBar))]
    interface UINavigationBar_Stripe_Swift_7746
    {
        // -(void)stp_setTheme:(STPTheme * _Nonnull)theme __attribute__((deprecated("Use the `stp_theme` property instead")));
        [Static, Export("stp_setTheme:")]
        void Stp_setTheme(STPTheme theme);

        // @property (nonatomic, strong) STPTheme * _Nullable stp_theme;
        [Static, NullAllowed, Export("stp_theme", ArgumentSemantic.Strong)]
        STPTheme Stp_theme { get; set; }
    }

    // @interface STPApplePayContext : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPApplePayContext
    {
        // -(instancetype _Nullable)initWithPaymentRequest:(PKPaymentRequest * _Nonnull)paymentRequest delegate:(id<STPApplePayContextDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
        [Export("initWithPaymentRequest:delegate:")]
        [DesignatedInitializer]
        IntPtr Constructor(PKPaymentRequest paymentRequest, [NullAllowed] STPApplePayContextDelegate @delegate);

        // -(void)presentApplePayOnViewController:(UIViewController * _Nonnull)viewController completion:(void (^ _Nullable)(void))completion __attribute__((deprecated("Use `presentApplePay(completion:)` instead.", "presentApplePayWithCompletion:")));
        [Export("presentApplePayOnViewController:completion:")]
        void PresentApplePayOnViewController(UIViewController viewController, [NullAllowed] Action completion);

        // -(void)presentApplePayWithCompletion:(void (^ _Nullable)(void))completion __attribute__((availability(ios_app_extension, unavailable)));
        // [Unavailable (PlatformName.iOSAppExtension)]
        [Export("presentApplePayWithCompletion:")]
        void PresentApplePayWithCompletion([NullAllowed] Action completion);

        // -(void)presentApplePayFromWindow:(UIWindow * _Nullable)window withCompletion:(void (^ _Nullable)(void))completion;
        [Export("presentApplePayFromWindow:withCompletion:")]
        void PresentApplePayFromWindow([NullAllowed] UIWindow window, [NullAllowed] Action completion);

        // @property (nonatomic, strong) STPAPIClient * _Nonnull apiClient;
        [Export("apiClient", ArgumentSemantic.Strong)]
        STPAPIClient ApiClient { get; set; }
    }

    // @protocol STPApplePayContextDelegate <NSObject>
    [Protocol, Model(AutoGeneratedName = true)]
    [BaseType(typeof(NSObject))]
    interface STPApplePayContextDelegate
    {
        // @required -(void)applePayContext:(STPApplePayContext * _Nonnull)context didCreatePaymentMethod:(STPPaymentMethod * _Nonnull)paymentMethod paymentInformation:(PKPayment * _Nonnull)paymentInformation completion:(void (^ _Nonnull)(NSString * _Nullable, NSError * _Nullable))completion;
        [Abstract]
        [Export("applePayContext:didCreatePaymentMethod:paymentInformation:completion:")]
        void DidCreatePaymentMethod(STPApplePayContext context, STPPaymentMethod paymentMethod, PKPayment paymentInformation, Action<NSString, NSError> completion);

        // @required -(void)applePayContext:(STPApplePayContext * _Nonnull)context didCompleteWithStatus:(enum STPPaymentStatus)status error:(NSError * _Nullable)error;
        [Abstract]
        [Export("applePayContext:didCompleteWithStatus:error:")]
        void DidCompleteWithStatus(STPApplePayContext context, STPPaymentStatus status, [NullAllowed] NSError error);

        // @optional -(void)applePayContext:(STPApplePayContext * _Nonnull)context didSelectShippingMethod:(PKShippingMethod * _Nonnull)shippingMethod handler:(void (^ _Nonnull)(PKPaymentRequestShippingMethodUpdate * _Nonnull))handler;
        [Export("applePayContext:didSelectShippingMethod:handler:")]
        void DidSelectShippingMethod(STPApplePayContext context, PKShippingMethod shippingMethod, Action<PKPaymentRequestShippingMethodUpdate> handler);

        // @optional -(void)applePayContext:(STPApplePayContext * _Nonnull)context didSelectShippingContact:(PKContact * _Nonnull)contact handler:(void (^ _Nonnull)(PKPaymentRequestShippingContactUpdate * _Nonnull))handler;
        [Export("applePayContext:didSelectShippingContact:handler:")]
        void DidSelectShippingContact(STPApplePayContext context, PKContact contact, Action<PKPaymentRequestShippingContactUpdate> handler);
    }

    // @interface STPAPIClient : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPAPIClient
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull STPSDKVersion;
        [Static]
        [Export("STPSDKVersion")]
        string STPSDKVersion { get; }

        // @property (readonly, nonatomic, strong, class) STPAPIClient * _Nonnull sharedClient;
        [Static]
        [Export("sharedClient", ArgumentSemantic.Strong)]
        STPAPIClient SharedClient { get; }

        // @property (copy, nonatomic) NSString * _Nullable publishableKey;
        [NullAllowed, Export("publishableKey")]
        string PublishableKey { get; set; }

        // @property (nonatomic, strong) STPPaymentConfiguration * _Nonnull configuration;
        [Export("configuration", ArgumentSemantic.Strong)]
        STPPaymentConfiguration Configuration { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable stripeAccount;
        [NullAllowed, Export("stripeAccount")]
        string StripeAccount { get; set; }

        // @property (nonatomic, strong) STPAppInfo * _Nullable appInfo;
        [NullAllowed, Export("appInfo", ArgumentSemantic.Strong)]
        STPAppInfo AppInfo { get; set; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull apiVersion;
        [Static]
        [Export("apiVersion")]
        string ApiVersion { get; }

        // -(instancetype _Nonnull)initWithPublishableKey:(NSString * _Nonnull)publishableKey __attribute__((objc_designated_initializer));
        [Export("initWithPublishableKey:")]
        [DesignatedInitializer]
        IntPtr Constructor(string publishableKey);

        // -(instancetype _Nonnull)initWithConfiguration:(STPPaymentConfiguration * _Nonnull)configuration __attribute__((objc_designated_initializer)) __attribute__((deprecated("This initializer previously configured publishableKey and stripeAccount via the STPPaymentConfiguration instance. This behavior is deprecated; set the STPAPIClient configuration, publishableKey, and stripeAccount properties directly on the STPAPIClient instead.")));
        [Export("initWithConfiguration:")]
        [DesignatedInitializer]
        IntPtr Constructor(STPPaymentConfiguration configuration);

        // -(void)createTokenWithBankAccount:(STPBankAccountParams * _Nonnull)bankAccount completion:(void (^ _Nonnull)(STPToken * _Nullable, NSError * _Nullable))completion;
        [Export("createTokenWithBankAccount:completion:")]
        void CreateTokenWithBankAccount(STPBankAccountParams bankAccount, Action<STPToken, NSError> completion);

        // -(void)createTokenWithPersonalIDNumber:(NSString * _Nonnull)pii completion:(void (^ _Nullable)(STPToken * _Nullable, NSError * _Nullable))completion;
        [Export("createTokenWithPersonalIDNumber:completion:")]
        void CreateTokenWithPersonalIDNumber(string pii, [NullAllowed] Action<STPToken, NSError> completion);

        // -(void)createTokenWithSSNLast4:(NSString * _Nonnull)ssnLast4 completion:(void (^ _Nonnull)(STPToken * _Nullable, NSError * _Nullable))completion;
        [Export("createTokenWithSSNLast4:completion:")]
        void CreateTokenWithSSNLast4(string ssnLast4, Action<STPToken, NSError> completion);

        // -(void)createTokenWithConnectAccount:(STPConnectAccountParams * _Nonnull)account completion:(void (^ _Nullable)(STPToken * _Nullable, NSError * _Nullable))completion;
        [Export("createTokenWithConnectAccount:completion:")]
        void CreateTokenWithConnectAccount(STPConnectAccountParams account, [NullAllowed] Action<STPToken, NSError> completion);

        // -(void)uploadImage:(UIImage * _Nonnull)image purpose:(enum STPFilePurpose)purpose completion:(void (^ _Nullable)(STPFile * _Nullable, NSError * _Nullable))completion;
        [Export("uploadImage:purpose:completion:")]
        void UploadImage(UIImage image, STPFilePurpose purpose, [NullAllowed] Action<STPFile, NSError> completion);

        // -(void)createTokenWithCard:(STPCardParams * _Nonnull)cardParams completion:(void (^ _Nonnull)(STPToken * _Nullable, NSError * _Nullable))completion;
        [Export("createTokenWithCard:completion:")]
        void CreateTokenWithCard(STPCardParams cardParams, Action<STPToken, NSError> completion);

        // -(void)createTokenForCVCUpdate:(NSString * _Nonnull)cvc completion:(void (^ _Nullable)(STPToken * _Nullable, NSError * _Nullable))completion;
        [Export("createTokenForCVCUpdate:completion:")]
        void CreateTokenForCVCUpdate(string cvc, [NullAllowed] Action<STPToken, NSError> completion);

        // -(void)createSourceWithParams:(STPSourceParams * _Nonnull)sourceParams completion:(void (^ _Nonnull)(STPSource * _Nullable, NSError * _Nullable))completion;
        [Export("createSourceWithParams:completion:")]
        void CreateSourceWithParams(STPSourceParams sourceParams, Action<STPSource, NSError> completion);

        // -(void)retrieveSourceWithId:(NSString * _Nonnull)identifier clientSecret:(NSString * _Nonnull)secret completion:(void (^ _Nonnull)(STPSource * _Nullable, NSError * _Nullable))completion;
        [Export("retrieveSourceWithId:clientSecret:completion:")]
        void RetrieveSourceWithId(string identifier, string secret, Action<STPSource, NSError> completion);

        // -(void)startPollingSourceWithId:(NSString * _Nonnull)identifier clientSecret:(NSString * _Nonnull)secret timeout:(NSTimeInterval)timeout completion:(void (^ _Nonnull)(STPSource * _Nullable, NSError * _Nullable))completion __attribute__((availability(ios_app_extension, unavailable)));
        // [Unavailable (PlatformName.iOSAppExtension)]
        [Export("startPollingSourceWithId:clientSecret:timeout:completion:")]
        void StartPollingSourceWithId(string identifier, string secret, double timeout, Action<STPSource, NSError> completion);

        // -(void)stopPollingSourceWithId:(NSString * _Nonnull)identifier __attribute__((availability(ios_app_extension, unavailable)));
        // [Unavailable (PlatformName.iOSAppExtension)]
        [Export("stopPollingSourceWithId:")]
        void StopPollingSourceWithId(string identifier);

        // -(void)retrievePaymentIntentWithClientSecret:(NSString * _Nonnull)secret completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
        [Export("retrievePaymentIntentWithClientSecret:completion:")]
        void RetrievePaymentIntentWithClientSecret(string secret, Action<STPPaymentIntent, NSError> completion);

        // -(void)retrievePaymentIntentWithClientSecret:(NSString * _Nonnull)secret expand:(NSArray<NSString *> * _Nullable)expand completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
        [Export("retrievePaymentIntentWithClientSecret:expand:completion:")]
        void RetrievePaymentIntentWithClientSecret(string secret, [NullAllowed] string[] expand, Action<STPPaymentIntent, NSError> completion);

        // -(void)confirmPaymentIntentWithParams:(STPPaymentIntentParams * _Nonnull)paymentIntentParams completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
        [Export("confirmPaymentIntentWithParams:completion:")]
        void ConfirmPaymentIntentWithParams(STPPaymentIntentParams paymentIntentParams, Action<STPPaymentIntent, NSError> completion);

        // -(void)confirmPaymentIntentWithParams:(STPPaymentIntentParams * _Nonnull)paymentIntentParams expand:(NSArray<NSString *> * _Nullable)expand completion:(void (^ _Nonnull)(STPPaymentIntent * _Nullable, NSError * _Nullable))completion;
        [Export("confirmPaymentIntentWithParams:expand:completion:")]
        void ConfirmPaymentIntentWithParams(STPPaymentIntentParams paymentIntentParams, [NullAllowed] string[] expand, Action<STPPaymentIntent, NSError> completion);

        // -(void)retrieveSetupIntentWithClientSecret:(NSString * _Nonnull)secret completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion;
        [Export("retrieveSetupIntentWithClientSecret:completion:")]
        void RetrieveSetupIntentWithClientSecret(string secret, Action<STPSetupIntent, NSError> completion);

        // -(void)confirmSetupIntentWithParams:(STPSetupIntentConfirmParams * _Nonnull)setupIntentParams completion:(void (^ _Nonnull)(STPSetupIntent * _Nullable, NSError * _Nullable))completion;
        [Export("confirmSetupIntentWithParams:completion:")]
        void ConfirmSetupIntentWithParams(STPSetupIntentConfirmParams setupIntentParams, Action<STPSetupIntent, NSError> completion);

        // -(void)createPaymentMethodWithParams:(STPPaymentMethodParams * _Nonnull)paymentMethodParams completion:(void (^ _Nonnull)(STPPaymentMethod * _Nullable, NSError * _Nullable))completion;
        [Export("createPaymentMethodWithParams:completion:")]
        void CreatePaymentMethodWithParams(STPPaymentMethodParams paymentMethodParams, Action<STPPaymentMethod, NSError> completion);

        // -(void)createRadarSessionWithCompletion:(void (^ _Nonnull)(STPRadarSession * _Nullable, NSError * _Nullable))completion;
        [Export("createRadarSessionWithCompletion:")]
        void CreateRadarSessionWithCompletion(Action<STPRadarSession, NSError> completion);

        // -(void)createTokenWithPayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(STPToken * _Nullable, NSError * _Nullable))completion;
        [Export("createTokenWithPayment:completion:")]
        void CreateTokenWithPayment(PKPayment payment, Action<STPToken, NSError> completion);

        // -(void)createSourceWithPayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(STPSource * _Nullable, NSError * _Nullable))completion;
        [Export("createSourceWithPayment:completion:")]
        void CreateSourceWithPayment(PKPayment payment, Action<STPSource, NSError> completion);

        // -(void)createPaymentMethodWithPayment:(PKPayment * _Nonnull)payment completion:(void (^ _Nonnull)(STPPaymentMethod * _Nullable, NSError * _Nullable))completion;
        [Export("createPaymentMethodWithPayment:completion:")]
        void CreatePaymentMethodWithPayment(PKPayment payment, Action<STPPaymentMethod, NSError> completion);

        // +(NSError * _Nullable)pkPaymentErrorForStripeError:(NSError * _Nullable)stripeError __attribute__((warn_unused_result("")));
        [Static]
        [Export("pkPaymentErrorForStripeError:")]
        [return: NullAllowed]
        NSError PkPaymentErrorForStripeError([NullAllowed] NSError stripeError);
    }

    // @interface STPAppInfo : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface STPAppInfo
    {
        // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name partnerId:(NSString * _Nullable)partnerId version:(NSString * _Nullable)version url:(NSString * _Nullable)url __attribute__((objc_designated_initializer));
        [Export("initWithName:partnerId:version:url:")]
        [DesignatedInitializer]
        IntPtr Constructor(string name, [NullAllowed] string partnerId, [NullAllowed] string version, [NullAllowed] string url);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable partnerId;
        [NullAllowed, Export("partnerId")]
        string PartnerId { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable version;
        [NullAllowed, Export("version")]
        string Version { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable url;
        [NullAllowed, Export("url")]
        string Url { get; }
    }

    // @interface STPError : NSObject
    [BaseType(typeof(NSObject))]
    interface STPError
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull stripeDomain;
        [Static]
        [Export("stripeDomain")]
        string StripeDomain { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull errorMessageKey;
        [Static]
        [Export("errorMessageKey")]
        string ErrorMessageKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull hintKey;
        [Static]
        [Export("hintKey")]
        string HintKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull cardErrorCodeKey;
        [Static]
        [Export("cardErrorCodeKey")]
        string CardErrorCodeKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull errorParameterKey;
        [Static]
        [Export("errorParameterKey")]
        string ErrorParameterKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull stripeErrorCodeKey;
        [Static]
        [Export("stripeErrorCodeKey")]
        string StripeErrorCodeKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull stripeErrorTypeKey;
        [Static]
        [Export("stripeErrorTypeKey")]
        string StripeErrorTypeKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull stripeDeclineCodeKey;
        [Static]
        [Export("stripeDeclineCodeKey")]
        string StripeDeclineCodeKey { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull invalidNumber;
        [Static]
        [Export("invalidNumber")]
        string InvalidNumber { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull invalidExpMonth;
        [Static]
        [Export("invalidExpMonth")]
        string InvalidExpMonth { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull invalidExpYear;
        [Static]
        [Export("invalidExpYear")]
        string InvalidExpYear { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull invalidCVC;
        [Static]
        [Export("invalidCVC")]
        string InvalidCVC { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull incorrectNumber;
        [Static]
        [Export("incorrectNumber")]
        string IncorrectNumber { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull expiredCard;
        [Static]
        [Export("expiredCard")]
        string ExpiredCard { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull cardDeclined;
        [Static]
        [Export("cardDeclined")]
        string CardDeclined { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull processingError;
        [Static]
        [Export("processingError")]
        string ProcessingError { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull incorrectCVC;
        [Static]
        [Export("incorrectCVC")]
        string IncorrectCVC { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull incorrectZip;
        [Static]
        [Export("incorrectZip")]
        string IncorrectZip { get; }
    }

    // @interface StripeAPI : NSObject
    [BaseType(typeof(NSObject))]
    interface StripeAPI
    {
        // @property (copy, nonatomic, class) NSString * _Nullable defaultPublishableKey;
        [Static]
        [NullAllowed, Export("defaultPublishableKey")]
        string DefaultPublishableKey { get; set; }

        // @property (nonatomic, class) BOOL advancedFraudSignalsEnabled;
        [Static]
        [Export("advancedFraudSignalsEnabled")]
        bool AdvancedFraudSignalsEnabled { get; set; }

        // @property (nonatomic, class) NSInteger maxRetries;
        [Static]
        [Export("maxRetries")]
        nint MaxRetries { get; set; }

        // +(BOOL)handleStripeURLCallbackWithURL:(NSUrl * _Nonnull)url;
        [Static]
        [Export("handleStripeURLCallbackWithURL:")]
        bool HandleStripeURLCallbackWithURL(NSUrl url);

        // @property (nonatomic, class) BOOL jcbPaymentNetworkSupported;
        [Static]
        [Export("jcbPaymentNetworkSupported")]
        bool JcbPaymentNetworkSupported { get; set; }

        // @property (copy, nonatomic, class) NSArray<PKPaymentNetwork> * _Nonnull additionalEnabledApplePayNetworks;
        [Static]
        [Export("additionalEnabledApplePayNetworks", ArgumentSemantic.Copy)]
        string[] AdditionalEnabledApplePayNetworks { get; set; }

        // +(BOOL)canSubmitPaymentRequest:(PKPaymentRequest * _Nonnull)paymentRequest __attribute__((warn_unused_result("")));
        [Static]
        [Export("canSubmitPaymentRequest:")]
        bool CanSubmitPaymentRequest(PKPaymentRequest paymentRequest);

        // +(BOOL)deviceSupportsApplePay __attribute__((warn_unused_result("")));
        [Static]
        [Export("deviceSupportsApplePay")]
        bool DeviceSupportsApplePay { get; }

        // +(PKPaymentRequest * _Nonnull)paymentRequestWithMerchantIdentifier:(NSString * _Nonnull)merchantIdentifier __attribute__((warn_unused_result(""))) __attribute__((deprecated("Use `paymentRequestWithMerchantIdentifier:country:currency:` instead.")));
        [Static]
        [Export("paymentRequestWithMerchantIdentifier:")]
        PKPaymentRequest PaymentRequestWithMerchantIdentifier(string merchantIdentifier);

        // +(PKPaymentRequest * _Nonnull)paymentRequestWithMerchantIdentifier:(NSString * _Nonnull)merchantIdentifier country:(NSString * _Nonnull)countryCode currency:(NSString * _Nonnull)currencyCode __attribute__((warn_unused_result("")));
        [Static]
        [Export("paymentRequestWithMerchantIdentifier:country:currency:")]
        PKPaymentRequest PaymentRequestWithMerchantIdentifier(string merchantIdentifier, string countryCode, string currencyCode);
    }
}
