using System;
using CoreGraphics;
using Foundation;
using UIKit;

namespace StripeUICore
{
	// @interface STP_Internal_ActivityIndicator : UIView
	[BaseType (typeof(UIView))]
	interface STP_Internal_ActivityIndicator
	{
		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(void)tintColorDidChange;
		[Export ("tintColorDidChange")]
		void TintColorDidChange ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)willMoveToWindow:(UIWindow * _Nullable)newWindow;
		[Export ("willMoveToWindow:")]
		void WillMoveToWindow ([NullAllowed] UIWindow newWindow);
	}

	// @interface STP_Internal_Button : UIControl
	[BaseType (typeof(UIControl))]
	interface STP_Internal_Button
	{
		// @property (readonly, nonatomic) UIControlState state;
		[Export ("state")]
		UIControlState State { get; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// -(void)tintColorDidChange;
		[Export ("tintColorDidChange")]
		void TintColorDidChange ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(UIView * _Nullable)hitTest:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("hitTest:withEvent:")]
		[return: NullAllowed]
		UIView HitTest (CGPoint point, [NullAllowed] UIEvent @event);

		// -(void)updateConstraints __attribute__((objc_requires_super));
		[Export ("updateConstraints")]
		void UpdateConstraints ();
	}

	// @interface STP_Internal_CheckboxButton : UIControl
	[BaseType (typeof(UIControl))]
	interface STP_Internal_CheckboxButton : IUITextViewDelegate
	{
		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (getter = isHidden, nonatomic) BOOL hidden;
		[Export ("hidden")]
		bool Hidden { [Bind ("isHidden")] get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(BOOL)textView:(UITextView * _Nonnull)textView shouldInteractWithURL:(NSURL * _Nonnull)url inRange:(NSRange)characterRange __attribute__((warn_unused_result("")));
		[Export ("textView:shouldInteractWithURL:inRange:")]
		bool ShouldInteractWithUrl(UITextView textView, NSUrl url, NSRange characterRange);
	}

	// @interface STP_Internal_DoneButtonToolbar : UIToolbar
	[BaseType (typeof(UIToolbar))]
	interface STP_Internal_DoneButtonToolbar
	{
	}

	// @interface STP_Internal_DropdownFieldElement : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface STP_Internal_DropdownFieldElement : IUIPickerViewDelegate, IUIPickerViewDataSource
    {
		// -(NSString * _Nullable)pickerView:(UIPickerView * _Nonnull)pickerView titleForRow:(NSInteger)row forComponent:(NSInteger)component __attribute__((warn_unused_result("")));
		[Export ("pickerView:titleForRow:forComponent:")]
		[return: NullAllowed]
		string GetTitle(UIPickerView pickerView, nint row, nint component);

		// -(void)pickerView:(UIPickerView * _Nonnull)pickerView didSelectRow:(NSInteger)row inComponent:(NSInteger)component;
		[Export ("pickerView:didSelectRow:inComponent:")]
		void Selected(UIPickerView pickerView, nint row, nint component);

		// -(NSInteger)numberOfComponentsInPickerView:(UIPickerView * _Nonnull)pickerView __attribute__((warn_unused_result("")));
		[Export ("numberOfComponentsInPickerView:")]
        nint GetComponentCount(UIPickerView pickerView);

		// -(NSInteger)pickerView:(UIPickerView * _Nonnull)pickerView numberOfRowsInComponent:(NSInteger)component __attribute__((warn_unused_result("")));
		[Export ("pickerView:numberOfRowsInComponent:")]
        nint GetRowsInComponent(UIPickerView pickerView, nint component);
	}

	// @interface STP_Internal_DynamicHeightContainerView : UIView
	[BaseType (typeof(UIView))]
	interface STP_Internal_DynamicHeightContainerView
	{
	}

	// @interface STP_Internal_FormView : UIView
	[BaseType (typeof(UIView))]
	interface STP_Internal_FormView
	{
	}

	// @interface STPEmailAddressValidator : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC12StripeUICore24STPEmailAddressValidator")]
	interface STPEmailAddressValidator
	{
	}

	// @interface STP_Internal_StackViewWithSeparator : UIStackView
	[BaseType (typeof(UIStackView))]
	interface STP_Internal_StackViewWithSeparator
	{
		// @property (nonatomic) CGFloat spacing;
		[Export ("spacing")]
		nfloat Spacing { get; set; }

		// @property (getter = isUserInteractionEnabled, nonatomic) BOOL userInteractionEnabled;
		[Export ("userInteractionEnabled")]
		bool UserInteractionEnabled { [Bind ("isUserInteractionEnabled")] get; set; }

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
		[Export ("traitCollectionDidChange:")]
		void TraitCollectionDidChange ([NullAllowed] UITraitCollection previousTraitCollection);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		IntPtr Constructor (CGRect frame);
	}
}
