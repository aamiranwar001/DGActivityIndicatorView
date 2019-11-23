using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace DGActivityIndicatorView
{
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorAnimationProtocol
    {
        // @required -(void)setupAnimationInLayer:(CALayer *)layer withSize:(CGSize)size tintColor:(UIColor *)tintColor;
        [Abstract]
        [Export("setupAnimationInLayer:withSize:tintColor:")]
        void WithSize(CALayer layer, CGSize size, UIColor tintColor);
    }

    public interface IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallBeatAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallBeatAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallClipRotateAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallClipRotateAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallClipRotateMultipleAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallClipRotateMultipleAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallClipRotatePulseAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallClipRotatePulseAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallGridBeatAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallGridBeatAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallGridPulseAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallGridPulseAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallPulseAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallPulseAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallPulseSyncAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallPulseSyncAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallRotateAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallRotateAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallScaleAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallScaleAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallScaleMultipleAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallScaleMultipleAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallScaleRippleAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallScaleRippleAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallScaleRippleMultipleAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallScaleRippleMultipleAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallTrianglePathAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallTrianglePathAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallZigZagAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallZigZagAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorBallZigZagDeflectAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorBallZigZagDeflectAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorCookieTerminatorAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorCookieTerminatorAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorDoubleBounceAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorDoubleBounceAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorFiveDotsAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorFiveDotsAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorLineScaleAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorLineScaleAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorLineScalePartyAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorLineScalePartyAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorLineScalePulseOutAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorLineScalePulseOutAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorLineScalePulseOutRapidAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorLineScalePulseOutRapidAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorNineDotsAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorNineDotsAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorRotatingSandglassAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorRotatingSandglassAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorRotatingSquaresAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorRotatingSquaresAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorRotatingTrigonAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorRotatingTrigonAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorThreeDotsAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorThreeDotsAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorTriangleSkewSpinAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorTriangleSkewSpinAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorTriplePulseAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorTriplePulseAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorTripleRingsAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorTripleRingsAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorTwoDotsAnimation : NSObject <DGActivityIndicatorAnimationProtocol>
    [BaseType(typeof(NSObject))]
    public interface DGActivityIndicatorTwoDotsAnimation : IDGActivityIndicatorAnimationProtocol
    {
    }

    // @interface DGActivityIndicatorView : UIView
    [BaseType(typeof(UIView))]
    public interface DGActivityIndicatorView
    {
        // -(id)initWithType:(DGActivityIndicatorAnimationType)type;
        [Export("initWithType:")]
        IntPtr Constructor(DGActivityIndicatorAnimationType type);

        // -(id)initWithType:(DGActivityIndicatorAnimationType)type tintColor:(UIColor *)tintColor;
        [Export("initWithType:tintColor:")]
        IntPtr Constructor(DGActivityIndicatorAnimationType type, UIColor tintColor);

        // -(id)initWithType:(DGActivityIndicatorAnimationType)type tintColor:(UIColor *)tintColor size:(CGFloat)size;
        [Export("initWithType:tintColor:size:")]
        IntPtr Constructor(DGActivityIndicatorAnimationType type, UIColor tintColor, nfloat size);

        // @property (nonatomic) DGActivityIndicatorAnimationType type;
        [Export("type", ArgumentSemantic.Assign)]
        DGActivityIndicatorAnimationType Type { get; set; }

        // @property (nonatomic, strong) UIColor * tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; set; }

        // @property (nonatomic) CGFloat size;
        [Export("size")]
        nfloat Size { get; set; }

        // @property (readonly, nonatomic) BOOL animating;
        [Export("animating")]
        bool Animating { get; }

        // -(void)startAnimating;
        [Export("startAnimating")]
        void StartAnimating();

        // -(void)stopAnimating;
        [Export("stopAnimating")]
        void StopAnimating();
    }
}